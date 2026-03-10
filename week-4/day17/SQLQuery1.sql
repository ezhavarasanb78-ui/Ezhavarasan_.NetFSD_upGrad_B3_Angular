create database day7;
use day7;
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    stock_quantity INT,
    price DECIMAL(10,2)
);
CREATE TABLE orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    order_date DATETIME,
    order_status INT
);
CREATE TABLE order_items (
    order_item_id INT IDENTITY(1,1) PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

INSERT INTO products VALUES
(1, 'Car Battery', 20, 5000),
(2, 'Brake Pad', 15, 2000),
(3, 'Engine Oil', 30, 800);

create trigger prod on order_items
after insert
as 
BEGIN 
   if exists(
       select 1 from products p join inserted i on p.product_id=i.product_id
       where p.stock_quantity<i.quantity
       )
       BEGIN
       RAISERROR('insuffficient stock',16,1);
       rollback transaction
       return;
       end

    update p
    SET p.stock_quantity=p.stock_quantity-i.quantity
    from products p
    join inserted i
    on p.product_id=i.product_id;

end;

BEGIN TRANSACTION;

DECLARE @order_id INT;
INSERT INTO orders(customer_id, order_date, order_status)
VALUES (101, GETDATE(), 1);

SET @order_id = SCOPE_IDENTITY();
INSERT INTO order_items(order_id, product_id, quantity)
VALUES (@order_id, 1, 3);

COMMIT TRANSACTION;

select * from orders ;
