CREATE TABLE [dbo].[Ranking] (
    [Ranking_Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Player_Name]         NVARCHAR (MAX) NULL,
    [Test]                NVARCHAR (MAX) NULL,
    [ODI]                 NVARCHAR (MAX) NULL,
    [T20]                 NVARCHAR (MAX) NULL,
    [Player_ID]           INT            NOT NULL,
    [Player_objPlayer_Id] INT            NULL,
    CONSTRAINT [PK_Ranking] PRIMARY KEY CLUSTERED ([Ranking_Id] ASC),
    CONSTRAINT [FK_Ranking_Players_Player_objPlayer_Id] FOREIGN KEY ([Player_objPlayer_Id]) REFERENCES [dbo].[Players] ([Player_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Ranking_Player_objPlayer_Id]
    ON [dbo].[Ranking]([Player_objPlayer_Id] ASC);


    CREATE TABLE [dbo].[Players] (
    [Player_Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Player_Name]    NVARCHAR (MAX) NULL,
    [Player_Address] NVARCHAR (MAX) NULL,
    [Player_Mobile]  NVARCHAR (MAX) NULL,
    [Player_Email]   NVARCHAR (MAX) NULL,
    [Player_Age]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Players] PRIMARY KEY CLUSTERED ([Player_Id] ASC)
);


CREATE TABLE [dbo].[Fixtures] (
    [Fixture_Id]          INT            IDENTITY (1, 1) NOT NULL,
    [vs_Team]             NVARCHAR (MAX) NULL,
    [Country]             NVARCHAR (MAX) NULL,
    [Date]                DATETIME2 (7)  NOT NULL,
    [Ground_Name]         NVARCHAR (MAX) NULL,
    [Player_ID]           INT            NOT NULL,
    [Player_objPlayer_Id] INT            NULL,
    CONSTRAINT [PK_Fixtures] PRIMARY KEY CLUSTERED ([Fixture_Id] ASC),
    CONSTRAINT [FK_Fixtures_Players_Player_objPlayer_Id] FOREIGN KEY ([Player_objPlayer_Id]) REFERENCES [dbo].[Players] ([Player_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Fixtures_Player_objPlayer_Id]
    ON [dbo].[Fixtures]([Player_objPlayer_Id] ASC);


    CREATE TABLE [dbo].[Events] (
    [Event_Id]              INT            IDENTITY (1, 1) NOT NULL,
    [ICC_WTC]               NVARCHAR (MAX) NULL,
    [IPL]                   NVARCHAR (MAX) NULL,
    [T20_WC]                NVARCHAR (MAX) NULL,
    [Fixture_ID]            INT            NOT NULL,
    [Fixture_objFixture_Id] INT            NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED ([Event_Id] ASC),
    CONSTRAINT [FK_Events_Fixtures_Fixture_objFixture_Id] FOREIGN KEY ([Fixture_objFixture_Id]) REFERENCES [dbo].[Fixtures] ([Fixture_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Events_Fixture_objFixture_Id]
    ON [dbo].[Events]([Fixture_objFixture_Id] ASC);



    CREATE TABLE [dbo].[__EFMigrationsHistory] (
    [MigrationId]    NVARCHAR (150) NOT NULL,
    [ProductVersion] NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC)
);

