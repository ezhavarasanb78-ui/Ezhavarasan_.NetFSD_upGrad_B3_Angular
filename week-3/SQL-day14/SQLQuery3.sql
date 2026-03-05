use day3;
CREATE TABLE stores(
store_id INT PRIMARY KEY,
store_name VARCHAR(50)
);

CREATE TABLE product_details(
product_id INT PRIMARY KEY,
product_name VARCHAR(50),
list_price DECIMAL(10,2)
);

CREATE TABLE stocks(
store_id INT,
product_id INT,
quantity INT
);

CREATE TABLE sales_orders(
order_id INT PRIMARY KEY,
store_id INT
);

CREATE TABLE order_items(
order_id INT,
product_id INT,
quantity INT,
list_price DECIMAL(10,2),
discount DECIMAL(10,2)
);

INSERT INTO stores VALUES
(1,'Chennai Store'),
(2,'Madurai Store');
INSERT INTO product_details VALUES
(101,'Honda Bike',80000),
(102,'Yamaha R15',150000),
(103,'KTM Duke',200000);
INSERT INTO stocks VALUES
(1,101,5),
(1,102,0),
(2,101,2),
(2,103,0);
INSERT INTO sales_orders VALUES
(1,1),
(2,2);
INSERT INTO order_items VALUES
(1,101,2,80000,1000),
(1,102,1,150000,2000),
(2,103,1,200000,5000);
SELECT store_id, product_id
FROM order_items oi
JOIN sales_orders so
ON oi.order_id = so.order_id

EXCEPT

SELECT store_id, product_id
FROM stocks
WHERE quantity > 0;

SELECT s.store_name,
p.product_name,
SUM(oi.quantity) AS total_sold,
SUM((oi.quantity * oi.list_price) - oi.discount) AS revenue
FROM sales_orders so
JOIN order_items oi ON so.order_id = oi.order_id
JOIN stores s ON so.store_id = s.store_id
JOIN product_details p ON oi.product_id = p.product_id
GROUP BY s.store_name, p.product_name;