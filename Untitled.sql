CREATE TABLE [customer] (
  [customer_id] int PRIMARY KEY IDENTITY(1, 1),
  [name] nvarchar(50),
  [phone] nvarchar(50),
  [email_account] nvarchar(50),
  [password] nvarchar(255),
  [Address_city] nvarchar(255),
  [Address_local] nvarchar(255),
  [Address1_road] nvarchar(255),
  [created_at] timestamp
)
GO

CREATE TABLE Customer_Favorite (
  CustomerID int not NULL,
  StoreID int not NULL,
  CONSTRAINT pk_CustomerFavorite_Id PRIMARY KEY (CustomerID, StoreID)
)
GO



CREATE TABLE [store] (
  [store_id] int PRIMARY KEY IDENTITY(1, 1),
  [store_name] nvarchar(255),
  [store_class] nvarchar(255),
  [Address_city] nvarchar(255),
  [Address_local] nvarchar(255),
  [store_owner_name] nvarchar(255),
  [phone] nvarchar(255),
  [email_account] nvarchar(255),
  [password] nvarchar(255),
  [created_at] timestamp
)
GO

CREATE TABLE [store_business] (
  [store_id] int PRIMARY KEY,
  [storeAddress] decimal,
  [punch_start] datetime,
  [punch_end] datetime,
  [onBusiness] bit
)
GO

CREATE TABLE Store_Products (
  StoreID int,
  ProductID int IDENTITY(1001, 1),
  Product_Name nvarchar(50),
  Product_Price int,
  CONSTRAINT pk_StoreProducts_Id PRIMARY KEY (StoreID, ProductID)
)
GO

CREATE TABLE HotRank (
  StoreID int not null,
  Store_Name nvarchar(50),
  Click_Count int,
  CONSTRAINT pk_HotRank_Id PRIMARY KEY (StoreID)
)
GO

ALTER TABLE [customer] ADD FOREIGN KEY ([customer_id]) REFERENCES [customer_Favorite] ([customer_id])
GO

ALTER TABLE [store] ADD FOREIGN KEY ([store_id]) REFERENCES [store_business] ([store_id])
GO

ALTER TABLE [store] ADD FOREIGN KEY ([store_id]) REFERENCES [store_products] ([store_id])
GO

ALTER TABLE [store] ADD FOREIGN KEY ([store_id]) REFERENCES [customer_Favorite] ([store_id])
GO

ALTER TABLE [store] ADD FOREIGN KEY ([store_id]) REFERENCES [rank] ([store_id])
GO
