CREATE TABLE [dbo].[Order](
  [OrderId]  BIGINT  IDENTITY (1, 1) NOT NULL,  
  [BookId]   BIGINT NOT NULL,
  [UserId]   BIGINT NOT NULL,
  [Quantity] INT NOT NULL,
  [Subject]  NVARCHAR (100) NOT NULL,
  [Price] money NOT NULL,
  CONSTRAINT [FK_Order_BookId] FOREIGN KEY (BookId)
  REFERENCES [dbo].[Book]([BookId]),
  CONSTRAINT [FK_Order_UserId] FOREIGN KEY (UserId)
  REFERENCES [dbo].[User]([UserId]),
  PRIMARY KEY CLUSTERED ([OrderId] ASC)
);