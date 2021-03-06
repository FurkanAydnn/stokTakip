USE [StockManagement]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneCase]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneCase](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](150) NULL,
	[Price] [decimal](18, 2) NULL,
	[CaseColor] [int] NULL,
	[Qty] [int] NULL,
 CONSTRAINT [PK_PhoneCase] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phones]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](150) NULL,
	[Price] [decimal](18, 2) NULL,
	[IMEI1] [nvarchar](50) NULL,
	[IMEI2] [nvarchar](50) NULL,
	[BrandID] [int] NULL,
	[ModelCode] [nvarchar](50) NULL,
	[InCart] [bit] NOT NULL,
 CONSTRAINT [PK_Phones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Phones] ADD  CONSTRAINT [DF_Phones_InCart]  DEFAULT ((1)) FOR [InCart]
GO
/****** Object:  StoredProcedure [dbo].[AddStock]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddStock]
@id int,@qty int
AS
BEGIN
	UPDATE PhoneCase SET Qty = Qty + @qty
	WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[AddtoCart]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddtoCart]
@ID int
AS
BEGIN
	UPDATE Phones SET InCart = 0 WHERE Phones.ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteBrand]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteBrand]
@ID int 
AS
BEGIN
	DELETE FROM Brands WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePhone]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletePhone]
@ID int
AS
BEGIN
	DELETE FROM Phones WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[GetPhones]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetPhones]
AS
BEGIN
	SELECT p.*, b.ID AS BID, b.BrandName FROM Phones p
	INNER JOIN Brands b
	ON p.BrandID = b.ID
	ORDER BY BrandID,ProductName
END
GO
/****** Object:  StoredProcedure [dbo].[GetPhonesForSale]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetPhonesForSale]
AS
BEGIN
	SELECT p.*, b.ID AS BID, b.BrandName FROM Phones p
	INNER JOIN Brands b
	ON p.BrandID = b.ID
	WHERE p.InCart = 1
	ORDER BY BrandID,ProductName
END
GO
/****** Object:  StoredProcedure [dbo].[InsertPhone]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPhone]
@ProductName nvarchar(150), @Price decimal(18,2),@IMEI1 nvarchar(50),@IMEI2 nvarchar(50),@BrandID int, @ModelCode nvarchar(50)
AS
BEGIN
	INSERT INTO Phones (ProductName,Price, IMEI1, IMEI2, BrandID,ModelCode) VALUES (@ProductName,@Price,@IMEI1,@IMEI2,@BrandID,@ModelCode)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertPhoneCase]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPhoneCase]
@ProductName nvarchar(150), @Price decimal(18,2),@StockQTY int, @CaseColor int
AS
BEGIN
	INSERT INTO PhoneCase (ProductName,Price, Qty, CaseColor ) VALUES (@ProductName,@Price,@StockQTY,@CaseColor)
END

GO
/****** Object:  StoredProcedure [dbo].[RemoveFromCart]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RemoveFromCart]
@ID int
AS
BEGIN
	UPDATE Phones SET InCart = 1 WHERE Phones.ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[SearchPhone]    Script Date: 2.1.2019 14:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchPhone]
@BID int, @ModelCode nvarchar(50)
AS
BEGIN
SELECT * 
FROM Phones p
INNER JOIN Brands b
ON b.ID = p.BrandID 
WHERE (P.BrandID = @BID OR @BID=0) AND 
(p.ModelCode LIKE '%'+@ModelCode+'%' OR @ModelCode ='')
END
GO
