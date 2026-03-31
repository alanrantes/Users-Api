# Users API | ASP.NET Core + MongoDB

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=flat&logo=dotnet&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-47A248?style=flat&logo=mongodb&logoColor=white)

<p align="justify">
API REST para gerenciamento de usuários, desenvolvida em C# com ASP.NET Core e integrada ao MongoDB. O projeto implementa operações completas de CRUD (Create, Read, Update e Delete), seguindo o padrão de Controllers (MVC) para organização da aplicação.

Foi construída com foco na prática de desenvolvimento backend, abordando conceitos como estruturação de APIs, manipulação de dados em banco NoSQL e boas práticas de organização de código.
</p>

---

## 🛠️ Tecnologias

- C#
- ASP.NET Core
- MongoDB
- Swagger

---

## 🚀 Funcionalidades

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
  - Buscar por ID e e-mail
  - Atualizar dados
  - Remover usuários

---

## 🔗 Endpoints

| Método | Rota                         | Descrição                     |
|--------|------------------------------|--------------------------------|
| GET    | /api/usuarios                | Lista todos os usuários       |
| GET    | /api/usuarios/{id}           | Busca um usuário por ID       |
| GET    | /api/usuarios/email/{email}  | Busca um usuário por e-mail   |
| POST   | /api/usuarios                | Cria um novo usuário          |
| PUT    | /api/usuarios/{id}           | Atualiza os dados do usuário  |
| DELETE | /api/usuarios/{id}           | Remove um usuário             |

---

## 📦 Estrutura do Projeto

- Controllers
- Models
- Services
- Configurations

---

## 📄 Exemplo de Usuário (JSON)

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
3. Configure a string de conexão com o MongoDB no arquivo appsettings.json (caso necessário)
4. Execute o projeto
5. Acesse o Swagger em:
   ```bash
   https://localhost:<porta>/swagger

## Testes
Os endpoints foram testados utilizando o Swagger, permitindo a validação de todas as operações de CRUD de forma prática e interativa.

## Aprendizado
Durante o desenvolvimento deste projeto, foram aplicados conceitos como:

- Criação de APIs REST com ASP.NET Core
- Integração com banco de dados NoSQL (MongoDB)
- Estruturação utilizando padrão MVC (Controllers)
- Implementação de operações CRUD
- Organização e boas práticas no backend

## Observações
As senhas são utilizadas apenas para fins de estudo e não possuem criptografia nesta aplicação.

