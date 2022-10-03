include ./api/.env

.PHONY: up

up:
	docker-compose --env-file .\api\.env up -d

.PHONY: down

down:
	docker-compose --env-file .\api\.env down

.PHONY: logs

logs:
	docker-compose logs -f

