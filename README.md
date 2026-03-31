# Users API - ASP.NET Core

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=flat&logo=dotnet&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-47A248?style=flat&logo=mongodb&logoColor=white)

<p align="justify">
API desenvolvida em <strong>C# com .NET</strong> utilizando o padrão de <strong>Controllers (MVC)</strong>, com integração ao <strong>MongoDB</strong>. O projeto implementa uma 
<strong>API REST completa (CRUD)</strong>, permitindo operações de criação, leitura, atualização e exclusão de dados, com foco na prática de desenvolvimento backend e manipulação 
de dados em aplicações modernas.
</p>


## Funcionalidades

- Cadastro de usuários com os seguintes campos:
  - Nome
  - E-mail
  - Senha
  - Código de Pessoa
  - Lembrete de Senha
  - Idade
  - Sexo

- Operações completas de CRUD:
  - Criar usuários
  - Listar todos os usuários
  - Buscar usuário por ID
  - Buscar usuário por e-mail
  - Atualizar dados
  - Deletar usuários

---

## Endpoints

<div align="center">

<table>
<tr>
<th>Método</th>
<th>Rota</th>
<th>Descrição</th>
</tr>

<tr><td>GET</td><td>/api/usuarios</td><td>Lista todos os usuários</td></tr>
<tr><td>GET</td><td>/api/usuarios/{id}</td><td>Busca um usuário pelo ID</td></tr>
<tr><td>GET</td><td>/api/usuarios/email/{email}</td><td>Busca um usuário pelo e-mail</td></tr>
<tr><td>POST</td><td>/api/usuarios</td><td>Cria um novo usuário</td></tr>
<tr><td>PUT</td><td>/api/usuarios/{id}</td><td>Atualiza todos os dados</td></tr>
<tr><td>DELETE</td><td>/api/usuarios/{id}</td><td>Remove um usuário</td></tr>

</table>

</div>

---

## Exemplo de Usuário (JSON)

```json
{
  "nome": "João Lima Santos",
  "email": "joao.lima@gmail.com",
  "senha": "Bobby123",
  "codigoPessoa": "ABC123",
  "lembreteSenha": "Nome do primeiro pet",
  "idade": 25,
  "sexo": "Masculino"
}
```
## Como Executar

1. Clone o repositório:  
   ```bash
   git clone <URL_DO_REPOSITORIO>
2. Abra a solução no Visual Studio
3. Configure a conexão com o MongoDB no arquivo de configuração (caso necessário)
4. Execute o projeto
5. Utilize ferramentas como Swagger para testar os endpoints

## Testes

Todos os endpoints foram testados utilizando o <strong>Swagger</strong>, garantindo o funcionamento correto das operações de CRUD.
