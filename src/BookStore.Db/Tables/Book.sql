CREATE TABLE [dbo].[Book]
(
	[BookId] BIGINT IDENTITY (1, 1) NOT NULL, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [PublishData] DATETIME2 NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL, 
    [Price] DECIMAL NOT NULL, 
    [IsEnabled] BIT NOT NULL,
	PRIMARY KEY CLUSTERED ([BookId] ASC)
)
