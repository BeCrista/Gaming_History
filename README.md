## 🇵🇹 : Console History

Console History é um projeto web desenvolvido em ASP.NET Core que apresenta uma linha do tempo interativa sobre a evolução das consolas de videogame das principais plataformas: PlayStation, Nintendo e Xbox. Este projeto tem como objetivo fornecer uma visão geral das consolas, suas funcionalidades e como eles impactaram o mundo dos games ao longo dos anos.

![Tela Inicial](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/Home.png)

![Jogo em destaque](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/Em%20Destaque.png)

---

## Principais funcionalidades:

- Plataformas e Consolas: O projeto exibe informações detalhadas sobre plataformas como PlayStation, Nintendo e Xbox, além de listar suas consolas, incluindo imagens, descrições e dados históricos.

![Nintendo](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/Nintendo.png)

- Evolução dos Consolas: Por meio de uma apresentação em estilo carrossel, os utilizadores podem explorar as consolas lançados para cada plataforma ao longo do tempo, visualizando informações sobre cada modelo.

![SNES](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/SNES.png)

- The Game Awards 2024: A página também conta com uma seção dedicada ao The Game Awards, incluindo informações sobre o evento, seus fundadores e o impacto que ele teve na indústria de games, além dos jogos indicados ao prêmio de Jogo do Ano de 2024.

![TGA](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/The%20Game%20Awards.png)

---

## Tecnologias usadas:

- ASP.NET Core para construir o backend e organizar as visualizações.

- Padrão MVC usando controladores e visualizações para renderizar dados dinamicamente.

- Bootstrap para estilizar e criar componentes responsivos, como o carrossel.

---

## Como executar o projeto:

- Clone o repositório:
```bash
git clone https://github.com/your-user/Console-History.git
```

- Abra o projeto no Visual Studio ou outro editor compatível com ASP.NET Core.

- Execute o projeto. O servidor será iniciado e você poderá visualizar o aplicativo no navegador.

---

## Como Configurar o Projeto

Siga as instruções abaixo para configurar o projeto e restaurar a base de dados.

---

### Pré-requisitos
1. Instale o [.NET SDK](https://dotnet.microsoft.com/download) (versão 6 ou superior).
2. Instale o [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads) ou outra instância do SQL Server.
3. Instale o [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms) para gerenciar o banco de dados (opcional, mas recomendado).

---

### Passos para Restaurar o Banco de Dados

1. **Localize os Arquivos do Banco de Dados:**
   - Navegue até a pasta `Database` dentro do projeto.
   - Os arquivos do banco de dados são:
     - `Gaming_History.mdf` (dados)
     - `Gaming_History_log.ldf` (log)

2. **Restaurar o Banco de Dados:**
   - Abra o **SQL Server Management Studio (SSMS)**.
   - Conecte-se à sua instância do SQL Server.
   - Clique com o botão direito em **Databases** (banco de dados) e selecione **Attach** (Anexar).
   - No painel que aparece:
     - Clique em **Add**.
     - Navegue até o local onde você clonou este repositório e selecione o arquivo `Gaming_History.mdf`.
     - Clique em **OK**.

3. **Verifique o Banco de Dados:**
   - Após anexar o banco, ele aparecerá na lista de bancos de dados no SSMS com o nome `Gaming_History`.
   - Use a opção **New Query** para executar consultas, se necessário.

---

### Configuração do Projeto

1. Abra o terminal e navegue até o diretório do projeto:
   ```bash
   cd Gaming_History
2. Atualize o arquivo appsettings.json (se necessário):
   - Certifique-se de que a string de conexão está configurada corretamente para o SQL Server local. O formato será algo assim:
  ```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Gaming_History;Trusted_Connection=True;TrustServerCertificate=True"
}
```
3. Execute o projeto:
```bash
  dotnet watch run
```

---

## Objetivo do projeto:

Este projeto foi desenvolvido como parte de uma iniciativa para aprender sobre ASP.NET Core, MVC e como trabalhar com dados dinâmicos em um aplicativo da web. Ele também serve como um portfólio para demonstrar habilidades em design responsivo e integração de informações de diferentes fontes.

---
 
##  🇺🇸 : Console History

Console History is a web project developed in ASP.NET Core that presents an interactive timeline about the evolution of video game consoles from the main platforms: PlayStation, Nintendo and Xbox. This project aims to provide an overview of the consoles, their features and how they have impacted the gaming world over the years.

![Home Screen](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/Home.png)

![Featured Game](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/Em%20Destaque.png)

---

## Main features:

- Platforms and Consoles: The project displays detailed information about platforms such as PlayStation, Nintendo and Xbox, in addition to listing their consoles, including images, descriptions and historical data.

![Nintendo](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/Nintendo.png)

- Evolution of Consoles: Through a carousel-style presentation, users can explore the consoles released for each platform over time, viewing information about each model.

![SNES](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/SNES.png)

- The Game Awards 2024: The page also has a section dedicated to The Game Awards, including information about the event, its founders and the impact it has had on the gaming industry, as well as the games nominated for the 2024 Game of the Year award.

![TGA](https://github.com/BeCrista/Gaming_History/blob/99079928451be199368c008ff61eb7aaddadef4e/Images/The%20Game%20Awards.png)

---

## Technologies used:

- ASP.NET Core for building the backend and organizing the views.

- MVC Pattern using Controllers and Views to render data dynamically.

- Bootstrap for styling and creating responsive components, such as the carousel.

---

## How to run the project:

- Clone the repository:
```bash
git clone https://github.com/your-user/Console-History.git
```

- Open the project in Visual Studio or another editor compatible with ASP.NET Core.

- Run the project. The server will start and you will be able to view the application in the browser.

---

## How to Set Up the Project

Follow the instructions below to set up the project and restore the database.

---

### Prerequisites
1. Install the [.NET SDK](https://dotnet.microsoft.com/download) (version 6 or higher).
2. Install [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads) or another instance of SQL Server.
3. Install [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms) to manage the database (optional, but recommended).

---

### Steps to Restore the Database

1. **Locate the Database Files:**
- Navigate to the `Database` folder within the project.
- The database files are:
- `Gaming_History.mdf` (data)
- `Gaming_History_log.ldf` (log)

2. **Restore the Database:**
- Open **SQL Server Management Studio (SSMS)**.
- Connect to your SQL Server instance.
- Right-click **Databases** and select **Attach**.
- In the panel that appears:
- Click **Add**.
- Browse to the location where you cloned this repository and select the `Gaming_History.mdf` file.
- Click **OK**.

3. **Verify the Database:**
- After attaching the database, it will appear in the list of databases in SSMS with the name `Gaming_History`.
- Use the **New Query** option to run queries, if necessary.

---

### Project Setup

1. Open a terminal and navigate to the project directory:
```bash
cd Gaming_History
```
2. Update the appsettings.json file (if necessary):
- Make sure the connection string is set correctly for your local SQL Server. The format will be something like this:
```bash
"ConnectionStrings": {
"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Gaming_History;Trusted_Connection=True;TrustServerCertificate=True"
}
```
3. Run the project:
```bash
dotnet watch run
```

## Project Goal:

This project was developed as part of an initiative to learn about ASP.NET Core, MVC, and how to work with dynamic data in a web application. It also serves as a portfolio to demonstrate skills in responsive design and integrating information from different sources.
