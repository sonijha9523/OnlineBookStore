CREATE TABLE [dbo].[OrderDetails] (
    [OrderId]    INT   NOT NULL,
    [BookId]     INT   NOT NULL,
    [Quantity]   INT   NULL,
    [OrderPrice] MONEY NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED ([OrderId] ASC, [BookId] ASC),
    CONSTRAINT [Fk_OrderDetails] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]),
    CONSTRAINT [FK_OrderDetails_Book] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Book] ([BookId])
);

