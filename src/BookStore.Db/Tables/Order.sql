CREATE TABLE [dbo].[Order]
(
	 [OrderId] BIGINT IDENTITY (1, 1) NOT NULL
	  PRIMARY KEY CLUSTERED ([OrderId] ASC),
     [OrderItemId] BIGINT NOT NULL
     CONSTRAINT [FK_Order_OrderItemId]
     REFERENCES [dbo].[OrderItem]([OrderItemId]),
	
	 [Quantity] INT NOT NULL,
	 [OrderDate] DATETIME2 (7) NOT NULL,
	 [Total] MONEY NOT NULL,
	 [ts]        rowversion NOT NULL,
);

GO
