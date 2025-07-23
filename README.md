# Oracle .NET CRUD API with Stored Procedures

API REST desenvolvida em **.NET 8** para operações CRUD utilizando **Stored Procedures Oracle**.  
Este projeto é ideal para ser consumido por qualquer frontend SPA, como **Blazor**, **React** ou **Angular**.

---

## 📌 Objetivo

Demonstrar como construir uma API desacoplada que utiliza:

- .NET 8 Web API
- Banco de dados Oracle XE 21c
- Stored Procedures para todas as operações de CRUD
- Acesso via `Oracle.ManagedDataAccess.Core`

---

## ⚙️ Tecnologias Utilizadas

| Camada         | Tecnologia                                 |
| -------------- | ------------------------------------------ |
| Backend        | .NET 8 (ASP.NET Core Web API)              |
| Banco de Dados | Oracle XE Database 21c + Stored Procedures |
| Acesso a Dados | Oracle.ManagedDataAccess.Core              |

---

## 📁 Estrutura do Projeto

```text
src/
 └── OracleCrud.Api/
      ├── Application/       # Casos de uso, DTOs, regras de negócio
      ├── Controllers/       # Web API controllers (pontos de entrada HTTP)
      ├── Domain/            # Entidades e interfaces
      ├── Infrastructure/    # Implementações (Oracle, repositórios, etc)
      ├── appsettings.json   # Configurações da aplicação
      └── Program.cs         # Ponto de entrada principal
```
