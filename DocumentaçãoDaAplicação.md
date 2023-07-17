# BusinessCase_Demant_Main

CRUD - GERENCIAMENTO DE REQUISIÇÕES

Este é um projeto de um CRUD(Create, Read, Update, Delete) que gerencia requisições desenvolvido em C#, utilizando MVP(Mínimo Produto Viável) e DDD(Domain Driven Design).

FUNCIONALIDADES

O sistema oferece as seguintes funcionalidades:

-Cadastrar uma nova requisição

-Alterar uma requisição setada no cadastro(dada opções de nome,status,cidade, descrição)

-Excluir uma requisição(caso haja)

-Imprimir as requisições realizadas(caso haja)

SOBRE O PROJETO

Backend

-Foi criada uma Web Api em C#, utilizando entity framework e SqlServer.

Front end

-Foi criada uma page em React js para consumir a Web Api.

Foi utilizado a arquitetura em camadas para isolar o domínio e para manter a complexidade no coração do software(entidade Requisição)

Essa arquitetura diminui a complexidade do código e ajuda a manter a organização do domínio.

CAMADA API - Ela é responsável pela criação dos controllers e verbos http para fazermos as requisições necessárias.

CAMADA APPLICATION - Responsável pela regra de negócio. Eu deixo ela implementada esperando que minha aplicação cresça, mas no momento ela não se faz necessária pois não tem muitas funcionalidades.

CAMADA DOMAIN - Onde fica toda a complexidade do código e regras de domínio que no caso é o CRUD.

CAMADA INFRAESTRUTURA - Responsável apenas pela complexidade do banco de dados e persistência de dados.




