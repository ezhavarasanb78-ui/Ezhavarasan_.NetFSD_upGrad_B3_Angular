create database day26;
use day26;

CREATE TABLE Products (
    Productid INT IDENTITY(1,1) PRIMARY KEY,
    Productname VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

create procedure inspro
 @Productname varchar(20),@Category varchar(50),@Price decimal(10,2)
 as
 begin
 set nocount on;
 insert into Products(Productname,Category,Price)Values(@Productname,@Category,@Price);
 end

 create procedure getall
 as
 begin
 select * from Products;
 end

 create procedure getid
 @Productid int
 as begin
 select Productid,Productname,Category,Price
 from Products where Productid=@Productid;
 end

 create procedure updall
 @productid int,@productname varchar(20),@Category varchar(50),@Price decimal(10,2)
 as
 begin
 update Products
  set Productname=@productname,Category=@Category,Price=@Price
  where Productid=@productid;
end

create procedure delall
@Productid int
as
begin
delete from Products
where Productid=@Productid;
end
