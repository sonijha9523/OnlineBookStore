CREATE TABLE [dbo].[Book] (
    [BookId]        INT            IDENTITY (200, 1) NOT NULL,
    [BookTitle]     VARCHAR (100)  NULL,
    [Price]         MONEY          NULL,
    [BookQuantity]  INT            NULL,
    [CategoryId]    INT            NULL,
    [SubCategoryId] INT            NULL,
    [SupplierId]    INT            NULL,
    [Image]         VARCHAR (1000) NULL,
    CONSTRAINT [PK__Book__3DE0C2070D0D16BF] PRIMARY KEY CLUSTERED ([BookId] ASC),
    CONSTRAINT [BookFK] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId])
);

