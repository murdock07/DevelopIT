CREATE TABLE [dbo].[ajanlatok] (
    [Id] INT NOT NULL,
    [kezdo_ceg] INT NOT NULL, 
    [fogado_ceg] INT NOT NULL, 
    [megnevezes] NVARCHAR(50) NOT NULL, 
    [kezdes_datum] DATE NOT NULL, 
    [zaras_datum] DATE NULL, 
    [osszeg] INT NOT NULL, 
    [leiras] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_ajanlatok_ToCsoportok] FOREIGN KEY ([kezdo_ceg]) REFERENCES [csoportok]([Id]), 
    CONSTRAINT [FK_ajanlatok_ToCsoportok2] FOREIGN KEY ([fogado_ceg]) REFERENCES [csoportok]([Id])
);

