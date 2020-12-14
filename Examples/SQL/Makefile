SHELL = bash

PGPORT     ?= 5444
PGHOST     ?= localhost
PGUSER     ?= postgres
PGDATABASE ?= devbase
PGPASSWORD ?= postgres
PGIMAGE    ?= postgres:latest

.EXPORT_ALL_VARIABLES:

up:
	docker-compose up -d

down:
	docker-compose down

unlock-pgdata:
	sudo chmod a+rwx pgdata && sudo chown -R root:${USER} pgdata
