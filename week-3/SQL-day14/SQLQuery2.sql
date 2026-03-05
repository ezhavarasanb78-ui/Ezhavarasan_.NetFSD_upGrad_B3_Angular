use day3;
CREATE TABLE customers(
customer_id INT PRIMARY KEY,
first_name VARCHAR(30),
last_name VARCHAR(30)
);
CREATE TABLE orders(
order_id INT PRIMARY KEY,
customer_id INT,
order_value DECIMAL(10,2),
FOREIGN KEY(customer_id) REFERENCES customers(customer_id)
);
INSERT INTO orders VALUES
(101,1,6000),
(102,1,5000),
(103,2,3000),
(104,2,1000),
(105,3,12000);
INSERT INTO customers VALUES
(1,'Arun','Kumar'),
(2,'Rahul','Sharma'),
(3,'Priya','Singh'),
(4,'Karan','Verma'),
(5,'Neha','Patel');

select * from customers;
select * from orders;

SELECT CONCAT(c.first_name,' ',c.last_name) AS full_name, t.total_value,
CASE
WHEN t.total_value > 10000 THEN 'Premium'
WHEN t.total_value BETWEEN 5000 AND 10000 THEN 'Regular'
ELSE 'Basic'
END AS customer_type
FROM customers c
JOIN (SELECT customer_id, SUM(order_value) AS total_value FROM orders GROUP BY customer_id) t
ON c.customer_id = t.customer_id
UNION
SELECT CONCAT(first_name,' ',last_name), NULL, 'No Orders' FROM customers WHERE customer_id NOT IN (SELECT customer_id FROM orders);