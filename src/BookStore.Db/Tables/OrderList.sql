CREATE TABLE [dbo].[OrderList](
  [UserId] BIGINT NOT NULL
  constraint [FK_OrderList_UserId] references [dbo].[User]([UserId]),
  [OrderId] BIGINT NOT NULL 
  constraint [FK_OrderList_OrderId] references [dbo].[Order]([OrderId]),
  [OrderData] DATETIME2 NOT NULL ,
  PRIMARY KEY CLUSTERED ([UserId] ASC)
);