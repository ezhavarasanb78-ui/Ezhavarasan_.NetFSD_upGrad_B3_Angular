create database day34;
use day34;

CREATE TABLE Courses (
    cId INT PRIMARY KEY IDENTITY(1,1),
    cName NVARCHAR(100) NOT NULL
);

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    cId INT,
    FOREIGN KEY (cId) REFERENCES Courses(cId)
);