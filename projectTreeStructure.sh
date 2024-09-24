# default projectName
mkdir projectStructure

cd projectStructure

mkdir -p src
mkdir -p assets


#----- PENDING TO ORDER -----#
mkdir -p pending/Responses #Note [0.1]

#----- ApplicationCore -----#

# Application
mkdir -p src/ApplicationCore
mkdir -p src/ApplicationCore/Application
mkdir -p src/ApplicationCore/Application/Generators
mkdir -p src/ApplicationCore/Application/Managers #Note [1]
mkdir -p src/ApplicationCore/Application/Mappers
mkdir -p src/ApplicationCore/Application/Utils
mkdir -p src/ApplicationCore/Application/Validations
mkdir -p src/ApplicationCore/Application/Validations/Fluent #Note [2]
mkdir -p src/ApplicationCore/Application/Validations/Interations #Note [3]

# Domain
mkdir -p src/ApplicationCore/Domain
mkdir -p src/ApplicationCore/Domain/Models
mkdir -p src/ApplicationCore/Domain/Models/Entities
mkdir -p src/ApplicationCore/Domain/Models/DTOs
mkdir -p src/ApplicationCore/Domain/Models/Enums

mkdir -p src/ApplicationCore/Domain/Interfaces
mkdir -p src/ApplicationCore/Domain/Interfaces/Repositories
mkdir -p src/ApplicationCore/Domain/Interfaces/Services

#----- Infrastructure -----#
mkdir -p src/Infrastructure
mkdir -p src/Infrastructure/Repository
mkdir -p src/Infrastructure/Services
mkdir -p src/Infrastructure/Data

#----- Presentation -----#
mkdir -p src/Presentation
mkdir -p src/Presentation/Api/Controllers

mkdir -p src/Presentation/Mvc/Controllers
mkdir -p src/Presentation/Mvc/Views

#---------- Assets ----------#
#--------------------#
mkdir -p assets
mkdir -p assets/data
mkdir -p assets/data/sql
touch assets/data/sql/Tables.sql
touch assets/data/sql/Data.sql #Example data

mkdir -p assets/images

#---------- Test ----------#
#--------------------#
mkdir -p test



##----- NOTES -----##

<<Block_comment
[0.1]: How you response to user requests, for example {status: 200, data: {data}}

[1]: Remember that Presentation doesn't have access to persistence. Only in complilation time.
Managers, handle with presentation and persistence.

[2]: To validate fields in models that interact in presentation controllers (incoming data)

[3]: Business case validations

Block_comment