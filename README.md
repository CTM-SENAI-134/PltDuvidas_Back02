<h1>Olá, Dev!</h1>
<p>Este repositório é referente ao segundo dia do plantão individual sobre BackEnd. Serão abordadas as UCs 13(Banco de daodos), 14(Desenvolvimento de API), 15(Teste de BackEnd)</p>

<h1>BANCO DE DADOS</h1> 

Para fazer essa preparação precisamos ter instalado em nossa máquina:
- SQL Server - Sistema de gerenciamento de banco de dados
- SSMS(**SQL Server Management Studio**) Ferramenta usada para administrar e interagir com o SQL Server

 <h2>Instalação do SQL Server</h2>
a) Procure no navegador por: **SQL Server Download**

b) Clique no seguinte link: 
<br>
[Downloads do SQL Server | Microsoft](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

c) Rolando um pouco a tela para baixo, você vai clicar em “Baixe agora” na opção Developer
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/fd845ad8-fc64-40f6-9b48-a35cae11fcbb)

b) Abra o arquivo e permita que ele altere seu dispositivo.

c) Abrirá essa interface, e selecione o **Personalizado**, para conseguirmos selecionar o que desejamos dentro do SQL:
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/96be1835-4072-4fc1-a590-494177d605b8)

d) Clique em Instalar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/378ea71b-fd99-4077-b081-61861648a851)

e) Aguarde a instalação
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/d05ee115-4590-4ca2-b3b2-c2fc0d469045)

f) No menu lateral, selecione Instalação
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a85170ba-5338-42ae-8e9c-5d67f210c240)

g) Dentro de Instalação, selecione o link de Nova instalação autônoma do SQL Server ou adicionar recursos a uma instalação existente.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/798fbb46-e0f5-4e92-baed-9258b4f1d87c)

h) Aguarde.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/a57b69b8-dad9-4b3c-ae18-7b9d7f4f8020)

i) Em seguida, em “Especifique uma edição gratuita” deixe a opção **Developer** e clique em **Avançar**.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/eb17e1fb-3ddf-497e-8fe1-55356d55e68e)

j) Nessa parte de Termos de Licença, aceite os termos e condições e clique em Avançar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/984d9607-ab74-40c4-a6c0-c7c63faec789)

k) Clique em Avançar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/090014e9-387e-4ab1-9aaf-1216e812bfe7)

l) Clique em Avançar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/6f8074f2-e893-43f5-8113-b6549ae63f30)

m) Não selecione a opção Extensão do Azure para SQL Se. E clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/baa2b842-f443-44f6-a33f-a0c46e85e280)

n) Selecione as opções das imagens e clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/115a9449-737a-4ef9-a7cd-38d6f3a08f81)

o) Clique em Instância nomeada e coloque “SQLExpress” e em ID da instância, “SQLEXPRESS”. Por fim, clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/605108c6-0036-42f1-974a-c2f71a0f4423)

p) Selecione o check de “Conceder o privilégio Realizar a Tarefa de Manutenção de Volume…”. E clique em Avançar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9a90a18f-9f08-4f0f-900c-f5abe7db5d30)

q) Selecione o Modo Misto e coloque em Digitar Senha a senha “1234” e em Confirmar Senha, a mesma senha “1234”.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/daf96156-a75e-4bd7-b784-ca31482a526a)

r) Em seguida, clique em Adicionar Usuário Atual e ao finalizar, clique em Avançar. 
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/6ef83c57-4de4-4a3e-ba02-3399cf6872cb)

s) Clique em Instalar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/88229cdf-bd86-4200-a049-64291a685f6f)

t) Assim que tudo estiver com Status Exito, clique em Fechar.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/3ad192e3-5ea3-4e26-926e-72a76b2184b9)

 <h2>Instalação do SSMS</h2>
 a) Procure no navegador por: *SSMS Download*

b) Clique no seguinte link:
<br>
[SQL Server Management Studio (SSMS) - SQL Server Management Studio (SSMS)](https://learn.microsoft.com/pt-br/sql/ssms/sql-server-management-studio-ssms?view=sql-server-ver16)

c) Rolando um pouco a tela para baixo, você vai clicar em ***Baixar o SQL Server Management Studio (SSMS)***
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/686ec8a6-7423-4ef6-8e62-9f34f258efdd)

d) Ele irá te direcionar a outra tela, então clique em Download gratuito do SSMS(SQL Server Managment Studio)
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/2884d036-69c9-464e-89ba-56b6bbbfa75b)

e) Assim que baixar, clique no arquivo e permita que faça alterações em seu dispositivo. Assim que aceitar, aparecerá uma aba de bem-vindo. Clique em Instalar. 
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/96e227c9-1ab0-438f-aee7-a3fd96907008)

f) Aguarde a instalação.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/b228053b-9e3a-4972-9450-6477b7ad1a75)

g) Por fim, clique em fechar
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/669120e5-236a-41b5-9cbf-1f4ce24a9e83)

O ambiente está OK, então vamos ver como é a interface do SSMS. 
Clique na barra de pesquisa do Windowns e pesquise por SSMS, selecione o SQL Server Management Studio Management Studo 19.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/f0fc35fe-616f-4dbe-93df-bcf8e8a16fd8)

Toda vez que abrir o SSMS aparecerá de primeiro momento o ambiente de conexão com o servidor. Aqui você pode deixar da seguinte forma e em seguida, clicar em “Conectar”.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/7e0621f2-ae72-42ef-a900-5969ef40f4d1)

Quando abrir, terá uma a chamada Pesquisador de Objetos e dentro dele, estará os bancos de dados, informações de segurança e gerenciamento etc. O que será muito importante para nós é pasta Banco de dados, pois será nele que veremos nossos bancos com suas tabelas.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9c5975f2-a527-47af-bcf9-fccfe64f6025)

Para iniciar o uso, Clique em Nova Consulta na aba de ferramentas.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/0b202463-641c-4f8f-9fc8-d7e66dbac6e8)

Ao clicar em Nova Consulta, Irá abrir uma consulta, na qual conseguiremos escrever nossos comandos.
<br>
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/d4a712ec-5c64-432f-87ce-385220bc2f62)

Primeiro precisamos entender que faremos hoje. Vamos criar um banco de dados de uma biblioteca. E o que temos em bibliotecas? LIVROS! 

Então, para criar nosso banco de dados devemos escrever dentro da consulta o comando:
```
CREATE DATABASE Chapter;
```
E em seguida, clique em Executar:
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/e10b714a-3634-458a-9bed-fa7c61564ca5)


Assim que clicar em executar, verifique que na aba de mensagens temos um retorno de “Comandos concluídos com êxito.” Isso significa que nosso banco foi criado.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/33db05fd-6397-4294-89d8-864e10fe676d)

Mas para verificar qualquer mudança e melhor, para qualquer mudança feita, sendo criação de banco ou até mesmo de tabelas é importante dar o comando F5, ou vá na aba de pesquisador de objetos e clique no ícone de atualizar. Isso é importante, pois às vezes demora para atualizar sozinho.
![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/320af3cb-f9d1-4188-8783-145d60658124)


Então vamos seguir. É importante que a partir de agora, sempre que for escrever algum comando, seja ele um SELECT, DELETE, INSERT, ou outros, informe qual banco estará fazendo esses comandos. Então, escreva o comando, para especificar que está utilizando o banco de dados Chapter: 

```
USE Chapter;
```
Já que nosso banco já está criado, vamos para a criação das tabelas, ok? Para isso iremos usar esse comando, e em seguida clicar em Executar ou dar F5, para rodar o comando:
```
CREATE TABLE Livros (
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
);
```

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/9d3abf74-070a-4447-8b1a-882beb1ccbd0)

Agora, para inserir registros dentro das colunas da tabela Livros, será necessário usar este comando, e em seguida clicar em Executar ou dar F5, para rodar o comando:
```
INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) VALUES ('Titulo A', 120, 1);

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel) VALUES ('Titulo B', 220, 0);
```

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/1442961c-8d05-45e7-addf-0f58f8b3f287)


E para alterar qualquer informação de registro, dentro da tabela Livros será necessário usar este comando. E em seguida clicar em Executar ou dar F5, para rodar o comando
```
UPDATE Livros SET Titulo = 'Titulo A1' Where Id = 1;
```

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/1080ca06-6941-4c6a-ad50-67685c2a1c1d)

E para consultar a nossa tabela e seus campos podemos dar este comando. E em seguida clicar em Executar ou dar F5, para rodar o comando

SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros;
ou
SELECT * FROM Livros;

![image](https://github.com/CTM-SENAI-134/PltDuvidas_Back02/assets/144062335/b4778563-ea5a-47d2-a9ac-f71394741aec)

Finalizando, aqui o importante é você compreender que no banco de dados podemos manipular, organizar os dados do nosso sistema. E usando a linguagem SQL conseguimos dar os SELECT, INSERT, UPDATE e CREATE. A atividade de hoje é para que vocês consigam criar o banco, suas tabelas e preencher com registros. 



<h1>DESENVOLVIMENTO DE API</h1> 
- [ ] Instalação do Visual Studio:
> https://visualstudio.microsoft.com/pt-br/downloads

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

