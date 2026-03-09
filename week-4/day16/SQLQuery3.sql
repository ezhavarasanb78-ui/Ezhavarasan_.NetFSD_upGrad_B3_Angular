CREATE TABLE orderso
(
    order_id INT PRIMARY KEY,
    order_status INT,
    order_date DATE,
    shipped_date DATE
);
INSERT INTO orderso VALUES
(1,1,'2024-03-01',NULL),
(2,2,'2024-03-02',NULL),
(3,3,'2024-03-03','2024-03-05');

create trigger ship
on orderso
after update
as
BEGIN 
   BEGIN TRY
   IF EXISTS(
      select * from inserted where order_status=4 AND shipped_date=NULL
      )
      BEGIN 
      raiserror('shipped date available when order is completed',16,1);
      rollback transaction;
      END
    END TRY

    BEGIN CATCH
      rollback transaction;
    END CATCH
END;
UPDATE orderso
SET order_status = 4
WHERE order_id = 2;
select * from orderso;