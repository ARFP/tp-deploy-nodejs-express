# Products API Database

Commande Docker pour cr�er le conteneur h�bergeant la base de donn�es : 

```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=MyPassword1234" -p 1433:1433 --name products_sqlserver --hostname products_sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
```
