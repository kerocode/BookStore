﻿CREATE TABLE [dbo].[Order]
(
	 [OrderId] BIGINT IDENTITY (1, 1) NOT NULL
	  PRIMARY KEY CLUSTERED ([OrderId] ASC),
     [OrderItemId] BIGINT NOT NULL
     CONSTRAINT [FK_Order_OrderItemId]
     REFERENCES [dbo].[OrderItem]([OrderItemId]),
	 [UserId] BIGINT NOT NULL
     CONSTRAINT [FK_Order_UserId]
     REFERENCES [dbo].[User]([UserId]),
	 [OrderDate] DATETIME2 NOT NULL,
	 [Total] MONEY NOT NULL
);

GO
