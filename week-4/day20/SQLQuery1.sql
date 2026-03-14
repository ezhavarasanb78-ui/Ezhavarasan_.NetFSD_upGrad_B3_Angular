create database study;
use study;
CREATE TABLE Books (
    BookID  INT IDENTITY(1,1) PRIMARY KEY,
    Title   NVARCHAR(150) NOT NULL,
    Stock   INT NOT NULL CHECK (Stock >= 0),
    Price   DECIMAL(10,2) NOT NULL
);

CREATE TABLE Orders (
    OrderID    INT IDENTITY(1,1) PRIMARY KEY,
    BookID     INT NOT NULL,
    Quantity   INT NOT NULL CHECK (Quantity > 0),
    OrderDate  DATETIME2 DEFAULT SYSDATETIME(),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

create procedure addbook
@title NVARCHAR(150),@stock INT,@price decimal(10,2)
as
begin
begin try
     insert into Books(Title,Stock,Price)values(@title,@stock,@price);
     print 'book added successfully';
end try
begin catch
      print 'error';
end catch
end;


create procedure placeorder
@bookid int,@quantity int
as 
begin
 begin try
   begin transaction
       if not exists( select 1 from Books where BookID=@bookid and Stock>=@quantity)
       begin 
        raiserror('not enough stock avaialble',16,1);
        end
    update Books
     set Stock=Stock-@quantity
     where BookID=@bookid;

     insert into Orders(BookID,Quantity)values(@bookid,@quantity);

     commit transaction;
     print 'order places suucessfully';
 end try
 begin catch
    print 'error';
   end catch
end;

EXEC addbook'SQL Basics', 10, 450.00;

select * from Books;
EXEC placeorder 1, 2;