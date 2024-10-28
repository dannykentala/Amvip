# This script allows you to create a table file tree
## Get to root dir
declare rootDir=`pwd`
declare rootProjectDir="${rootDir}/src"

cd $rootProjectDir

##----- GLOBAL VARIBLES -----##
declare projectName="Amvip"
declare entityBase="Invitation"
declare entity="${entityBase}s"

##----- SCRIPT -----##
touch Infrastructure/${projectName}.Infrastructure/Repository/${entity}Repository.cs

touch ApplicationCore/${projectName}.Domain/Models/DTOs/Getters/${entityBase}Dto.cs
touch ApplicationCore/${projectName}.Domain/Interfaces/Repositories/I${entity}Repository.cs

touch ApplicationCore/${projectName}.Application/Managers/${entity}Manager.cs
touch ApplicationCore/${projectName}.Application/Mappers/${entityBase}Profile.cs

mkdir Presentation/${projectName}.Api/Controllers/${entity}
touch Presentation/${projectName}.Api/Controllers/${entity}/${entity}Controller.cs
touch Presentation/${projectName}.Api/Controllers/${entity}/${entity}CreateController.cs

#----- Remember the following order

#- Core
# DTOs
# Interfaces

#- Infrastrucure
# Repository
# Data -> BaseContex
# Data -> JsonBaseContex -> get database
# Data -> JsonBaseContex -> export database
# DependencyInjection

#- Application
# Mappers
# Responses
# Managers
# DependencyInjection

#- Api
# Controllers