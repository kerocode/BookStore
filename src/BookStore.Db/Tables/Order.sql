CREATE TABLE [dbo].[Order](
  [OrderId]  BIGINT  IDENTITY (1, 1) NOT NULL,  
  [BookId]   BIGINT NOT NULL
   constraint [FK_Order_UserId] references [dbo].[User]([UserId]),
  [Quantity] INT NOT NULL,
  [Price] money NOT NULL
);