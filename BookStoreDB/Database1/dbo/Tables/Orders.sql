CREATE TABLE [dbo].[Orders] (
    [OrderId]       INT      IDENTITY (300, 1) NOT NULL,
    [OrderAmount]   MONEY    NULL,
    [OrderDate]     DATETIME NULL,
    [OrderQuantity] INT      NULL,
    [CustomerId]    INT      NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [OrderFK] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId])
);

