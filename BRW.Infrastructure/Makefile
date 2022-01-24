add-migration:
	@read -p "Nome da migration (ex: TipoTabelaMotivo) : " table \
	&& dotnet ef --startup-project ../BRW.WebApi migrations add $${table}

remove-migration-linux:
	dotnet ef --startup-project ../BRW.WebApi migrations remove

update-database:
	@echo "Você revisou a migration antes de enviar?"
	@read -p "[Enter para confimar || CTRL + C para cancelar]" reponse;
	dotnet ef --startup-project ../BRW.WebApi database update
