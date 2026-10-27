#!/usr/bin/env python3
"""Read the OpenAPI object embedded in Groq's public API-reference document."""
import argparse
import json
from pathlib import Path
import re


def extract(document):
    chunks = []
    for match in re.finditer(r'self\.__next_f\.push\((\[.*?\])\)</script>', document, re.S):
        item = json.loads(match.group(1))
        if len(item) > 1 and item[0] == 1 and isinstance(item[1], str):
            chunks.append(item[1])
    payload = ''.join(chunks)
    marker = '"openapiSpec":'
    if payload.count(marker) != 1:
        raise ValueError('Expected exactly one embedded OpenAPI document; documentation layout changed')
    spec, _ = json.JSONDecoder().raw_decode(payload.split(marker, 1)[1].lstrip())
    if (not isinstance(spec, dict) or not str(spec.get('openapi', '')).startswith('3.')
            or spec.get('info', {}).get('title') != 'GroqCloud API'
            or not isinstance(spec.get('paths'), dict)
            or '/openai/v1/chat/completions' not in spec['paths']):
        raise ValueError('The embedded document is not the expected Groq OpenAPI schema')
    return spec


if __name__ == '__main__':
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('document', type=Path)
    parser.add_argument('output', type=Path)
    args = parser.parse_args()
    args.output.write_text(json.dumps(extract(args.document.read_text()), indent=2) + '\n')
