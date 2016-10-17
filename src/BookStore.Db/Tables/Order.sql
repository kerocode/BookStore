CREATE TABLE [dbo].[Order](
  [OrderId] BIGINT IDENTITY (1, 1) NOT NULL
  PRIMARY KEY CLUSTERED ([OrderId] ASC),
   
  [UserId] BIGINT NOT NULL
  CONSTRAINT [FK_Order_UserId]
  REFERENCES [dbo].[User]([UserId])
);

GO
