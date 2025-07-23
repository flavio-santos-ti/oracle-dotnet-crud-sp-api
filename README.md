# Oracle .NET CRUD API with Stored Procedures

![.NET 8](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)
![Oracle DB](https://img.shields.io/badge/Oracle-XE_21c-F80000?logo=oracle)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)

**API REST** desenvolvida em **.NET 8** para operações CRUD utilizando **Stored Procedures Oracle**.  
Este projeto é ideal para ser consumido por qualquer frontend SPA, como **Blazor**, **React** ou **Angular**.

---

## 📌 Objetivo

Demonstrar como construir uma API desacoplada que utiliza:

- .NET 8 Web API (**API REST**)
- Banco de dados **Oracle XE 21c**
- Stored Procedures para todas as operações de CRUD
- Acesso via `Oracle.ManagedDataAccess.Core`
- Estrutura modular e reaproveitável, adequada para ambientes com frontends independentes (SPA)

---

## ⚙️ Tecnologias Utilizadas

| Camada         | Tecnologia                                     |
| -------------- | ---------------------------------------------- |
| Backend        | **.NET 8** (ASP.NET Core Web API)              |
| Banco de Dados | **Oracle XE Database 21c** + Stored Procedures |
| Acesso a Dados | Oracle.ManagedDataAccess.Core                  |

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
