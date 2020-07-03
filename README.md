# Api Cliente - AirLiquide - Willian Gaio

Tecnologias <br>
----------------------------------<br>
Framework: .net core<br>
Banco: SqlServer (LocalDB)<br>
Orm: EF<br>
Testes Chamada Api: Postman<br>
<br>
Rotas Api<br>
----------------------------------<br>
Get: https://localhost:5001/api/Clientes/ <br>
Get: https://localhost:5001/api/Clientes/{Guid}<br>
Post: https://localhost:5001/api/Clientes/<br>
{<br>
"Nome":"Shirley",<br>
"Idade": "30"<br>
}<br>
Put: https://localhost:5001/api/Clientes/{Guid}<br>
{<br>
"Nome":"Alteração Shirley",<br>
"Idade": "30"<br>
}<br>
Delete: https://localhost:5001/api/Clientes/{Guid}
