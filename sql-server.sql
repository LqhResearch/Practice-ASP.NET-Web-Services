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
    Role INT
)
GO

INSERT INTO tblUser VALUES 
(N'admin', '123', 'admin@gmail.com', N'Quản trị viên', N'Nam', 'vi', N'/assets/img/admin.png', 1, 1)
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
	Status BIT DEFAULT 0,
    Content NTEXT,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (ProductID) REFERENCES tblProduct (ProductID),
    FOREIGN KEY (Username) REFERENCES tblUser (Username)
)
GO

CREATE TABLE tblRating
(
	ProductID INT NOT NULL,
	Username NVARCHAR(64) NOT NULL,
	Star INT DEFAULT 0,

	PRIMARY KEY (ProductID, Username),
	FOREIGN KEY (ProductID) REFERENCES tblProduct (ProductID),
    FOREIGN KEY (Username) REFERENCES tblUser (Username)
)
GO