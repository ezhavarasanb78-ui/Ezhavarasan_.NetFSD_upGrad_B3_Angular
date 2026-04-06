create database day35;
use day35;
CREATE TABLE Company (
    cId INT IDENTITY(1,1) PRIMARY KEY,
    CompanyName NVARCHAR(100) NOT NULL
);
CREATE TABLE Department (
    dId INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName NVARCHAR(100) NOT NULL
);

CREATE TABLE ContactInfo (
    ContactId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50),
    EmailId NVARCHAR(100),
    MobileNo BIGINT,
    Designation NVARCHAR(50),

    CompanyId INT NOT NULL,
    DepartmentId INT NULL,

    CONSTRAINT FK_Contact_Company 
        FOREIGN KEY (CompanyId) 
        REFERENCES Company(cId),

    CONSTRAINT FK_Contact_Department 
        FOREIGN KEY (DepartmentId) 
        REFERENCES Department(dId)
);