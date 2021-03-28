USE [Northwind]
GO

/****** Object: Table [dbo].[Cars] Script Date: 28.03.2021 16:33:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cars] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NULL,
    [ColorId]     INT           NULL,
	--[CarName]     NVARCHAR(50)  NULL,
    [ModelYear]   INT           NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [Description] NVARCHAR (25) NULL


);
ALTER TABLE Cars 
ADD CarName nvarchar(50);

