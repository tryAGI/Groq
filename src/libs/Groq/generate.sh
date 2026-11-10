#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# Groq no longer publishes a spec URL in .stats.yml. The public API reference
# embeds the official OpenAPI document; parse it as data without executing scripts.
html_tmp="$(mktemp)"
spec_tmp="$(mktemp)"
trap 'rm -f "$html_tmp" "$spec_tmp"' EXIT
fetch_spec https://console.groq.com/docs/api-reference -o "$html_tmp"
python3 extract-openapi.py "$html_tmp" "$spec_tmp"
if [[ -n "${AUTOSDK_EXECUTABLE:-}" ]]; then
  autosdk() { "$AUTOSDK_EXECUTABLE" "$@"; }
else
  install_autosdk_cli
fi
mv "$spec_tmp" openapi.yaml
rm -rf Generated

# Note: The Groq spec already uses standard HTTP bearer auth and top-level security,
# so no FixOpenApiSpec step is needed.

# `stream: true` on chat completions returns server-sent events, and the spec says only
# `application/json` - so the generator has no reason to emit a streaming method and a caller who
# sets the flag gets a parse failure instead of a stream. The spec already carries the event schema
# (`CreateChatCompletionStreamResponse`); declaring the content type is all that is missing.
yq -i '.paths."/openai/v1/chat/completions".post.responses."200".content."text/event-stream".schema."$ref" = "#/components/schemas/CreateChatCompletionStreamResponse"' openapi.yaml

# yq exits 0 when its expression fails to parse, so verify the effect rather than the exit code.
if ! yq -e '.paths."/openai/v1/chat/completions".post.responses."200".content | has("text/event-stream")' openapi.yaml >/dev/null; then
  echo "error: the streaming content-type patch did not apply to openapi.yaml." >&2
  exit 1
fi

autosdk generate openapi.yaml \
  --namespace Groq \
  --clientClassName GroqClient \
  --targetFramework net10.0 \
  --output Generated \
  --auth-env-var GROQ_API_KEY \
  --exclude-deprecated-operations
