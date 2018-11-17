CREATE TABLE [dbo].[Payment] (
    [InvoiceNumber] INT          IDENTITY (700, 1) NOT NULL,
    [OrderId]       INT          NOT NULL,
    [PaymentMethod] VARCHAR (20) NULL,
    CONSTRAINT [PK_Payment_1] PRIMARY KEY CLUSTERED ([InvoiceNumber] ASC),
    CONSTRAINT [FK_Payment_Orders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId])
);

