SHELL = bash

PGPORT     ?= 5432
PGHOST     ?= localhost
PGUSER     ?= postgres
PGDATABASE ?= devbase
PGPASSWORD ?= postgres
PGIMAGE    ?= postgres:latest

.EXPORT_ALL_VARIABLES:

up:
	docker-compose up -d

db-up:
	docker-compose -f docker-compose.db.yaml up -d

down:
	docker-compose down

db-down:
	docker-compose -f docker-compose.db.yaml down

publish:
	cd ./WebApplication.EFCore && dotnet publish && cd ../Database.EFCore && dotnet publish

docker-build:
	docker build -f app.dockerfile -t web-app .

run:
	cd ./WebApplication.EFCore && set CONNECTION_STRING="Host=localhost;Port=5432;Database=devbase;User ID=postgres;Password=postgres;" && dotnet run

unlock-pgdata:
	sudo chmod a+rwx pgdata && sudo chown -R root:${USER} pgdata
