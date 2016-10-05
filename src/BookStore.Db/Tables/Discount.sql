CREATE TABLE [dbo].[Discount](
	[DiscountId] BIGINT IDENTITY (1,1) NOT NULL,
	[Name] NVARCHAR(100) NOT NULL, 
	[Description] NVARCHAR(MAX) NOT NULL, 
	[Percentage] decimal NOT NULL,
    [ValidUntil] DATETIME2 NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL, 
	[UpdatedAt] DATETIME2 NOT NULL, 
    [IsEnabled] BIT NOT NULL,
	PRIMARY KEY CLUSTERED ([DiscountId] ASC)
);