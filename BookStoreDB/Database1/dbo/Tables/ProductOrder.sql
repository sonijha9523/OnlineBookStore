CREATE TABLE [dbo].[ProductOrder] (
    [RequestId]            INT      IDENTITY (600, 1) NOT NULL,
    [ProductOrderDate]     DATETIME NULL,
    [ProductOrderQuantity] INT      NULL,
    PRIMARY KEY CLUSTERED ([RequestId] ASC)
);

