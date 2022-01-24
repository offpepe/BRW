build-backend-image:
	docker build -t brw-app .
	
deploy-project:
	docker kill brw-app brw-database
	docker container prune
	docker rmi brw-app brw-database
	docker build -t brw-app .
	docker-compose -f ./docker-compose.yml up -d

update-image-linux:
	docker kill brw-app
	docker rm brw-app
	docker rmi brw-app
	docker build -t brw-app .
	docker run -d -p 5000:80 -p 5001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=5001 -e ASPNETCORE_Kestrel__Certificates__Default__Password="1e4794496a58be1f176346173efae5421420aef3" -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx -v /home/$(USER)/.aspnet/https:/https/ --name brw-app brw-app:latest

kill-app:
	docker kill brw-app brw-database
	docker container prune
	docker rmi brw-app brw-database
