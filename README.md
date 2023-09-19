<h1>PInd_Back02</h1>
<p>Este repositório é referente ao segundo dia do plantão individual sobre BackEnd. Serão abordadas as UCs 13, 14, 15</p>

O que precisamos ter para conseguir fazer a atividade?
1) Visual Studio
2) SSM
3) SQL Server

   E como conseguimos? Precisamos instalar!!!!!!
------------------------------------------------------------------
Instalação do Visual Studio:
https://visualstudio.microsoft.com/pt-br/downloads
-----------------------------------------------------------------
Instalação do SSM:
https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
-----------------------------------------------------------------
Instalação do SQL Server:
https://www.microsoft.com/pt-br/sql-server/sql-server-downloads
-----------------------------------------------------------------

Ambiente ok? Perfeito!

Então primeiro precisaremos acessar o SSM. E dentro dele, abrir uma nova consulta para adicionar esses scripts, para criar e manipular o banco de dados:
```
CREATE DATABASE Chapter
USE Chapter

CREATE TABLE Livros (
    Id INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(150) NOT NULL,
    QuantidadePaginas INT,
    Disponivel BIT
)

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) 
VALUES ('Titulo A', 120, 1)

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) 
VALUES ('Titulo B', 220, 0)

SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros
```

Em seguida, abra o VISUAL STUDIO e crie um projeto (API web do ASP.NET core - C#)

Dentro do projeto já criado, você precisará excluir os seguintes arquivos e pastas:
1-    WeatherForecast.cs
2-    WeatherForecastController.cs(Dentro da pasta controller)

Em seguida, no projeto dentro do Visual Studio Code, é preciso criar as seguintes pastas:
- criar a pasta Models
- criar a pasta Repositories
- criar a pasta Contexts

  Dentro de Models, você irá criar uma classe chamada "Livro.cs" e em seguida, irá adicionar dentro da classes os atributos.

```
namespace ChapterFST1.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public int QuantidadePaginas { get; set; }

        public bool Disponivel { get; set; }
    }
}
```

Em seguida, 
Vamos adicionar pacote do nuget do sql server. Para isso, voccê irá clicar no botão
Clicar com o botão direito em cima do nome do projeto, e e seguida selecione o "Gerenciar Pacotes do NuGet"

Em seguida, procure por: 
<img src="https://i.stack.imgur.com/XEYvs.png">

