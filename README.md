# Chuck SWAPI
.NET CORE C# Chuck SWAPI Project

## Installation

Clone the repository, build the solution with dotnet build. Run the project with dotnet run.

## Prerequisites

.NET CORE v3.1
Docker
Python
PIP
NPM
WGET
Bash

## Creation Process

Install Swagger Codegen Cli

```
docker pull swaggerapi/swagger-codegen-cli
```

Create Directories:
```
mkdir -p codegen/in/ codegen/out/
```

Install Python Dependencies:
```
wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/requirements.txt
wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/utils.py
pip install -r requirements.txt
```

Convert api.chucknorris.io/documentation to json
```
curl -s https://api.chucknorris.io/documentation | python -m json.tool > codegen/in/chuck.json
curl -s https://swapi.dev/api/ | python -m json.tool > codegen/in/swapi.json
```

Codegen configuration file for a python module
```
echo '{
  "packageName":"chuckswapi",
  "projectName":"chuckswapi",
  "packageVersion":"1.0.0"
}' > codegen/in/config_chuckswapi.json
```

Create a new ChuckNorris client SDK:
```
docker run --rm -v ${PWD}/codegen:/local \
  swaggerapi/swagger-codegen-cli generate \
    -i /local/in/chuck.json \
    -o /local/out/chuckswapi \
    -c /local/in/config_chuckswapi_api.json \
    -l aspnetcore
```


## Technologies Used
ASP .NET Core v3.1
C#
Python
Docker
Bash
PIP

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
