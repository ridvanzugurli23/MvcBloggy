﻿CREATE TABLE [dbo].[DynamicPages] (

	[DynamicPageId] INT IDENTITY NOT NULL,
	[LanguageId] INT NOT NULL,
	[Title] NVARCHAR(500) NOT NULL,
	[BriefInfo] NVARCHAR(500) NOT NULL,
	[Content] NVARCHAR(max) NULL,
	[IsApproved] BIT NOT NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_DynamicPages] PRIMARY KEY ([DynamicPageId])

)