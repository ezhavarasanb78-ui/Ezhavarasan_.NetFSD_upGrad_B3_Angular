use day7;
CREATE TABLE Pr
(
    productid INT PRIMARY KEY,
    productname VARCHAR(50),
    stockqty INT
);

CREATE TABLE ord
(
    orderid INT PRIMARY KEY,
    orderstatus INT
);

CREATE TABLE OrderItems
(
    itemid INT PRIMARY KEY,
    orderid INT,
    productid INT,
    quantity INT
);

INSERT INTO Pr VALUES
(1,'Laptop',10),
(2,'Mouse',20),
(3,'Keyboard',15);

INSERT INTO ord VALUES
(101,4),
(102,4);

INSERT INTO OrderItems VALUES
(1,101,1,2),
(2,101,2,3),
(3,102,3,1);

create procedure can
@orderid INT
as
BEGIN
BEGIN TRY
    BEGIN transaction
    save transaction RestorePoint;
    update p
    set p.stockqty=p.stockqty+OI.quantity
    from pr p join OrderItems OI
    on p.productid=OI.productid
    where OI.orderid=@orderid;
     UPDATE ord
    SET orderstatus = 3
    WHERE orderid = @orderid;

    COMMIT TRANSACTION;

    PRINT 'Order cancelled and stock restored successfully';

END TRY

BEGIN CATCH

    PRINT 'Error occurred';

    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION RestorePoint;
        ROLLBACK TRANSACTION;
    END

    PRINT ERROR_MESSAGE();

END CATCH
END;

exec can 101;

select * from pr;
select * from ord;