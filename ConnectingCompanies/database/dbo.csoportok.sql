CREATE TABLE [dbo].[csoportok] (
    [Id]              INT            NOT NULL,
    [cegnev]          NVARCHAR (50)  NOT NULL,
    [telephely]       NVARCHAR (50)  NULL,
    [cegvezeto]       INT            NOT NULL,
    [levelezesi_cim]  NCHAR (10)     NULL,
    [alapitas_datuma] DATE           NULL,
    [logo]            INT            NULL,
    [leiras]          NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_csoportok_ToFelhasznalok] FOREIGN KEY ([cegvezeto]) REFERENCES [dbo].[felhasznalok] ([Id]),
    CONSTRAINT [FK_csoportok_ToKepek] FOREIGN KEY ([logo]) REFERENCES [dbo].[kepek] ([Id])
);

