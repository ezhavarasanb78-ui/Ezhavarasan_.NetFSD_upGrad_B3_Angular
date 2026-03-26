create database day27;
use day27;
CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Productname VARCHAR(50),
    Price FLOAT
);

select * from Products;