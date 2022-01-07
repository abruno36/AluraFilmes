# Entity Framework Core parte 1: Mapeando um banco pré-existente  

> ## Informações
>
> **Objetivo:**     
>
> Fizemos o relacionamento de filmes com atores, ou seja, um relacionamento de cardinalidade N:N (muitos para muitos). Um filme possui um elenco de vários atores e um ator pode atuar em vários filmes. Contudo, o Entity Framework Core não suporta esse tipo de cardinalidade onde criamos uma classe que será responsável pelo relacionamento entre outras duas classes.  
---
> **Classe Principal:** considerada a classe independente da relação.
>
> **Classe Dependente:** classe dependente da relação, ou "classe filha". É nela que reside a chave estrangeira.

<img src="https://github.com/abruno36/AluraFilmes/blob/master/Alura.Filmes.App/Images/ImgPropriedades.png" alt="Entidades"/>

> **Chaves Estrangeiras:** propriedades existentes na classe dependente que guardam o valor da classe principal, podem ser shadow properties.
>
>No exemplo abaixo não declaramos uma propriedade explicitamente no código da classe **FilmeAtor**, o que fizemos foi criar uma shadow property para a propriedade actor_id. Feito isso, configuramos o relacionamento utilizando a chave estrangeira actor_id. Fizemos essa configuração utilizando os métodos **HasOne(), WithMany() e HasForeignKey()**.

<img src="https://github.com/abruno36/AluraFilmes/blob/master/Alura.Filmes.App/Images/ImgPropriedades1.png" alt="Entidades"/>


>Aprendemos a convenção o Entity para **chave primária**. A chave primária em uma classe entidade é descoberta detecta a existência de uma propriedade chamada Id ou <nome do tipo>Id. Para configurarmos uma chave primária composta, podemos utilizar o método **HasKey()**.

<img src="https://github.com/abruno36/AluraFilmes/blob/master/Alura.Filmes.App/Images/ImgPropriedades2.png" alt="Entidades"/>

> ## Nível Criticidade
> - [x] - Alto  
> - [ ] - Médio  
> - [ ] - Baixo  
>  
---

> ## Tecnologias
>
> **Frameworks:**  
> - **Entity Framework CORE 4.7 **  
>
> **Tipo de Banco de dados:**  
> - **SQL Server**

>

---







