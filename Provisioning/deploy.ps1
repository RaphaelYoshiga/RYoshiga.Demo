# parameters 
$resourceGroup = "ryoshiga-demo"

Import-Module AzureRM.Resources

#  login, you can comment so it stops asking for your credentials
#Login-AzureRmAccount

$scriptDir = Split-Path $MyInvocation.MyCommand.Path

Test-AzureRmResourceGroupDeployment -Verbose -ResourceGroupName $resourceGroup -TemplateFile "$scriptDir\template.json" -TemplateParameterFile "$scriptDir\parameters.json"

New-AzureRmResourceGroup -Location "ukwest" -Name $resourceGroup
New-AzureRmResourceGroupDeployment -Verbose -Force -ResourceGroupName $resourceGroup -TemplateFile "$scriptDir\template.json" -TemplateParameterFile "$scriptDir\parameters.json"


