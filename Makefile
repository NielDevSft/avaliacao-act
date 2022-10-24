include ./java-api/.env

.PHONY: up

up:
	docker-compose --env-file .\java-api\.env up -d

.PHONY: down

down:
	docker-compose --env-file .\java-api\.env down

.PHONY: logs

logs:
	docker-compose logs -f

