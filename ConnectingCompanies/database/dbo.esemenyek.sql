CREATE TABLE [dbo].[esemenyek] (
    [Id] INT NOT NULL,
    [megnevezes] NVARCHAR(50) NOT NULL, 
    [idopont] DATE NOT NULL, 
    [leiras] NVARCHAR(MAX) NULL, 
    [helyszin] NVARCHAR(50) NOT NULL, 
    [csoportos] BIT NOT NULL, 
    [letrehozo] INT NOT NULL, 
    [meghivott_szemely] INT NULL, 
    [meghivott_csoport] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_esemenyek_ToFelhasznalok] FOREIGN KEY ([letrehozo]) REFERENCES [felhasznalok]([Id]), 
    CONSTRAINT [FK_esemenyek_ToFelhasznalok2] FOREIGN KEY ([meghivott_szemely]) REFERENCES [felhasznalok]([Id]), 
    CONSTRAINT [FK_esemenyek_ToCsoportok] FOREIGN KEY ([meghivott_csoport]) REFERENCES [csoportok]([Id])
);

