use day6;
CREATE TABLE stores(
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);
CREATE TABLE customers(
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(100)
);
CREATE TABLE products(
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    list_price DECIMAL(10,2)
);
CREATE TABLE orders(
    order_id INT PRIMARY KEY,
    customer_id INT,
    store_id INT,
    order_date DATE,
    order_status INT,
    
    FOREIGN KEY(customer_id) REFERENCES customers(customer_id),
    FOREIGN KEY(store_id) REFERENCES stores(store_id)
);

CREATE TABLE order_items(
    item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(4,2),

    FOREIGN KEY(order_id) REFERENCES orders(order_id),
    FOREIGN KEY(product_id) REFERENCES products(product_id)
);
INSERT INTO stores VALUES
(1,'Chennai Store'),
(2,'Bangalore Store');
INSERT INTO customers VALUES
(101,'Arun'),
(102,'Kumar'),
(103,'Ravi');
INSERT INTO products VALUES
(1,'Laptop',50000),
(2,'Mobile',20000),
(3,'Headphones',2000),
(4,'Keyboard',1500),
(5,'Mouse',800);
INSERT INTO orders VALUES
(1,101,1,'2023-01-10',1),
(2,102,1,'2023-02-15',1),
(3,103,2,'2023-03-20',1);
INSERT INTO order_items VALUES
(1,1,1,1,50000,0.10),
(2,1,3,2,2000,0.05),
(3,2,2,1,20000,0.08),
(4,3,4,3,1500,0.05),
(5,3,5,2,800,0.02);

create procedure totsal
as
BEGIN
   select s.store_id,s.store_name,
   sum(oi.quantity*oi.list_price) as total_sales
   from stores s
   join orders o
   on s.store_id=o.store_id
   join order_items oi on o.order_id=oi.order_id
   group by s.store_id,s.store_name;
END;

exec totsal;

create procedure Getdays
@startdate date,
@enddate date
as
BEGIN 
   select * from orders
   where order_date between @startdate AND @enddate;
END;

EXEC Getdays'2023-01-01','2023-12-31';

create function sellprod()
returns table
as
return
(
  select top 5 
  p.product_id,p.product_name,
  sum(oi.quantity) as totsol
  from products p
  join order_items oi
  on p.product_id=oi.product_id
  group by p.product_id,p.product_name
  order by totsol desc
  );

  select * from sellprod();