<h1>Olá, Dev!</h1>
<p>Este repositório é referente ao segundo dia do plantão individual sobre BackEnd. Serão abordadas as UCs 13(Banco de daodos), 14(Desenvolvimento de API), 15(Teste de BackEnd)</p>

<h1>BANCO DE DADOS</h1> 

Para fazer essa preparação precisamos ter instalado em nossa máquina:
- SQL Server - Sistema de gerenciamento de banco de dados
- SSMS(**SQL Server Management Studio**) Ferramenta usada para administrar e interagir com o SQL Server

 <h2>Instalação do SQL Server</h2>
a) Procure no navegador por: *SQL Server Download*

b) Clique no seguinte link:

[Downloads do SQL Server | Microsoft](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

c) Rolando um pouco a tela para baixo, você vai clicar em “Baixe agora” na opção Developer
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/fd845ad8-fc64-40f6-9b48-a35cae11fcbb)
b) Abra o arquivo e permita que ele altere seu dispositivo.

c) Abrirá essa interface, e selecione o **Personalizado**, para conseguirmos selecionar o que desejamos dentro do SQL:
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/96be1835-4072-4fc1-a590-494177d605b8)

d) Clique em Instalar.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/378ea71b-fd99-4077-b081-61861648a851)

e) Aguarde a instalação
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/d05ee115-4590-4ca2-b3b2-c2fc0d469045)
f) No menu lateral, selecione Instalação
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a85170ba-5338-42ae-8e9c-5d67f210c240)
g) Dentro de Instalação, selecione o link de Nova instalação autônoma do SQL Server ou adicionar recursos a uma instalação existente.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/798fbb46-e0f5-4e92-baed-9258b4f1d87c)





E como conseguimos? Precisamos instalar!!!!!!
- [ ] Instalação do Visual Studio:
> https://visualstudio.microsoft.com/pt-br/downloads

- [ ] Instalação do SSM:
> https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

- [ ] Instalação do SQL Server:
> https://www.microsoft.com/pt-br/sql-server/sql-server-downloads

 ---


Ambiente ok? Perfeito!

Então primeiro precisaremos acessar o SSM. E dentro dele, abrir uma nova consulta para adicionar esses scripts, para criar e manipular o banco de dados:
```
CREATE DATABASE Chapter

USE Chapter

CREATE TABLE Livros (
	id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
)

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel)
VALUES ('Titulo 1', 220, 1)

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel)
VALUES ('Biblia', 500, 1)

SELECT * FROM Livros

UPDATE Livros SET Titulo = 'Senhor dos Aneis' WHERE id = 1;

DELETE FROM Livros WHERE id = 3;
```

Em seguida, abra o VISUAL STUDIO e crie um projeto (API web do ASP.NET core - C#)

Dentro do projeto já criado, você precisará excluir os seguintes arquivos e pastas:
1-    WeatherForecast.cs
2-    WeatherForecastController.cs(Dentro da pasta controller)

Em seguida, no projeto dentro do Visual Studio Code, é preciso criar as seguintes pastas:
- criar a pasta Models
- criar a pasta Repositories
- criar a pasta Contexts

## Model
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

Em seguida, procure por e clique em "Instalar": 
<img src="https://i.stack.imgur.com/XEYvs.png">

## Context
Agora, na  pasta "Contexts" criaremos uma classe chamada ChapterContext.cs
```
using ChapterFST1.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterFST1.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = CYBERNOTE-03-1\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true; TrustServerCertificate=True");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

    }
}

```

## Repository

Dentro da pasta  "Repositories", crie uma classe chamada "LivroRepository.cs"

```
using ChapterFST1.Contexts;
using ChapterFST1.Models;

namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

    }
}

```
## Controller

Dentro da pasta  "Controller", crie um CONTROLADOR chamado "LivoController.cs"

```
using ChapterFST1.Models;
using ChapterFST1.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFST1.Controllers
{
    [Produces("application/json")]
    
    [Route("api/[controller]")]

    [ApiController]

    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}

```

## Program

Dentro do arquivo program.cs

```
builder.Services.AddScoped<ChapterContext, ChapterContext>();

builder.Services.AddTransient<LivroRepository, LivroRepository>();

```

E agora, vamos testar????

Vamos precisar rodar a API clicando no playzinho verde lá no menu do Visual Studio. Ele vai abrir o Swagger... Ele é parecido com o postman, vai fazer requisições utilizando o protocolo http e você consegue testar a api através dele, além disso, ele também serve como documentação
-clicar em try it out
-clicar em execute

