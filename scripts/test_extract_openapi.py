import importlib.util
import json
from pathlib import Path
import unittest

entry = Path(__file__).resolve().parents[1] / 'src/libs/Groq/extract-openapi.py'
spec = importlib.util.spec_from_file_location('extract_openapi', entry)
module = importlib.util.module_from_spec(spec)
spec.loader.exec_module(module)


class ExtractOpenApiTests(unittest.TestCase):
    def document(self, schema, split=False):
        payload = '9:["$","component",null,{"openapiSpec":' + json.dumps(schema) + '}]'
        chunks = [payload[:37], payload[37:]] if split else [payload]
        return ''.join('<script>self.__next_f.push(' + json.dumps([1, chunk]) + ')</script>' for chunk in chunks)

    def schema(self):
        return {'openapi': '3.0.1', 'info': {'title': 'GroqCloud API', 'description': 'Escaped "quotes" and \\newlines\n'},
                'paths': {'/openai/v1/chat/completions': {'post': {'operationId': 'createChatCompletion'}}}}

    def test_fragmented_document_preserves_complete_schema(self):
        value = self.schema()
        self.assertEqual(value, module.extract(self.document(value, True)))

    def test_missing_document_fails_closed(self):
        with self.assertRaises(ValueError): module.extract('<html>No schema</html>')

    def test_ambiguous_document_fails_closed(self):
        with self.assertRaises(ValueError): module.extract(self.document(self.schema()) * 2)

    def test_unexpected_schema_fails_closed(self):
        for value in [{}, {'openapi': '3.0.1', 'info': {'title': 'Another API'}, 'paths': {}}]:
            with self.assertRaises(ValueError): module.extract(self.document(value))


if __name__ == '__main__': unittest.main()
