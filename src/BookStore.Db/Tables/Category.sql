CREATE TABLE [dbo].[Category](  
    [CategoryId] BIGINT  IDENTITY (1, 1) NOT NULL, 
	[BookId] BIGINT NOT NULL
	CONSTRAINT [FK_Category_BookId] 
	REFERENCES [dbo].[Book]([BookId]),
    [Name] [nvarchar](50) NULL, 
    [Description] NVARCHAR(MAX) NULL,
	[ts]        rowversion NOT NULL,
	PRIMARY KEY CLUSTERED ([CategoryId] ASC)
	 )
Go