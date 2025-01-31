```markdown
# SoapMongoProject

Este é um projeto de API SOAP simples que utiliza o MongoDB como banco de dados. O objetivo é fornecer uma maneira prática de acessar e manipular dados de usuários via SOAP.

## Tecnologias Utilizadas

- **.NET 6.0+**: Framework para o desenvolvimento da API.
- **MongoDB**: Banco de dados NoSQL usado para armazenar informações dos usuários.
- **SoapCore**: Biblioteca que permite a criação de serviços SOAP no ASP.NET Core.
- **SOAP**: Protocolo de comunicação utilizado para troca de mensagens estruturadas.

## Funcionalidades

A API oferece os seguintes métodos SOAP:

- **GetUsers**: Retorna uma lista de usuários armazenados no banco de dados MongoDB.

## Requisitos

Antes de rodar o projeto, verifique se você tem as seguintes dependências instaladas:

- **.NET 6.0+** ou superior
- **MongoDB** (local ou remoto)
- **Visual Studio** ou outro editor de código que suporte .NET e C#

## Como Rodar o Projeto Localmente

### Passo 1: Clonar o Repositório

Clone o repositório para o seu computador:

```bash
git clone https://github.com/nvanitas/SoapMongoProject.git
```

### Passo 2: Configuração do MongoDB

Certifique-se de que o MongoDB está instalado e rodando. Caso você esteja usando o MongoDB localmente, a string de conexão será configurada automaticamente no arquivo `appsettings.json`. Caso contrário, ajuste a string de conexão conforme necessário.

### Passo 3: Restaurar Dependências

Abra o projeto no Visual Studio ou na sua IDE preferida. Restaure as dependências do projeto:

```bash
dotnet restore
```

### Passo 4: Rodar o Projeto

Para rodar o projeto, execute o comando:

```bash
dotnet run
```

O projeto estará rodando em `http://localhost:5000` (ou na porta configurada no seu arquivo `launchSettings.json`).

## Testando a API SOAP

Use uma ferramenta como **SoapUI** ou **Postman** para testar os métodos SOAP disponíveis na API. Para isso, importe o WSDL que pode ser acessado em:

```
http://localhost:5000/UserService.asmx?wsdl
```

## Estrutura do Projeto

A estrutura do projeto é organizada da seguinte forma:

- **Contracts**: Contém as interfaces de serviços SOAP.
- **Models**: Contém as classes de dados, como o modelo `User`.
- **Repositories**: Contém a lógica para acessar os dados do MongoDB.
- **Services**: Contém a implementação dos serviços SOAP.
- **appsettings.json**: Contém a configuração do MongoDB e outras configurações do projeto.
- **Program.cs**: Configura os serviços e o middleware da API.

## Contribuições

Sinta-se à vontade para contribuir com o projeto! Para isso, basta seguir os seguintes passos:

1. Fork o repositório.
2. Crie uma branch para suas alterações (`git checkout -b minha-branch`).
3. Faça as alterações e commite (`git commit -am 'Adicionando novas funcionalidades'`).
4. Faça o push para a branch (`git push origin minha-branch`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a MIT License - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
