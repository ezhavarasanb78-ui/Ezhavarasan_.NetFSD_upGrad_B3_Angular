use day6;
CREATE TABLE stocks
(
    product_id INT PRIMARY KEY,
    quantity INT
);
INSERT INTO stocks VALUES
(1,50),
(2,40),
(3,60),
(4,30),
(5,25);

create trigger checkcond
on order_items
after insert
as
BEGIN

   if exists(
     select * from stocks s
       join inserted i on s.product_id=i.product_id
       where s.quantity<i.quantity
     )
    BEGIN 
     RAISERROR('STOCK NOT AVAILABLE',16,1);
     rollback transaction;
     return;
  END
 update s
 set s.quantity=s.quantity-i.quantity
 from stocks s
 join inserted i
 on s.product_id=i.product_id;
END;

INSERT into order_items values(7,2,1,5,50000,0);
select * from order_items;