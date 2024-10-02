dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://storage.googleapis.com/stainless-sdk-openapi-specs/groqcloud%2Fgroqcloud-1f0d266ba97b03672f10d33a6dc6e324af9a95646f978ffbff6a31f3907bbfe7.yml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace Groq \
  --clientClassName GroqClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations