IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Atores] (
    [actor_id] int NOT NULL IDENTITY,
    [first_name] varchar(45) NOT NULL,
    [last_name] varchar(45) NOT NULL,
    CONSTRAINT [PK_Atores] PRIMARY KEY ([actor_id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220105182523_Inicial', N'2.0.0-rtm-26452');

GO

