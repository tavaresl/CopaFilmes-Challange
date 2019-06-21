# Desafio Copa Filmes

Este repositório contém o código fonte dos projetos referentes ao desafio Copa Filmes.

- O client foi desenvolvido usando a biblioteca `React.js@16.8`
- O server foi desenvolvido usando o framweork `ASP.NET Core@2.2`

## Client

O código font do client (front-end) está contido na pasta `Client`.

### Build

Para buildar o client da aplicação, basta rodar o comando

```shell
cd Client
npm run build
```

no Terminal/PowerShell.

### Rodando a aplicação

Para rodar a aplicação, é necessário ter o pacote `serve` instalado globalmente. Para instalá-lo, rode o comando

```shell
npm install -g serve
```

no Terminal/PowerShell. Após isso, basta rodar o comando

```shell
serve -s build
```

para rodar a aplicação num servidor local, acessível a partir da porta `5000`.

### Rodando sem build

Para rodar a aplicação sem passar pelo build, basta rodar o comando

```shell
npm start
```

no Terminal/PowerShell, e a aplicação será iniciada num servidor local de desenvolvimento, acessível a partir da porta `3000`.

## Server

O código font do server (back-end) está contido na pasta `Server`.

### Build

Para buildar o client da aplicação, basta rodar o comando

```shell
cd Server
dotnet build -o ./bin Server.sln
```

no Terminal/PowerShell.

### Rodando a aplicação

Para rodar a aplicação, basta rodar o comando

```shell
dotnet bin/API.dll
```

e ela será iniciada num servidor local, acessível a partir da porta `5001` via `https`.

### Rodando a aplicação sem buildar

Para rodar a aplicação sem passar pelo build do pacote de produçao, basta rodar o comando

```shell
dotnet run --project API/API.csproj
```

no Terminal/PowerShell, e a aplicação será iniciada num servidor local de desenvolvimento, acessível a partir da porta `8081` via https.
