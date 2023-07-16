IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Requisicaos] (
    [Id] int NOT NULL IDENTITY,
    [NomeCompleto] nvarchar(max) NOT NULL,
    [Data] datetime2 NOT NULL,
    [Cidade] nvarchar(max) NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [RequisicaoStatus] int NOT NULL,
    CONSTRAINT [PK_Requisicaos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230715010804_MigrationInicial', N'7.0.9');
GO

COMMIT;
GO

