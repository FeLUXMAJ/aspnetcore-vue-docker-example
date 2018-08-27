# .NET Core Docker Example

> The backend based .NET Core Web API and the frontend is a Vue SPA.

## Start

Start the API services:
```bash
$ docker-compose -f docker-compose-api.yml  up
```

Start entire App that includes API services and Vue SPA:
```bash
$ docker-compose up
```

## Stop

If you want to stop containers and remove them, then run:
```
$ docker-compose down
```
