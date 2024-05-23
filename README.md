
# Getting started

## Step 1: Configuration

## Step 2.1: Scripts - pre-requisites


```sh
# installation of the dependencies
$ dotnet restore .

# create and apply initial migration
$ dotnet ef migrations add initialMigration
```

## Step 2.1: Scripts - database schema migrations

```sh
# For any database model change, create the new migrations
$ dotnet ef migrations add <new migration name>
```

> Migration will be automatically applied on docker compose up

## Step 2.2: Scripts - local development

- Run the service's dependencies in Docker `docker-compose up`
- Run the service  `dotnet run --project ./src`

## Step 2.2: Scripts - container based development

- Run the service and its dependencies in Docker `docker-compose --profile complete up`

## Apply database migration in non-local environment 

Database modification in non-local enviroment would be applied throught different strategies depending on the requirements. 
Follow Microsoft directions for your strategy: https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying