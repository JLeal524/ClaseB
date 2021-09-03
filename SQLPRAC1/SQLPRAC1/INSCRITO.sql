﻿CREATE TABLE [dbo].[INSCRITO]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Id_ALUMNO] INT NULL, 
    [COD_CURSO] INT NULL, 
    CONSTRAINT [FK_INSCRITO_ALUMNO] FOREIGN KEY ([Id_ALUMNO]) REFERENCES [ALUMNO]([Id]), 
    CONSTRAINT [FK_INSCRITO_CURSO] FOREIGN KEY ([COD_CURSO]) REFERENCES [Curso]([Id])
)
