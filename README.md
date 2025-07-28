# Oracle .NET CRUD API with Stored Procedures

![.NET 8](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)
![Oracle DB](https://img.shields.io/badge/Oracle-XE_21c-F80000?logo=oracle)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
[![NuGet](https://img.shields.io/nuget/v/Flavio.Santos.NetCore.ObjectMapping.svg?label=object%20mapping)](https://www.nuget.org/packages/Flavio.Santos.NetCore.ObjectMapping/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Flavio.Santos.NetCore.ObjectMapping.svg?color=blue)](https://www.nuget.org/packages/Flavio.Santos.NetCore.ObjectMapping/)

**API REST** desenvolvida em **.NET 8** para operações CRUD utilizando **Stored Procedures Oracle**.  
Este projeto é ideal para ser consumido por qualquer frontend SPA, como **Blazor**, **React** ou **Angular**.

---

## 📌 Objetivo

Demonstrar como construir uma API desacoplada que utiliza:

- .NET 8 Web API (**API REST**)
- Banco de dados **Oracle XE 21c**
- Stored Procedures para todas as operações de CRUD
- Acesso via `Oracle.ManagedDataAccess.Core`
- Mapeamento de **DTOS** com `Flavio.Santos.NetCore.ObjectMapping`
- Estrutura modular e reaproveitável, adequada para ambientes com frontends independentes (SPA)

---

## ⚙️ Tecnologias Utilizadas

| Camada         | Tecnologia                                                                                                                        |
| -------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| Backend        | **.NET 8** (ASP.NET Core Web API)                                                                                                 |
| Banco de Dados | **Oracle XE Database 21c** + Stored Procedures                                                                                    |
| Acesso a Dados | Oracle.ManagedDataAccess.Core                                                                                                     |
| Mapeamento     | NetCore.ObjectMapping ([Flavio.Santos.NetCore.ObjectMapping](https://www.nuget.org/packages/Flavio.Santos.NetCore.ObjectMapping)) |

---

## 📁 Estrutura do Projeto

```text
src/
 └── OracleCrud.Sp.Api/
      ├── Application/         # Interfaces e serviços da aplicação
      │   ├── Interfaces/
      │   └── Services/
      ├── Controllers/         # Endpoints HTTP
      ├── Domain/              # Apenas DTOs (sem entidades de domínio)
      │   └── Dtos/
      ├── Infrastructure/      # Repositórios com acesso Oracle via SP
      ├── appsettings.json     # Configurações da aplicação
      └── Program.cs           # Ponto de entrada principal
```

---

## 📁 Scripts de Banco de Dados

```text
scripts/
 └── database/
      ├── sp_insert_user.sql       # Procedure para inserir usuários
      ├── sp_update_user.sql       # Procedure para atualizar usuários
      ├── sp_delete_user.sql       # Procedure para deletar usuários
      └── vw_users.sql             # View para listar usuários
```

Essa pasta contém os artefatos essenciais para configurar o schema app_user, incluindo stored procedures e views utilizadas pela aplicação.
Esses scripts devem ser executados previamente no banco Oracle para garantir o correto funcionamento da API.

---

## 💡 Abrindo o Projeto no Visual Studio 2022

Para abrir e executar corretamente o projeto no **Visual Studio 2022**, siga os passos abaixo:

1. **Clonar o repositório:**

   ```bash
   git clone https://github.com/flavio-santos-ti/oracle-dotnet-crud-sp-api.git
   ```

2. **Abrir a solução:**

   - Navegue até a pasta `src/`
   - Abra o arquivo `OracleCrud.Sp.sln` com o Visual Studio 2022

3. **Definir o projeto de inicialização:**

   - No **Solution Explorer**, clique com o botão direito sobre `OracleCrud.Sp.Api`
   - Selecione **"Set as Startup Project"**

4. **Verificar o perfil de execução:**

   - No menu superior, selecione o perfil `OracleCrud.Sp.Api` com o ambiente `Development`

5. **Executar o projeto (F5 ou Ctrl+F5):**

   - A aplicação será iniciada e o navegador abrirá automaticamente o Swagger (`https://localhost:{porta}/swagger`)

6. **Banco de dados Oracle XE:**
   - Certifique-se de que o Oracle XE 21c esteja em execução
   - Execute os scripts da pasta `scripts/database/` para criar a view e as stored procedures utilizadas pela API
