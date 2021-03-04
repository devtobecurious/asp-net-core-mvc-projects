Build started...
Build succeeded.
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

CREATE TABLE [Weapon] (
    [Id] int NOT NULL IDENTITY,
    [Label] nvarchar(max) NULL,
    [TypeId] int NOT NULL,
    CONSTRAINT [PK_Weapon] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Wookie] (
    [Id] int NOT NULL IDENTITY,
    [Surname] nvarchar(max) NULL,
    [MainWeaponId] int NULL,
    CONSTRAINT [PK_Wookie] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Wookie_Weapon_MainWeaponId] FOREIGN KEY ([MainWeaponId]) REFERENCES [Weapon] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Selfie] (
    [Id] int NOT NULL IDENTITY,
    [Titre] nvarchar(max) NULL,
    [ImageUrl] nvarchar(max) NULL,
    [OwnerId] int NULL,
    CONSTRAINT [PK_Selfie] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Selfie_Wookie_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [Wookie] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Selfie_OwnerId] ON [Selfie] ([OwnerId]);
GO

CREATE INDEX [IX_Wookie_MainWeaponId] ON [Wookie] ([MainWeaponId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210304095502_First', N'5.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Wookie] ADD [AvatarUrl] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210304104329_AddAvatarUrl', N'5.0.3');
GO

COMMIT;
GO


