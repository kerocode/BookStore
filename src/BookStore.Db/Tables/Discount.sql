CREATE TABLE [dbo].[Discount]
(
	[DiscountId] BIGINT IDENTITY (1,1) NOT NULL,
	[BookId]  BIGINT NOT NULL,
	[Name] NVARCHAR(100) NOT NULL, 
	[Description] NVARCHAR(MAX) NOT NULL, 
	[Percentage] decimal NOT NULL,
    [ValidUntil] DATETIME2 NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL, 
	[UpdatedAt] DATETIME2 (7) NOT NULL, 
    [IsEnabled] BIT NOT NULL,
	CONSTRAINT [FK_Order_BookId] FOREIGN KEY (BookId)
	REFERENCES [dbo].[Book]([BookId]),
    [ts]        rowversion NOT NULL,
	PRIMARY KEY CLUSTERED ([DiscountId] ASC)
);
GO