DROP DATABASE IF EXISTS PopShop;
CREATE DATABASE PopShop;

USE PopShop;

DROP TABLE IF EXISTS dbo.Usuario;
CREATE TABLE dbo.Usuario (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Nome VARCHAR(30) NOT NULL,
    Sobrenome VARCHAR(80) NOT NULL,
    Email VARCHAR(80) NOT NULL,
    Senha VARCHAR NOT NULL,
    Cargo TINYINT NOT NULL,
    FotoUrl VARCHAR,
    DataCriacao DATETIME NOT NULL,
    Ativo BIT NOT NULL,
    PRIMARY KEY (Id),
);

DROP TABLE IF EXISTS dbo.Documento;
CREATE TABLE dbo.Documento (
    Usuario UNIQUEIDENTIFIER NOT NULL,
    Tipo TINYINT,
    Documento VARCHAR(14),
    PRIMARY KEY (Usuario, Tipo),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id)
);

DROP TABLE IF EXISTS dbo.Telefone;
CREATE TABLE dbo.Telefone (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Usuario UNIQUEIDENTIFIER NOT NULL,
    Ddd VARCHAR(2) NOT NULL,
    Numero VARCHAR(9) NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id)
);

DROP TABLE IF EXISTS dbo.Endereco;
CREATE TABLE dbo.Endereco (
  Id UNIQUEIDENTIFIER DEFAULT NEWID(),
  Cep VARCHAR(8) NOT NULL,
  Logradouro VARCHAR(80) NOT NULL,
  Bairro VARCHAR(80) NOT NULL,
  Cidade VARCHAR(40) NOT NULL,
  Uf VARCHAR(2) NOT NULL,
  Numero VARCHAR(20) NOT NULL,
  Complemento VARCHAR(100) NOT NULL,
  Usuario UNIQUEIDENTIFIER NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id)
);

DROP TABLE IF EXISTS dbo.Loja;
CREATE TABLE dbo.Loja (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Nome VARCHAR(60) NOT NULL,
    Descricao VARCHAR(80) NOT NULL,
    FotoUrl VARCHAR,
    Usuario UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id)
);

DROP TABLE IF EXISTS dbo.LojaGostei;
CREATE TABLE dbo.LojaGostei (
    Loja UNIQUEIDENTIFIER NOT NULL,
    Usuario UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (Loja, Usuario),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id),
    FOREIGN KEY (Loja) REFERENCES  dbo.Loja(Id)
 );

DROP TABLE IF EXISTS dbo.Produto;
CREATE TABLE dbo.Produto (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Nome VARCHAR(150) NOT NULL,
    Preco DECIMAL(10,2) NOT NULL,
    Descricao TEXT NOT NULL,
    DataCriacao DATETIME NOT NULL,
    Loja UNIQUEIDENTIFIER NOT NULL,
    Ativo BIT NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Loja) REFERENCES  dbo.Loja(Id)
  );

DROP TABLE IF EXISTS  dbo.ProdutoFoto;
CREATE TABLE dbo.ProdutoFoto (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Produto UNIQUEIDENTIFIER NOT NULL,
    FotoUrl VARCHAR NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Produto) REFERENCES  dbo.Produto(Id)
);

DROP TABLE IF EXISTS dbo.ProdutoVariacao;
CREATE TABLE ProdutoVariacao (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Produto UNIQUEIDENTIFIER NOT NULL,
    Variacao VARCHAR(60) NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Produto) REFERENCES  dbo.Produto(Id)
);

DROP TABLE IF EXISTS  dbo.ProdutoGostei;
CREATE TABLE dbo.ProdutoGostei (
    Produto UNIQUEIDENTIFIER NOT NULL,
    Usuario UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (Produto, Usuario),
    FOREIGN KEY (Produto) REFERENCES  dbo.Produto(Id),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id)
);

DROP TABLE IF EXISTS dbo.ProdutoAvaliacao;
CREATE TABLE dbo.ProdutoAvalicao (
    Produto UNIQUEIDENTIFIER NOT NULL,
    Usuario UNIQUEIDENTIFIER NOT NULL,
    Texto TEXT NOT NULL,
    Nota TINYINT NOT NULL,
    DataCriacao DATETIME NOT NULL,
    PRIMARY KEY (Produto, Usuario),
    FOREIGN KEY (Produto) REFERENCES  dbo.Produto(Id),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id)
);

DROP TABLE IF EXISTS dbo.ProdutoComentario;
CREATE TABLE dbo.ProdutoComentario (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Produto UNIQUEIDENTIFIER NOT NULL,
    Usuario UNIQUEIDENTIFIER NOT NULL,
    Pai UNIQUEIDENTIFIER NOT NULL,
    Texto TEXT NOT NULL,
    DataCriacao DATETIME NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id),
    FOREIGN KEY (Produto) REFERENCES  dbo.Produto(Id)
);

DROP TABLE IF EXISTS dbo.ComentarioGostei;
CREATE TABLE dbo.ComentarioGostei (
    Comentario UNIQUEIDENTIFIER NOT NULL,
    Usuario UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY (Comentario, Usuario),
    FOREIGN KEY (Comentario) REFERENCES  dbo.ProdutoComentario(Id)
);

DROP TABLE IF EXISTS dbo.Carrinho;
CREATE TABLE dbo.Carrinho (
    Id UNIQUEIDENTIFIER DEFAULT NEWID(),
    Usuario UNIQUEIDENTIFIER NOT NULL,
    DataCriacao DATETIME NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Usuario) REFERENCES  dbo.Usuario(Id)
);

DROP TABLE IF EXISTS dbo.CarrinhoProduto;
CREATE TABLE dbo.CarrinhoProduto (
    Carrinho UNIQUEIDENTIFIER NOT NULL,
    Produto UNIQUEIDENTIFIER NOT NULL,
    Variacao UNIQUEIDENTIFIER NOT NULL,
    Quantidade INT NOT NULL,
    PRIMARY KEY (Carrinho, Produto),
    FOREIGN KEY (Carrinho) REFERENCES  dbo.Carrinho(Id),
    FOREIGN KEY (Produto) REFERENCES  dbo.Produto(Id)
);

DROP TABLE IF EXISTS dbo.Compra;
CREATE TABLE dbo.Compra (
    Id UNIQUEIDENTIFIER NOT NULL,
    Carrinho UNIQUEIDENTIFIER NOT NULL,
    FormaPagamento TINYINT NOT NULL,
    Endereco UNIQUEIDENTIFIER NOT NULL,
    DataCriacao DATETIME NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Carrinho) REFERENCES  dbo.Carrinho(Id)
);

DROP TABLE IF EXISTS dbo.CompraStatus;
CREATE TABLE dbo.CompraStatus (
    Id UNIQUEIDENTIFIER NOT NULL,
    Compra UNIQUEIDENTIFIER NOT NULL,
    Status TINYINT NOT NULL,
    DataCriacao DATETIME NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Compra) REFERENCES  dbo.Compra(Id)
);