CREATE DATABASE Shop
GO

USE Shop
GO

CREATE TABLE tblUser
(
    Username NVARCHAR(64) NOT NULL PRIMARY KEY,
    Password VARCHAR(64) NOT NULL,
    Email VARCHAR(64),
    Fullname NVARCHAR(64),
    Gender NVARCHAR(5),
    Locale VARCHAR(8),
    Avatar NVARCHAR(255),
    Status BIT,
    Role BIT
)
GO

CREATE TABLE tblProduct
(
    ProductID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ProductName NVARCHAR(255),
    Price INT,
    Thumbnail NVARCHAR(255)
)
GO

CREATE TABLE tblComment
(
    CommentID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ProductID INT NOT NULL,
    Username NVARCHAR(64) NOT NULL,
    StarNumber INT,
    Content NTEXT,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (ProductID) REFERENCES tblProduct (ProductID),
    FOREIGN KEY (Username) REFERENCES tblUser (Username)
)
GO