call az account set --subscription "d8edfd3f-489d-4db6-b048-9f6647b7b8fe"
call az group deployment create -g "Target" --template-file .\azuredeploy.json --parameters .\azuredeploy.parameters.json --mode Complete --debug
