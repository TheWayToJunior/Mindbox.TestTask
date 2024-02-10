IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'testdb')
BEGIN
    ALTER DATABASE testdb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE testdb;
END

CREATE DATABASE testdb;
GO

USE testdb;
GO

CREATE TABLE dbo.Products(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Name NVARCHAR(120) NOT NULL,
	CreatedDate DATETIME NOT NULL,
	UpdatedDate DATETIME NOT NULL,

	INDEX IX_Name (Name)
	);
GO

INSERT INTO Products(Name, CreatedDate, UpdatedDate) VALUES ('Product 1', GETDATE(), GETDATE());
INSERT INTO Products(Name, CreatedDate, UpdatedDate) VALUES ('Product 2', GETDATE(), GETDATE());
INSERT INTO Products(Name, CreatedDate, UpdatedDate) VALUES ('Product 3', GETDATE(), GETDATE());
GO

CREATE TABLE dbo.Categories(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Name NVARCHAR(120) NOT NULL,
	CreatedDate DATETIME NOT NULL,
	UpdatedDate DATETIME NOT NULL,

	CONSTRAINT UC_Name UNIQUE (Name),
	);
GO

INSERT INTO Categories(Name, CreatedDate, UpdatedDate) VALUES ('Category 1', GETDATE(), GETDATE());
INSERT INTO Categories(Name, CreatedDate, UpdatedDate) VALUES ('Category 2', GETDATE(), GETDATE());
GO

CREATE TABLE dbo.ProductsCategories(
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL,
	CreatedDate DATETIME NOT NULL,
	UpdatedDate DATETIME NOT NULL,

	PRIMARY KEY (ProductId, CategoryId),
    CONSTRAINT FK_ProductsCategories_Products FOREIGN KEY (ProductId) REFERENCES Products(Id),
    CONSTRAINT FK_ProductsCategories_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
	);
GO

INSERT INTO ProductsCategories(ProductId, CategoryId, CreatedDate, UpdatedDate) VALUES (1, 1, GETDATE(), GETDATE());
INSERT INTO ProductsCategories(ProductId, CategoryId, CreatedDate, UpdatedDate) VALUES (1, 2, GETDATE(), GETDATE());
INSERT INTO ProductsCategories(ProductId, CategoryId, CreatedDate, UpdatedDate) VALUES (2, 1, GETDATE(), GETDATE());
GO

SELECT * FROM Products
SELECT * FROM Categories
SELECT * FROM ProductsCategories

SELECT 
	P.Name AS 'ProductName ', 
	ISNULL(C.Name, 'Without a category') AS 'CategoryName',
	P.CreatedDate,
	P.UpdatedDate 
FROM
	Products AS P
LEFT JOIN 
	ProductsCategories AS PC ON PC.ProductId = P.Id
LEFT JOIN 
	Categories C ON PC.CategoryID = C.Id;