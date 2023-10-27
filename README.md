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

Instalando o Visual Studio:
- Iniciando projeto no Visual Studio
Com o Visual Studio aberto, clique em **Criar um projeto**, na direita.
<br>
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/0727f4d5-7c06-4de1-88e0-2d56757bf7e0/Image.png)

Em Criar um novo projeto, terá modelos em que você pode criar o projeto. Na aba de pesquisa chamada “Pesquisar modelos(Alt+S)” procure por API web do ASP.NET core - C# selecione-o e clique no botão no canto inferior na direta, escrito próximo.
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/8c228424-541a-41ef-955e-6234bb279d02/Image.png)
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/14ea3718-5822-4ac0-82d1-d0fbcd38aaee/Image.png)

Na aba de Configurar seu novo projeto, escreva o nome do projeto e caso queira, pode colocar o local em que o arquivo estará. Assim, clique em Próximo.
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/342b1891-d82e-4944-942a-a15447a8d512/Image.png)

Em Informações adicionais, não altere nada e clique em “Criar”. Observe se a estrutura está com a versão do .NET em 6.0.
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/e2fac0f4-4c0b-4641-a4e9-cb45e9f3339c/Image.png)

Aguarde criar o projeto
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/56081be1-1b5d-414e-b63b-78afce152e30/Image.png)

E logo abrirá o projeto criado pronto para ser alterado.
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/60e2a88f-3e54-489c-8d57-60cbbebceb96/Image.png)

Com o ambiente todo preparado, agora sim, vamos começar a mexer no projeto.

Primeiro, precisamos criar três pastas:

- [ ]  Criar a pasta Models

Dentro dessa pasta haverá modelos que representam os objetos de dados que a sua aplicação manipula. Eles geralmente refletem as entidades do mundo real com as quais sua aplicação está lidando. Por exemplo, se sua aplicação lida com usuários, você pode ter um modelo de usuário que inclua atributos como nome, email e senha.

1. Clique com o botão direito no nome do projeto Chapter.
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/dc84af7e-9d36-4009-bf4f-8190f0c2069c/Image.png)

1. Procure por Adicionar e em seguida, clique em Nova Pasta

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/69cc854f-6aea-47ca-92d0-3d527df71bd1/Image.png)

1. Escreva no nome da pasta a palavra Models
1. 

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/814aea8e-1cee-49a5-89a6-cabd3894655a/Image.png)

- [ ]  Criar a pasta Repositories

Dentro da pasta haverá repositórios responsáveis por lidar com a lógica de acesso a dados. Eles fornecem uma abstração sobre como os dados são armazenados e recuperados. Por exemplo, se você está lidando com dados de usuário, o repositório de usuário pode ser responsável por recuperar, atualizar, criar e excluir usuários no banco de dados.

1. Clique com o botão direito no nome do projeto Chapter.

    ![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/dc84af7e-9d36-4009-bf4f-8190f0c2069c/Image.png)

2. Procure por Adicionar e em seguida, clique em Nova Pasta

    ![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/69cc854f-6aea-47ca-92d0-3d527df71bd1/Image.png)

3. Escreva no nome da pasta a palavra Repositories

    ![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/3bbc7646-f945-440c-8ffe-9221e89649a8/Image.png)

- [ ]  Criar a pasta Contexts

Na pasta Contexts será o contexto é uma noção abstrata que geralmente se refere ao estado ou ambiente no qual uma operação específica está ocorrendo. Em uma API, o contexto pode se referir ao estado atual da solicitação, como as informações do usuário que fez a solicitação, as permissões de acesso, configurações específicas da aplicação e assim por diante. O contexto ajuda a determinar como as solicitações devem ser tratadas com base nas condições atuais.

1. Clique com o botão direito no nome do projeto Chapter.

    ![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/dc84af7e-9d36-4009-bf4f-8190f0c2069c/Image.png)

2. Procure por Adicionar e em seguida, clique em Nova Pasta

    ![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/69cc854f-6aea-47ca-92d0-3d527df71bd1/Image.png)

3. Escreva no nome da pasta a palavra Contexts

    ![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/717b88bf-80bb-42bd-be4c-8a4ebe1b1481/Image.png)


Agora, dentro da pasta Models, terão todas as classes do nosso sistema. Será nela que terão as classes com os atributos e métodos.

Para criar a classe, você precisa clicar em Models e depois no botão direito. Procure por Adicionar e em seguida, Classe.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/577fa445-55f2-48a5-b893-d93f4f5757b2/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/dcc021f1-6137-46d6-ad16-3a6580f7284c/Image.png)

Abrirá um campo para criar a classe. A única coisa que vai precisar mudar será o nome da classe. Coloque Livro.cs e em seguida clique no botão **Adicionar**.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/907c1547-e7ea-49c6-b312-b1bee183998e/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/f62766a3-b9ec-4061-a96c-596b8155b52c/Image.png)

Dentro da classe iremos criar os atributos públicos com seus tipos de dados. Então para ID será int por ser numérico, o título string por ser texto, e o bool para Disponível que é um tipo de dado que retorna true ou false.

Os métodos de acesso **`get`** e **`set`** servem para controlar os valores do atributo.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/ba74aa97-e097-424e-b51b-0dc2a4abec24/Image.png)

Agora no Context vamos aplicar as configurações para conectarmos nossa API ao banco.

Para isso precisamos instalar um pacote do sql server. E isso é um dos pontos positivos do Visual Studio, dentro dele tem um gerenciador de pacotes nuget e ele traz várioss pacotes para instalarmos.

Para acessar o gerenciador de pacotes do NuGet, clique no botão direito em cima do nome do projeto e procure por “Gerenciar Pacotes do NuGet.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/5a4b9c56-5641-42e8-9fbe-9b3c270d366f/Image.png)

Será aberto uma janela de pacores NuGet, clique em Procurar e pesquise por “Sql Server”

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/96124d13-04c4-47d3-ac1d-02fe3c16acc8/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/2693bb49-f58a-425f-bddd-6309dde2ec2c/Image.png)

Clique em:

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/3ad715b4-fc3b-41f6-be4d-4ff2512b005e/Image.png)

Verifique se a versão é 6.0.21 e depois clique em Instalar:

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/93ec7ab7-85e2-4ffb-a785-64bc238caee7/Image.png)

Aguarde a instalação.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/9eb4dc1b-1f39-456c-9163-75f5d387df49/Image.png)

Clique em aplicar:

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/b9eb4955-4ab3-4449-a24b-6954608c39ec/Image.png)

E em seguida, clique em Eu aceito:

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/86d258dc-c08e-41fb-bcb4-9a75425a2fbf/Image.png)

Assim que aparecer essa imagem, seu pacote foi instalado:

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/9a6d6ac7-82f9-462d-b4c7-ee36d6dc6c75/Image.png)

Agora na pasta Context vamos adicionar a classe ChapterContext.cs (sem plural).

Para criar a classe, você precisa clicar em Context e depois no botão direito. Procure por **Adicionar** e em seguida clique em **Classe**.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/ae7e2c6e-c93b-4b08-a9e5-04d5a0d1ef7a/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/9a4924d6-945e-4a8e-8816-57d81daf1d81/Image.png)

Escreva o nome da classe como ChapterContext.cs

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/049df38b-ad37-4571-abdf-f40672db93f8/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/0208b905-b066-4285-ba52-8c67de37063c/Image.png)

Dentro da classe ChapterContext será necessário herdar o DbContext:
```
using ChapterFST1.Models;
using Microsoft.EntityFrameworkCore;
namespace ChapterFST1.Contexts
{
    public class ChapterContext : DbContext
    {
     
    }
}
```
Em seguida, criar o método construtor ChapterContext() e outro com parametros.

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
       
    }
}
```
Em seguida, será necessário criar o método OnConfiguring e depois, chamar as entidades que serão usadas na leitura.

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
                optionsBuilder.UseSqlServer("");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }
    }
}
```
Para colocar as informações necessárias dentro do ***optionsBuilder.UseSqlServer("");***  você precisa ir no seu banco de dados, se conectar e seguir os passos para pegar algumas informações de conexão;

Entre no SSMS e em cima do nome do servidos, clique no botão direito e em seguida, em **propriedades**.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/415a19d4-6e3a-449b-a12d-ec62b87d453c/Image.png)

Copie a informação do nome desse banco.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/ac16706e-9b6a-4e2a-8919-052753aaaa67/Image.png)

E aplique dentro de Data Source:

As demais informações são padrões.

```
using ChapterFST1.Models;
using Microsoft.EntityFrameworkCore;
	@@ -275,12 +461,36 @@ namespace ChapterFST1.Contexts
    }
}
```
Agora no repositories, vamos criar uma classe chamada Livro Repository.cs

Clique na pasta Repositories e em seguida botão direito, procure por **Adicionar** e em seguida **Classe**.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/af2895c3-2b9d-41af-8511-be2fdf5baf49/Image.png)

Escreva o nome da classe, LivroRepository.cs

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/da707bd5-4711-4093-ab2c-d113abf1c870/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/d363d4e5-505c-4079-ae37-abbcc9044f9a/Image.png)

Dentro da classe você vai criar primeiro um método construtor privado e de leitura da Classe ChapterContext.

```
using ChapterFST1.Contexts;
using ChapterFST1.Models;
namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
				//Método construtor
				//Somente leitura
        private readonly ChapterContext _context;
    }
}
```
E em seguida, criar outro método construtor público, agora com o nome LivroRepository que possui como parâmetro uma variável context do tipo ChapterContext. 

```
using ChapterFST1.Contexts;
	@@ -290,8 +500,33 @@ namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
//Método construtor
//Somente leitura
        private readonly ChapterContext _context;
//Método conbstrututor
//
        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }
    }
}
```
Depois disso, crie um método público chamado Listar() que tem como retorno uma lista de livros, e dentro desse método um return que lista os livros que estão dentro do bancok, no caso do _context.

```
using ChapterFST1.Contexts;
using ChapterFST1.Models;
namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
//Método construtor
//Somente leitura
        private readonly ChapterContext _context;
//Método conbstrututor
//
        public LivroRepository(ChapterContext context)
        {
            _context = context;
	@@ -304,22 +539,55 @@ namespace ChapterFST1.Repositories
    }
}
```
Agora no Controller, vamos criar um controlador chamado LivroController.cs

Clique na pasta Controllers e em seguida, no botão direito. Procure por **Adicionar** e em seguida **Controlador**. 

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/296ce43f-446f-4f04-b9e8-fb62661b880c/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/f8111ed4-faf8-4706-9e5a-6b2dcd173dfa/Image.png)

Assim que abrir uma aba para Adicionar Novo Item com Scaffolding, na aba da esquerda em Comum, clique em API. Depois selecione a opção Controlador MVC - Vazio e depois isso clique em Adicionar.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/f050218f-768a-4e36-a223-51b9487e5017/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/944aa228-378b-488f-a979-e18e4d60f3ac/Image.png)

Em seguida aplique o nome do controller como LivroController.cs e depois clique em Adicionar.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/21f1fa80-85c3-4ee3-817a-7a67b649c153/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/ea51837a-0a57-4904-b005-3a2d87521e23/Image.png)

Acima de “  [Route("api/[controller]")]” será colocado o “[Produces("application/json")] ” que serve para informar que utilizaremos o arquivo json para comunicação:

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/da440c11-7c12-4c3f-b7bc-3ea1faeaafe7/Image.png)

Em seguida, será criado um método construtor privado e de leitura da nossa classe LivroRepository. E além disso, um método construtor da própria classe que receberá como parametro o livroRepository.

```
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
    }
```
Em seguida, crie o [HttpGet] e abaixo dele, um método de listagem que dentro terá um try catch com retornos de erro e OK.

```
[Produces("application/json")]
    
    [Route("api/[controller]")]
	@@ -346,28 +614,47 @@ namespace ChapterFST1.Controllers
                throw new Exception(e.Message);
            }
        }
    }
```
Em seguida, no arquivo program.cs você precisa adicionar essas duas linhas de código:
```
builder.Services.AddScoped<ChapterContext, ChapterContext>();
builder.Services.AddTransient<LivroRepository, LivroRepository>();
```
![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/b45e13e6-9f8e-41fa-9ab6-f5c4ac36d148/Image.png)

Agora, a API está pronta para rodar. Clique em Chapter.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/69dc4f53-3cd7-4003-bcef-52b35505a0b2/Image.png)

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/acfcf140-5b84-4f07-9451-f9692b756d16/Image.png)

Aguarde a execução.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/b3bf47af-3ce2-4e65-ba6a-c02813480cf1/Image.png)

Será aberto em seu  navegador padrão um cara chamado Swagger, que será uma interface gráfica para nós de back que facilitará a interação do usuário com a API. 

Abra a Aba em azul

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/e7344507-7193-414c-a946-638b2a72786c/Image.png)

Clique em Try it out

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/db3491e5-9acb-49a2-97f5-e746ec46e239/Image.png)

Em seguida clique no botão grande escrito Execute

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/3aeca239-671c-4a03-889d-659aff91927a/Image.png)

E você verá o Code, um código de retorno. O 200 siginfica que tudo deu certooo e além disso, na aba de Response body terá a listagem dos livros.

![Image](https://prod-files-secure.s3.us-west-2.amazonaws.com/1d437abc-0f1a-42ab-81bd-882a5132a501/0727f4d5-7c06-4de1-88e0-2d56757bf7e0/Image.png)

Vamos precisar rodar a API clicando no playzinho verde lá no menu do Visual Studio. Ele vai abrir o Swagger... Ele é parecido com o postman, vai fazer requisições utilizando o protocolo http e você consegue testar a api através dele, além disso, ele também serve como documentação
-clicar em try it out
-clicar em execute

<h1>TESTE DE BACK</h1>
