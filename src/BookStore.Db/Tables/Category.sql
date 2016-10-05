CREATE TABLE [dbo].[Category](  
    [CategoryId] BIGINT  IDENTITY (1, 1) NOT NULL,  
    [Name] [nvarchar](50) NULL, 
    [Description] NVARCHAR(MAX) NULL,
	PRIMARY KEY CLUSTERED ([CategoryId] ASC)
	
	 )
