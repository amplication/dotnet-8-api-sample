
## Setup

- Create the initial db migration: `dotnet ef migrations add initialMigration`
- Run initial migration to db: `dotnet ef database update`


## Run locally

- Create the first time migration `dotnet ef migrations add initialMigration`
- For any new data model change, create the new migrations `dotnet ef migrations add <new migration name>`

### Run service locally

- Run the service's dependencies in Docker `docker-compose -f src/docker-compose.yml up`
- Run the service  `dotnet run --project ./src`


### Run service in docker

- Run the service and its dependencies in Docker `docker-compose -f src/docker-compose.yml --profile complete up`