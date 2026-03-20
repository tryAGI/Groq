#!/usr/bin/env bash
set -euo pipefail

# Groq spec is hosted on Stainless GCS with hash-based URLs that change each update.
# We dynamically resolve the latest URL from groq/groq-python/.stats.yml.
readonly stats_url="https://raw.githubusercontent.com/groq/groq-python/main/.stats.yml"

echo "Fetching latest spec URL from .stats.yml..."
openapi_url=$(curl --fail --silent --show-error --location "$stats_url" | grep 'openapi_spec_url:' | sed 's/openapi_spec_url: *//')

if [ -z "$openapi_url" ]; then
  echo "ERROR: Could not extract openapi_spec_url from .stats.yml"
  exit 1
fi

echo "Spec URL: $openapi_url"

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi

autosdk generate openapi.yaml \
  --namespace Groq \
  --clientClassName GroqClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
