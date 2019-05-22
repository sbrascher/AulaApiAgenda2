CREATE TABLE [dbo].[Contato]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Nome] varchar(100) not null, 
    CONSTRAINT [PK_Contato] PRIMARY KEY ([Id])
)
