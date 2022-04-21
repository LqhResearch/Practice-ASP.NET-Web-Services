CREATE DATABASE QLHV
GO

USE QLHV
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