# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Groq](https://groq.com/) inference platform, auto-generated from the Groq OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization. Currently a placeholder/incomplete SDK.

## Build Commands

```bash
# Build the solution
dotnet build Groq.slnx

# Build for release (also produces NuGet package)
dotnet build Groq.slnx -c Release

# Run integration tests (requires GROQ_API_KEY env var)
dotnet test src/tests/IntegrationTests/Groq.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Groq && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Groq/Generated/`.

1. `src/libs/Groq/openapi.yaml` -- the Groq OpenAPI spec
2. `src/libs/Groq/generate.sh` -- orchestrates: fix spec, run AutoSDK CLI, output to `Generated/`
3. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Groq/` | Main SDK library (`GroqClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Groq API |

### Build Configuration

- **Target:** `net10.0`
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
