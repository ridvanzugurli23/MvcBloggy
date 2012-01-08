﻿CREATE TABLE [dbo].[BlogPosts](
	[BlogPostId] INT IDENTITY(1000,1) NOT NULL,
	[LanguageId] INT NOT NULL,
	[BlogPostGUID] UNIQUEIDENTIFIER NOT NULL,
	[SecondaryID] INT NULL,
	[BlogPostTitle] NVARCHAR(300) NULL,
	[BlogPostBriefInfo] NVARCHAR(200) NULL,
	[BlogPostContent] NVARCHAR(max) NULL,
	[BlogPostTags] NVARCHAR(500) NULL,
	[BlogPostImagePath] NVARCHAR(300) NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	[LastUpdatedOn] DATETIMEOFFSET NULL,
	[IsApproved] BIT NOT NULL,
	CONSTRAINT [PK_BlogPosts] PRIMARY KEY CLUSTERED (
		[BlogPostId] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO