## Get to root dir
declare rootDir=`pwd`
declare rootProjectDir="${rootDir}/src"

cd $rootProjectDir

##----- GLOBAL VARIBLES -----##
declare projectName="Amvip"

# declare modelName="<modelName>"
# declare globalModelNaming=${modelName}es

##----- PROJECT CREATION -----##
# dotnet new webapi --no-openapi --use-controllers -o Presentation/${projectName}.Api

# dotnet new classlib -o ApplicationCore/${projectName}.Application
# dotnet new classlib -o ApplicationCore/${projectName}.Domain

# dotnet new classlib -o Infrastructure/${projectName}.Infrastructure

##----- LINK PROJECTS -----##
# dotnet add ApplicationCore/${projectName}.Application/${projectName}.Application.csproj reference ApplicationCore/${projectName}.Domain/${projectName}.Domain.csproj 

# dotnet add Infrastructure/${projectName}.Infrastructure/${projectName}.Infrastructure.csproj reference ApplicationCore/${projectName}.Application/${projectName}.Application.csproj 

# dotnet add Presentation/${projectName}.Api/${projectName}.Api.csproj reference ApplicationCore/${projectName}.Application/${projectName}.Application.csproj 
# dotnet add Presentation/${projectName}.Api/${projectName}.Api.csproj reference Infrastructure/${projectName}.Infrastructure/${projectName}.Infrastructure.csproj 

##----- TREE FOLDERS -----##