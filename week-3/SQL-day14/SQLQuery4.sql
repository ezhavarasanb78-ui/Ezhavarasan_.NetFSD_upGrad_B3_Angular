use day3;
CREATE TABLE client_details(
client_id INT PRIMARY KEY,
first_name VARCHAR(30),
last_name VARCHAR(30)
);

CREATE TABLE customer_orders(
order_id INT PRIMARY KEY,
client_id INT,
order_status INT,
order_date DATE,
required_date DATE,
shipped_date DATE,
FOREIGN KEY(client_id) REFERENCES client_details(client_id)
);

CREATE TABLE archived_orders(
order_id INT,
client_id INT,
order_status INT,
order_date DATE
);

INSERT INTO client_details VALUES
(1,'Arun','Kumar'),
(2,'Rahul','Sharma'),
(3,'Priya','Singh');

INSERT INTO customer_orders VALUES
(101,1,1,'2023-01-10','2023-01-15','2023-01-14'),
(102,1,3,'2022-02-10','2022-02-15','2022-02-16'),
(103,2,2,'2024-03-01','2024-03-05','2024-03-06'),
(104,3,3,'2021-04-10','2021-04-15','2021-04-20');

INSERT INTO archived_orders
SELECT order_id, client_id, order_status, order_date
FROM customer_orders
WHERE order_status = 3;
DELETE FROM customer_orders
WHERE order_status = 3
AND order_date < DATEADD(YEAR,-1,GETDATE());

SELECT client_id
FROM client_details
WHERE client_id NOT IN
(
SELECT client_id
FROM customer_orders
WHERE order_status <> 2
);