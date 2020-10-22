New-Item -ItemType Directory -Path ".\codegen\in\"
New-Item -ItemType Directory -Path ".\codegen\out\"

#Create Directories:

mkdir -p codegen/in/ codegen/out/


#Install Dependencies:

wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/requirements.txt
wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/utils.py
pip install -r requirements.txt
pip install json2swagger
docker pull swaggerapi/swagger-codegen-cli
pip install json-to-swagger


#Convert api.chucknorris.io/documentation to json

curl -s https://api.chucknorris.io/documentation | python -m json.tool > codegen/in/chuck.json
curl -s https://swapi.dev/api/people/schema | python -m json.tool > codegen/in/swapi_json_schema.json


#Codegen configuration file for a python module

echo '{
  "packageName":"chuckclient",
  "projectName":"chuckclient",
  "packageVersion":"1.0.0"
}' > codegen/in/config_chuckapi.json
echo '{
  "packageName":"swapiclient",
  "projectName":"swapiclient",
  "packageVersion":"1.0.0"
}' > codegen/in/config_swapi.json
echo '{
  "packageName":"chuckswapi",
  "projectName":"chuckswapi",
  "packageVersion":"1.0.0"
}' > codegen/in/config_chuckswapi.json


#Create a new ChuckNorris client SDK:

docker run --rm -v ${PWD}/codegen:/local \
  swaggerapi/swagger-codegen-cli generate \
    -i /local/in/chuck.json \
    -o /local/out/chuckclient \
    -c /local/in/config_chuck.json \
    -l aspnetcore

docker run --rm -v ${PWD}/codegen:/local \
  swaggerapi/swagger-codegen-cli generate \
    -i /local/in/swapi.json \
    -o /local/out/swapiclient \
    -c /local/in/config_swapi.json \
    -l aspnetcore

docker run --rm -v ${PWD}/codegen:/local \
  swaggerapi/swagger-codegen-cli generate \
    -i /local/in/chuckswapi.json \
    -o /local/out/chuckswapi \
    -c /local/in/config_chuckswapi.json \
    -l aspnetcore


#Generate Project


mkdir src
cd src
dotnet new webapi
pause