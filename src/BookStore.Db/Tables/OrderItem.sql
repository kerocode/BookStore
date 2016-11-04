CREATE TABLE [dbo].[OrderItem]
(
	 [OrderItemId] BIGINT IDENTITY (1, 1) NOT NULL
     PRIMARY KEY CLUSTERED ([OrderItemId] ASC),
	  [UserId] BIGINT NOT NULL
     CONSTRAINT [FK_Order_UserId]
     REFERENCES [dbo].[User]([UserId]),
     [OrderId] BIGINT NOT NULL,
     FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order]([OrderId]),

    [BookId] BIGINT NOT NULL,
    FOREIGN KEY ([BookId])  REFERENCES [dbo].[Book]([BookId]),
  
    [Quantity] INT NOT NULL,
  
    [Price] money NOT NULL,
	[ts]        rowversion NOT NULL,
);

GO
