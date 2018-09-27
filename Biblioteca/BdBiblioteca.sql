create database BdBiblioteca

CREATE TABLE Livros(
Id_Livro                           INT IDENTITY(1,1) PRIMARY KEY,
Nome_Livro                         VARCHAR(100) NOT NULL,
Autor_Livro                        VARCHAR(50) NOT NULL,
Ano_Livro                          SMALLINT NOT NULL,
Genero_Livro                       VARCHAR(50) NOT NULL,
Editora_Livro                      VARCHAR(50) NOT NULL,
Paginas_Livro                      SMALLINT NULL,
Status_Livro                       CHAR(1) NOT NULL
)


CREATE TABLE Funcionarios(
Id_Funcionario                     INT IDENTITY(1,1) PRIMARY KEY,
Nome_Funcionario                   VARCHAR(100) NOT NULL,
Endereco_Funcionario               VARCHAR(50) NOT NULL,
Cidade_Funcionario                 VARCHAR(50) NOT NULL,
Estado_Funcionario                 VARCHAR(30) NOT NULL,
Telefone_Funcionario               VARCHAR(20) NULL,
Cargo_Funcionario                  VARCHAR(30) NOT NULL,
Data_Admissao_Funcionario          SMALLDATETIME NOT NULL,
Data_Demissao_Funcionario          SMALLDATETIME NULL
)

CREATE TABLE Clientes( 
Id_Cliente                         INT IDENTITY(1,1) PRIMARY KEY,
Nome_Cliente                       VARCHAR(100) NOT NULL,
Endereco_Cliente                   VARCHAR(50) NOT NULL,
Cidade_Cliente                     VARCHAR(50) NOT NULL,
Estado_Cliente                     VARCHAR(30) NOT NULL,
Telefone_Cliente                   VARCHAR(20) NULL,
Status_Cliente                     CHAR(1) NOT NULL
)


SELECT 1 FROM SYS.DATABASES WHERE NAME LIKE 'BdBiblioteca'