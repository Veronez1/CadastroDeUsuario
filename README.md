# Cadastro de usuário feito com ASP.NET MVC/C# 

<h4>Como rodar o projeto</h4>

Baixe os pacotes Nuget no visual studio, lá em baixo tem minha versão do visual studio e do SDK para baixar, para não dar erro de compatibidade.

![nuget1](https://user-images.githubusercontent.com/87334467/205806984-be95596b-2844-487b-9bc1-ae697a726237.png)<br>

Esses são os pacotes para serem baixados, nessa versão 7.0.0

![nuget2](https://user-images.githubusercontent.com/87334467/205807012-d7c31078-6f93-4f03-8c55-df89c9e9662a.png)<br>

Depois de ter ajustado o ambiente, clone o ambiente clicando aqui

![clone](https://user-images.githubusercontent.com/87334467/205807056-00267c79-450b-4e60-ab28-28d9380a8afd.png)<br>

O Link para clonar é esse aqui: https://github.com/Veronez1/CadastroDeUsuario.git
A pasta você tem que criar no seu computador, pode ser em qualquer lugar, crie ela clicando nos tres pontinhos, pois já vai vir direto o caminho dela, depois é só clicar em clonar

![clone2](https://user-images.githubusercontent.com/87334467/205807073-2555938c-111f-42d7-8424-20167f89deb8.png)<br>

Espere alguns segundos, para o projeto se ambientar e clonar tudo certinho, pois se rodar logo em seguida vai dar erro de Build, assim que tudo rodar, clique no botão CadastroDeUsuario, que está com o botão play verde preenchido.

![rodar1](https://user-images.githubusercontent.com/87334467/205807087-2f94a01e-1aae-42d7-8571-8b6bdcdc9825.png)<br>

<hr>
<h4>Rotas</h4>
Para chegar na <strong>tela de usuários</strong> (acesse a rota https://localhost:7086/Usuarios)<br>
Para chegar na <strong>tela de cadastrar usuários</strong> (acesse a rota https://localhost:7086/Usuarios/Create)<br>
Para chegar na <strong>tela de editar usuários</strong> (acesse a rota https://localhost:7086/Usuarios/Edit/(ID que pretende alterar)<br>
Para chegar na <strong>tela de visualizar usuários</strong> (acesse a rota https://localhost:7086/Usuarios/Details/(ID que pretende visualizar)<br>
Para chegar na <strong>tela de apagar usuários</strong> (acesse a rota https://localhost:7086/Usuarios/Delete/(ID que pretende apagar)<br>
Para chegar na <strong>tela de bem vindo</strong> (acesse a rota https://localhost:7086/)<br>


<h4>Foram ultilizado os packages de nuGet:</h4>

Microsoft.EntityFrameworkCore<br>
Microsoft.EntityFrameworkCore.SqlServer<br>
Microsoft.EntityFrameworkCore.Tools<br>
Microsoft.VisualStudio.Web.CodeGeneration.Design<br>
Versão 7.0.0<br>

<h4>.NET SDKs installed:</h4>
  7.0.100

<h4>Visual Studio</h4>
Visual Studio 2022 versão 17.4.2

Qualquer erro de compatibilidade, verifica no arquivo: CadastroDeUsuario.csproj
