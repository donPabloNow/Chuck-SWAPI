import swagger2json
import json
swagger= Swagger(json_url='codegen/in/swapi_open.json')
swagger.parse()
for items in swagger.result:
   print(json.dumps(items, sort_keys=True, indent=4, separators=(',', ': ')).encode('utf-8').decode('unicode_escape'))