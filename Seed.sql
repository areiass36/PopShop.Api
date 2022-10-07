/*Usuarios Seeds*/
INSERT INTO dbo.Usuario (Nome, Sobrenome, Email, Senha, Cargo, DataCriacao ,Ativo) 
VALUES 
    ('Augusto Store', 'Barreto', 'barretoareias@gmail.com', 'password', 2, GETDATE(), 1);

INSERT INTO dbo.Usuario (Nome, Sobrenome, Email, Senha, Cargo, DataCriacao ,Ativo)
VALUES
    ('Paulo Store', 'Silva', 'paulo.silva@gmail.com', 'password', 2, GETDATE(), 1);

/*Store Seeds*/
INSERT INTO dbo.Loja (Nome, Descricao, FotoUrl, Usuario)
VALUES
    ('Store A', 'Minha Loja A', '', (SELECT TOP 1 Id FROM dbo.Usuario WHERE Nome = 'Augusto Store'));

INSERT INTO dbo.Loja (Nome, Descricao, FotoUrl, Usuario)
VALUES
    ('Store B', 'Minha Loja B', '', (SELECT TOP 1 Id FROM dbo.Usuario WHERE Nome = 'Paulo Store'));

/*Product Seeds*/
--Store A
INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto A-A', 10.0, 'Desc', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store A') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto A-B', 200.0, 'Desc 2', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store A') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto A-C', 350.0, 'Desc 3', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store A') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto A-D', 16.0, 'Desc 4', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store A') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto A-E', 180.0, 'Desc 5', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store A') ,1);


INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto A-F', 185.0, 'Desc 6', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store A') ,1);

--Store B
INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto B-A', 10.0, 'Desc', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store B') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto B-B', 150.0, 'Desc 2', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store B') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto B-C', 260.0, 'Desc 3', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store B') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto B-D', 180.0, 'Desc 4', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store B') ,1);

INSERT INTO dbo.Produto (Nome, Preco, Descricao, DataCriacao, Loja, Ativo)
VALUES
    ('Produto B-E', 170.0, 'Desc 5', GETDATE(), (SELECT TOP 1 Id FROM dbo.Loja WHERE Nome = 'Store B') ,1);



