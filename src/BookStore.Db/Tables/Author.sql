CREATE TABLE [dbo].[Author]
(
	[AuthorId] BIGINT IDENTITY (1, 1) NOT NULL, 
    [FirstName] NVARCHAR(100) NOT NULL, 
	[LastName] NVARCHAR(100) NOT NULL, 
    [BookId] BIGINT NOT NULL,
    FOREIGN KEY ([BookId])  REFERENCES [dbo].[Book]([BookId]),
	[ts]        rowversion NOT NULL,
	PRIMARY KEY CLUSTERED ([AuthorId] ASC)
);
GO