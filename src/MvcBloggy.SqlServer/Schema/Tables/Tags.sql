﻿CREATE TABLE [dbo].[Tags] (
	[Key] INT IDENTITY NOT NULL,
	[LanguageKey] INT NOT NULL,
	[TagGuid] UNIQUEIDENTIFIER NOT NULL,
	[TagName] NVARCHAR(100) NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY ([Key])
);