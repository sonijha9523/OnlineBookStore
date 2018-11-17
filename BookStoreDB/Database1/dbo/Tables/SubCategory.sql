CREATE TABLE [dbo].[SubCategory] (
    [SubCategoryId]    INT          IDENTITY (500, 1) NOT NULL,
    [SubCategoryTitle] VARCHAR (20) NULL,
    [CategoryId]       INT          NOT NULL,
    CONSTRAINT [PK_SubCategory] PRIMARY KEY CLUSTERED ([SubCategoryId] ASC, [CategoryId] ASC),
    CONSTRAINT [SubCategorysFK] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId])
);

