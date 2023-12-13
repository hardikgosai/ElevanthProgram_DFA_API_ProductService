CREATE [GETRIDFA]

USE [GETRIDFA]


CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](250) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NULL
)
