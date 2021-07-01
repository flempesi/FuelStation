--USE FuelStation

--DROP  TABLE  [Customer]
CREATE TABLE [Customer]
(
    [ID] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
    [Surname] [nvarchar](150) NOT NULL,
    [CardNumber] [nvarchar](50) NOT NULL
) ON [PRIMARY]

--SELECT * FROM [Customer]

--DROP  TABLE  [Employee]

CREATE TABLE [Employee]
(
    [ID] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
    [Surname] [nvarchar](150) NOT NULL,
    [DateStart] [datetime] NOT NULL,
    [DateEnd] [datetime] NULL,
    [Salary] [decimal](18, 2) NOT NULL
) ON [PRIMARY]


--SELECT * FROM [Employee]


--DROP  TABLE  [Item]
CREATE TABLE [dbo].[Item](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	[ItemType] [smallint] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Cost] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
--SELECT * FROM [Item]


--DROP  TABLE  [Transaction]
CREATE TABLE [Transaction]
(
    [ID] [uniqueidentifier] NOT NULL,
    [Date] [datetime] NOT NULL,
    [CustomerID] [uniqueidentifier] NOT NULL,
    [DiscountValue] [decimal](18, 2) NOT NULL,
    [TotalValue] [decimal](18, 2) NOT NULL,
    [TotalCost] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
--SELECT * FROM [Transaction]



--DROP  TABLE  [TransactionLine]
CREATE TABLE [TransactionLine]
(
    [ID] [uniqueidentifier] NOT NULL,
    [TransactionID] [uniqueidentifier] NOT NULL,
    [ItemID] [uniqueidentifier] NOT NULL,
    [Quantity] [decimal](18, 2) NOT NULL,
    [ItemPrice] [decimal](18, 2) NOT NULL,
    [Value] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
--SELECT * FROM [TransactionLine]