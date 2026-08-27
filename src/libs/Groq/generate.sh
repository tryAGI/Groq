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

# OpenAPI spec: resolved from groq/groq-python/.stats.yml (Stainless-hosted)

# Groq spec is hosted on Stainless GCS with hash-based URLs that change each update.
# We dynamically resolve the latest URL from groq/groq-python/.stats.yml.
readonly stats_url="https://raw.githubusercontent.com/groq/groq-python/main/.stats.yml"
readonly fallback_openapi_url="https://storage.googleapis.com/stainless-sdk-openapi-specs/groqcloud/groqcloud-debd965baa031e12228c41e538741fa6055bf2813bcd062840a19f84a17cea95.yml"

echo "Fetching latest spec URL from .stats.yml..."
stats=$(fetch_spec --fail --silent --show-error --location "$stats_url")
openapi_url=$(printf '%s\n' "$stats" | sed -n 's/^openapi_spec_url: *//p')

if [ -z "$openapi_url" ]; then
  echo "WARN: .stats.yml does not expose openapi_spec_url; using the last official Stainless URL."
  openapi_url="$fallback_openapi_url"
fi

echo "Spec URL: $openapi_url"
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

# Note: The Groq spec already uses standard HTTP bearer auth and top-level security,
# so no FixOpenApiSpec step is needed.

autosdk generate openapi.yaml \
  --namespace Groq \
  --clientClassName GroqClient \
  --targetFramework net10.0 \
  --output Generated \
  --auth-env-var GROQ_API_KEY \
  --exclude-deprecated-operations
