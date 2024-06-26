# Tapawingo Backend

## Setup
First Make sure u already have a database in mysql, and add the authorization to the connectionstring: 
```json
"DefaultConnection": "server=localhost;database={database name};user={user from mysql};password={password for user}"
```

## Database tables
Then run command in the Package Manager Console (You can find it by using the search in the toolbar):
Command can differ between usage of IDE.

Visual Studio Code:
```bash
dotnet ef database update
```
Visual Studio 2022:
```bash
Update-Database
```

## Start backend: 
Visual Studio Code:
```bash
dotnet run
```

Visual Studio 2022:
You can use the play button in the toolbar, it needs to say (https).

## Packages
To add a NuGet package in Visual Studio Code:
```bash
dotnet add package {packageName}
```
For Visual Studio 2022(You can also use the NuGet Package Manager):
```bash
Install-Package {packageName}
```

## Project structure
1. Models: Contains the entities that are used in the database.
2. Data: Contains the Database context file.
3. Dtos: Contains the Data Transfer Objects that are used to send data to the client.
4. Controllers: Contains the controllers that are used to handle the requests.
5. Services: Contains the services that are used to handle the business logic.
6. Repositories: Contains the repositories that are used to handle the database logic.

## RabbitMQ
1. Create the RabbitMQ Docker image with command: `docker run -d --hostname rmq --name rabbit:server -p 8080:15672 -p 5672:5672 rabbitmq:3-management`
2. Make sure the RabbitMQ project (in Backend directory) has package RabbitMQ.Client. If not, you can add this using command: `dotnet add package RabbitMQ.Client`

To start 3 projects simultaneously:
1. Expand start button in visual studio
2. Click 'Startup options'
3. Select 'Multiple startup projects'
4. Select:
- Tapawingo_backend --> Start
- Tapawingo_backend.RabbitMQ_Receiver_Example --> start
- Tapawingo_backend.RabbitMQ_Sender_Example --> start
- Tapawingo_backend.Tests --> none

## API Endpoints
To see all the endpoints that are available in the API, you can go to the swagger page of the API(ApiUrl/swagger/index.html).

## Migrations
### show all migrations: 
Visual Studio Code:
```bash
dotnet ef migrations list
```
Visual Studio 2022:
```bash
Get-Migrations
```

### Create new migration
Visual Studio Code:
```bash
dotnet ef migrations add {name of migration}
```
Visual Studio 2022:
```bash
Add-Migration {name of migration}
```
After command, dont forget to add new tables to the contextFile.

### Remove a made migration before setting it to the database
Visual Studio Code:
```bash
dotnet ef migrations remove
```
Visual Studio 2022:
```bash
Remove-Migration
```

### Revert to a specific migration
Visual Studio Code:
```bash
dotnet ef database update {name of migration where you want to go}
```
Visual Studio 2022:
```bash
Update-Database {name of migration where you want to go}
```
When executing this command, you will need to remove the migration that you want to go to.
To add change to dataset: 1. first revert 2. remove 3. add 4. run
