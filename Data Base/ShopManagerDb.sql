USE [StoreDB]
GO
/****** Object:  Table [dbo].[BuyingOrders]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyingOrders](
	[BuysId] [int] IDENTITY(1,1) NOT NULL,
	[BuysSupplierId] [int] NOT NULL,
	[BuysProductTypeId] [int] NOT NULL,
	[BuysProductId] [int] NOT NULL,
	[BuysQuantity] [int] NOT NULL,
	[BuysUnitPrice] [decimal](10, 2) NOT NULL,
	[BuysTotal] [decimal](10, 2) NOT NULL,
	[BuysDate] [datetime] NOT NULL,
	[BuysState] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BuysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [varchar](100) NOT NULL,
	[ClientLastName] [varchar](100) NOT NULL,
	[ClientEmail] [varchar](100) NOT NULL,
	[ClientDUI] [varchar](20) NOT NULL,
	[ClientTelephone] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Names] [varchar](100) NOT NULL,
	[LastNames] [varchar](100) NOT NULL,
	[UserEmployee] [varchar](50) NOT NULL,
	[PasswordEmployee] [varchar](255) NOT NULL,
	[DUI] [varchar](20) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[ProductBrand] [varchar](50) NOT NULL,
	[ProductModel] [varchar](50) NOT NULL,
	[ProductVersion] [varchar](50) NOT NULL,
	[ProductColor] [varchar](50) NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[ProductAmount] [int] NOT NULL,
	[Availability] [bit] NULL,
	[ImageUrl] [nvarchar](2083) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[ProductTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategory] [varchar](50) NOT NULL,
	[CategoryDescription] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleType] [varchar](50) NOT NULL,
	[RoleDescription] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[SaleClientId] [int] NOT NULL,
	[SaleProductId] [int] NOT NULL,
	[QuantitySold] [int] NOT NULL,
	[PaymentMethod] [varchar](50) NULL,
	[TotalAmount] [decimal](10, 2) NOT NULL,
	[SaleDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 19/11/2024 11:49:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](100) NOT NULL,
	[SupplierPhone] [varchar](100) NOT NULL,
	[SupplierEmail] [varchar](100) NOT NULL,
	[SupplierAddres] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [Names], [LastNames], [UserEmployee], [PasswordEmployee], [DUI], [Email], [RoleId]) VALUES (10, N'josue ivan', N'beltran campos', N'admin', N'1234', N'35435345', N'ivan@gamil.com', 1)
INSERT [dbo].[Employees] ([EmployeeId], [Names], [LastNames], [UserEmployee], [PasswordEmployee], [DUI], [Email], [RoleId]) VALUES (14, N'marisol', N'lazo', N'paty', N'234', N'5405023', N'pary@gmail.com', 1)
INSERT [dbo].[Employees] ([EmployeeId], [Names], [LastNames], [UserEmployee], [PasswordEmployee], [DUI], [Email], [RoleId]) VALUES (22, N'estefany ', N'guadalupe', N'fany', N'1234', N'464252', N'fany@gmail.com', 2)
INSERT [dbo].[Employees] ([EmployeeId], [Names], [LastNames], [UserEmployee], [PasswordEmployee], [DUI], [Email], [RoleId]) VALUES (1036, N'kevin', N'cruzito', N'cruz12', N'1234', N'53425235', N'kevinsito@gmial.com', 2)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductTypeId], [ProductBrand], [ProductModel], [ProductVersion], [ProductColor], [ProductPrice], [ProductAmount], [Availability], [ImageUrl]) VALUES (45, 2, N'dell', N'envy36', N'dgdrs', N'azul', 800, 0, 0, N'ProductsIMG\5037604009933909477.jpg')
INSERT [dbo].[Products] ([ProductId], [ProductTypeId], [ProductBrand], [ProductModel], [ProductVersion], [ProductColor], [ProductPrice], [ProductAmount], [Availability], [ImageUrl]) VALUES (47, 3, N'samsung', N'note 21', N'csfge', N'negro', 900, 0, 0, N'ProductsIMG\5037604009933909475.jpg')
INSERT [dbo].[Products] ([ProductId], [ProductTypeId], [ProductBrand], [ProductModel], [ProductVersion], [ProductColor], [ProductPrice], [ProductAmount], [Availability], [ImageUrl]) VALUES (48, 5, N'asus', N'monitor12', N'dvdts', N'gris', 344, 0, 0, N'ProductsIMG\5037604009933909479.jpg')
INSERT [dbo].[Products] ([ProductId], [ProductTypeId], [ProductBrand], [ProductModel], [ProductVersion], [ProductColor], [ProductPrice], [ProductAmount], [Availability], [ImageUrl]) VALUES (49, 4, N'apple', N'ipad', N'promax', N'negro', 4322, 0, 0, N'ProductsIMG\5037604009933909476.jpg')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductType] ON 

INSERT [dbo].[ProductType] ([ProductTypeId], [ProductCategory], [CategoryDescription]) VALUES (1, N'Ordenadores', N'Ordenador de escritorio de alto rendimiento')
INSERT [dbo].[ProductType] ([ProductTypeId], [ProductCategory], [CategoryDescription]) VALUES (2, N'Laptops', N'Laptop ligera y portátil con alta duración de batería')
INSERT [dbo].[ProductType] ([ProductTypeId], [ProductCategory], [CategoryDescription]) VALUES (3, N'Moviles', N'Smartphone con pantalla AMOLED y cámara de 108MP')
INSERT [dbo].[ProductType] ([ProductTypeId], [ProductCategory], [CategoryDescription]) VALUES (4, N'Tablets', N'Tablet con lápiz digital y pantalla de alta resolución')
INSERT [dbo].[ProductType] ([ProductTypeId], [ProductCategory], [CategoryDescription]) VALUES (5, N'Accesorios', N'Auriculares inalámbricos con cancelación de ruido')
SET IDENTITY_INSERT [dbo].[ProductType] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleType], [RoleDescription]) VALUES (1, N'gerente', N'usuario encargado de administradar todo')
INSERT [dbo].[Roles] ([RoleId], [RoleType], [RoleDescription]) VALUES (2, N'cajero', N'usuario encargado solo de vender')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clients__AD48A6FFBF08F034]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[Clients] ADD UNIQUE NONCLUSTERED 
(
	[ClientEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clients__E66AD785F9CE9840]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[Clients] ADD UNIQUE NONCLUSTERED 
(
	[ClientDUI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__4B224B3DA36197D9]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[Employees] ADD UNIQUE NONCLUSTERED 
(
	[UserEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__A9D10534B2DBEA93]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[Employees] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__C03671B9FEBCE377]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[Employees] ADD UNIQUE NONCLUSTERED 
(
	[DUI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_User]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [UQ_User] UNIQUE NONCLUSTERED 
(
	[UserEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_ProductUnique]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [UQ_ProductUnique] UNIQUE NONCLUSTERED 
(
	[ProductBrand] ASC,
	[ProductModel] ASC,
	[ProductVersion] ASC,
	[ProductColor] ASC,
	[ProductPrice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ProductT__3A113311CFE5634A]    Script Date: 19/11/2024 11:49:29 p. m. ******/
ALTER TABLE [dbo].[ProductType] ADD UNIQUE NONCLUSTERED 
(
	[ProductCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_ProductAmount_Default]  DEFAULT ((0)) FOR [ProductAmount]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Availability_Default]  DEFAULT ((0)) FOR [Availability]
GO
ALTER TABLE [dbo].[BuyingOrders]  WITH CHECK ADD FOREIGN KEY([BuysProductTypeId])
REFERENCES [dbo].[ProductType] ([ProductTypeId])
GO
ALTER TABLE [dbo].[BuyingOrders]  WITH CHECK ADD FOREIGN KEY([BuysProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[BuyingOrders]  WITH CHECK ADD FOREIGN KEY([BuysSupplierId])
REFERENCES [dbo].[Suppliers] ([SupplierId])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductType] ([ProductTypeId])
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([SaleClientId])
REFERENCES [dbo].[Clients] ([ClientId])
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([SaleProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
