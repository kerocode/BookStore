CREATE TABLE [dbo].[OrderItem](
  [OrderItemId] BIGINT IDENTITY (1, 1) NOT NULL
  PRIMARY KEY CLUSTERED ([OrderItemId] ASC),
 
  [OrderId] BIGINT NOT NULL
  CONTSTRAINT [FK_OrderItem_OrderId]
  REFERENCES [dbo].[Order]([OrderId]),
  
  [BookId] BIGINT NOT NULL
  CONSTRAINT [FK_OrderItem_BookId] 
  REFERENCES [dbo].[Book]([BookId]),
  
  [Quantity] INT NOT NULL,
  
  [Price] money NOT NULL
);

GO
