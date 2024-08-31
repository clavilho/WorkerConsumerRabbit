# WorkerConsumerRabbitMQ

## Descrição

O `WorkerConsumerRabbitMQ` é uma aplicação console .NET que consome mensagens de uma fila RabbitMQ de forma síncrona. Este projeto demonstra como conectar-se a um servidor RabbitMQ, declarar uma fila e consumir mensagens uma por vez.

## Requisitos

- [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) ou superior
- [RabbitMQ](https://www.rabbitmq.com/download.html) instalado e em execução
- Biblioteca `RabbitMQ.Client`

## Instalação

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/seuusuario/WorkerConsumerRabbitMQ.git
   cd WorkerConsumerRabbitMQ

2. **Instale as dependências:**

 No diretório do projeto, execute o comando:
   ```bash
   dotnet restore

3. **Configuração das Variáveis de Ambiente:**

Defina a variável de ambiente connectionStringRabbit com a URL de conexão do RabbitMQ. Exemplo:

```bash
   export connectionStringRabbit=amqp://guest:guest@localhost:5672/

Para sistemas Windows, você pode definir a variável de ambiente no PowerShell:

```bash
$env:connectionStringRabbit="amqp://guest:guest@localhost:5672/"


## Uso

1. **Execute a aplicação:**

```bash
dotnet run

A aplicação se conectará ao RabbitMQ, declarará uma fila chamada queue1, e começará a consumir mensagens dessa fila. As mensagens recebidas serão exibidas no console.


2. **Verifique a saída:**

As mensagens consumidas serão exibidas no console, uma por vez.


## Contribuições

Se você deseja contribuir para o projeto, por favor, faça um fork do repositório e envie um pull request com suas melhorias ou correções.