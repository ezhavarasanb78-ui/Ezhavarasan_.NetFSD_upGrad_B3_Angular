create database day33;
use day33;

CREATE TABLE Movies (
    Id INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(100),
    Genre NVARCHAR(50),
    ReleaseDate DATETIME,
    Price DECIMAL(10,2),
    Rating NVARCHAR(10)
);
select * from Movies;