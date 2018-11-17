CREATE TABLE [dbo].[ProductOrderDetails] (
    [RequestId]            INT NOT NULL,
    [BookId]               INT NOT NULL,
    [ProductOrderQuantity] INT NULL,
    CONSTRAINT [PK_ProductOrderDetails] PRIMARY KEY CLUSTERED ([RequestId] ASC, [BookId] ASC),
    CONSTRAINT [Fk_Book1] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Book] ([BookId]),
    CONSTRAINT [Fk_ProductDetails1] FOREIGN KEY ([RequestId]) REFERENCES [dbo].[ProductOrder] ([RequestId])
);

