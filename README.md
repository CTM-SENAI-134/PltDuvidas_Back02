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
------------------------------------------------------------------
Instalação do SSM:
<a>https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16</a>
-----------------------------------------------------------------
------------------------------------------------------------------
Instalação do SQL Server:
<a>https://www.microsoft.com/pt-br/sql-server/sql-server-downloads</a>
-----------------------------------------------------------------

Ambiente ok? Perfeito!

Então primeiro precisaremos acessar o SSM. E dentro dele, abrir uma nova consulta para adicionar esses scripts:
```
CREATE DATABASE Chapter
GO

USE Chapter
GO

CREATE TABLE Livros (
    Id INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(150) NOT NULL,
    QuantidadePaginas INT,
    Disponivel BIT
)
GO

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) 
VALUES ('Titulo A', 120, 1)
GO

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) 
VALUES ('Titulo B', 220, 0)
GO

SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY, 
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL,
    Tipo CHAR(1) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@sp.br', '1234', '0') 
GO

SELECT * FROM Usuarios WHERE email = 'email@sp.br' AND senha = '1234'
GO
```
