CREATE TABLE [dbo].[Customer] (
    [CustomerId]   INT          IDENTITY (100, 1) NOT NULL,
    [CustomerName] VARCHAR (20) NULL,
    [Email]        VARCHAR (20) NULL,
    [Password]     VARCHAR (20) NULL,
    [MobileNumber] VARCHAR (20) NULL,
    [Address]      VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

