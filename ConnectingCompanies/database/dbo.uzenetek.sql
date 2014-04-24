CREATE TABLE [dbo].[uzenetek] (
    [Id]              INT NOT NULL,
    [felado]          INT NOT NULL,
    [cimzett]         INT NULL,
    [csoportos_level] BIT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

