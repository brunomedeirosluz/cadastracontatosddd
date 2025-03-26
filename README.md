# Controle de Contatos

Este projeto é uma aplicação simples desenvolvida utilizando **.NET Framework 4.6.2** com o objetivo de estudar e aplicar conceitos de **Domain Driven Design (DDD)**. A aplicação permite realizar um CRUD básico de contatos, permitindo cadastrar, editar, deletar e listar contatos.

## Tecnologias Utilizadas

- **.NET Framework 4.6.2**: A plataforma de desenvolvimento utilizada.
- **AutoMapper 3.2.1**: Biblioteca para mapeamento de objetos entre diferentes camadas da aplicação.
- **Entity Framework 6.5.1**: ORM utilizado para interagir com o banco de dados.
- **Ninject 3.2.0.0**: Framework de Injeção de Dependência (IoC).
- **Bootstrap**: Framework front-end utilizado para estilizar as páginas da aplicação.

## Estrutura do Projeto

### 1. **Camada de Apresentação (MVC)**

A camada de apresentação é implementada com **ASP.NET MVC** e é responsável pela interface com o usuário. Ela contém as páginas de cadastro, edição e listagem de contatos. Utiliza-se o **Bootstrap** para fornecer um design responsivo e agradável.

### 2. **Camada de Aplicação**

A camada de aplicação faz a mediação entre a camada de apresentação e a camada de domínio. Ela contém a lógica de negócios que orquestra a comunicação entre as camadas de domínio e a apresentação, permitindo a realização das operações de CRUD nos contatos.

### 3. **Camada de Domínio**

A camada de domínio contém as entidades e as regras de negócios da aplicação. A classe `Contato` é a entidade principal, representando as informações de um contato que será armazenado no banco de dados.

```csharp
namespace ControleDeContatos.Domain.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
```


### 4. Camada de Infraestrutura

A camada de infraestrutura é responsável pela comunicação com o banco de dados. Ela utiliza o **Entity Framework** para realizar operações como salvar, editar, excluir e listar contatos no **SQL Server**.

## Funcionalidades

O sistema oferece um CRUD simples para gerenciar contatos. As funcionalidades incluem:

- **Cadastrar Contato**: Adicionar um novo contato através de um formulário.
- **Editar Contato**: Alterar os dados de um contato existente.
- **Deletar Contato**: Excluir um contato do sistema.
- **Listar Contatos**: Exibir todos os contatos cadastrados em uma lista na página principal (Index).

## Como Executar o Projeto

### Pré-requisitos

Certifique-se de ter o **Visual Studio** instalado e a versão **.NET Framework 4.6.2** configurada corretamente.

### Passos

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/controle-de-contatos.git


2. **Abra o projeto no Visual Studio**.

3. **Restaurar pacotes NuGet**:  
   O Visual Studio irá restaurar automaticamente os pacotes NuGet quando você abrir o projeto. Caso contrário, execute o comando abaixo no **Package Manager Console**:
   ```bash
   nuget restore

4. **Compile e execute o projeto**.

4. A aplicação estará disponível em **localhost**, e você poderá acessar a página inicial para cadastrar, editar, deletar e listar contatos
