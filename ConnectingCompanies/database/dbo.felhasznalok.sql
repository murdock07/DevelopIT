CREATE TABLE [dbo].[felhasznalok] (
    [Id]                 INT            NOT NULL,
    [azonosito]          NCHAR (10)     NOT NULL,
    [jelszo]             NCHAR (10)     NOT NULL,
    [jogosultsagi_szint] INT            NOT NULL,
    [nev]                NVARCHAR (50)  NOT NULL,
    [lakhely]            NVARCHAR (50)  NOT NULL,
    [szuletesi_hely]     NVARCHAR (50)  NULL,
    [szuletesi_ido]      DATE           NOT NULL,
    [csoport]            INT            NULL,
    [beosztas]           NVARCHAR (50)  NULL,
    [leiras]             NVARCHAR (MAX) NULL,
    [profilkep]          INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_felhasznalok_ToJogosultsagok] FOREIGN KEY ([jogosultsagi_szint]) REFERENCES [dbo].[jogosultsagi_szintek] ([Id]),
    CONSTRAINT [FK_felhasznalok_ToKepek] FOREIGN KEY ([profilkep]) REFERENCES [dbo].[kepek] ([Id]),
    CONSTRAINT [FK_felhasznalok_ToCsoportok] FOREIGN KEY ([csoport]) REFERENCES [dbo].[csoportok] ([Id])
);

