#🛍️ Web API Produtos

API RESTful desenvolvida em **ASP.NET Core** para gerenciamento de produtos, com foco na prática de **CRUD**, rotas REST, integração com banco de dados e uso do **Entity Framework Core**.

---

##🚀 Tecnologias Utilizadas

- ASP.NET Core Web API  
- Entity Framework Core  
- SQL Server  
- C#  
- Arquivo `.http` para testes de requisições  

---

##📌 Sobre o Projeto

A **Web API Produtos** permite realizar operações completas de gerenciamento de produtos, incluindo:

- Cadastro de produtos  
- Listagem de todos os produtos  
- Busca de produto por ID  
- Edição de produtos  
- Remoção de produtos  

A API segue o padrão **REST**, utilizando corretamente os verbos HTTP e rotas baseadas em recursos.

---

##🗂️ Estrutura do Projeto

```
Web-API-Produtos/
│
├── Controllers/
│   └── ProdutoController.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Migrations/
│   └── (arquivos de migrations do EF Core)
│
├── Models/
│   └── ProdutoModel.cs
│
├── Properties/
│   └── launchSettings.json
│
├── Program.cs
├── Web-API-Produtos.csproj
├── Web-API-Produtos.csproj.user
├── Web-API-Produtos.http
├── appsettings.json
└── appsettings.Development.json
```

---

##📦 Modelo de Dados - Produto

A entidade `ProdutoModel` representa um produto no sistema.

-`Id` (int)
-`Nome` (string)
-`Descricao` (string)
-`QuantidadeEstoque` (int)
-`CodigoDeBarras` (string)
-`Marca` (string)

---

##🔗 Endpoints da API

Base URL (local):
```
https://localhost:{porta}/api/produto
```

###📋 Listar todos os produtos
```
GET /api/produto
```

---

###🔍 Buscar produto por ID
```
GET /api/produto/{id}
```

---

###➕ Cadastrar produto
```
POST /api/produto
```

Exemplo de body (JSON):
```json
{
  "nome": "Ração Premium",
  "descricao": "Ração para cães adultos",
  "quantidadeEstoque": 50,
  "codigoDeBarras": "7891234567890",
  "marca": "DogPlus"
}
```

---

###✏️ Editar produto
```
PUT /api/produto/{id}
```

Exemplo de body (JSON):
```json
{
  "nome": "Ração Premium Plus",
  "descricao": "Ração para cães adultos - nova fórmula",
  "quantidadeEstoque": 40,
  "codigoDeBarras": "7891234567890",
  "marca": "DogPlus"
}
```

---

##🗑️ Deletar produto
```
DELETE /api/produto/{id}
```

---

##🛠️ Como Executar o Projeto

1. Clone o repositório:
```bash
git clone https://github.com/LeandroMCarv/web-api-produtos.git
```

2. Abra o projeto no Visual Studio ou no terminal.

3. Configure a string de conexão no `appsettings.json`.

4. Execute as migrations:
```bash
dotnet ef database update
```

5. Inicie a aplicação:
```bash
dotnet run
```

6. Teste os endpoints utilizando o arquivo:
```
Web-API-Produtos.http
```

---

##📄 Licença

Projeto desenvolvido para **fins educacionais**.

---

##👨‍💻 Autor

[@LeandroMCarv](https://github.com/LeandroMCarv)
