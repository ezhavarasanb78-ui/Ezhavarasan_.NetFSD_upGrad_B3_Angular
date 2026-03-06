create database day4;
use day4

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(100) NOT NULL
);
CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(100) NOT NULL
);
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(150) NOT NULL,
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),

    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);
CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    city VARCHAR(50),
    phone VARCHAR(15),
    email VARCHAR(100)
);
CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100),
    city VARCHAR(50),
    phone VARCHAR(15)
);

INSERT INTO categories VALUES
(1,'Cars'),
(2,'Bikes'),
(3,'SUV'),
(4,'Trucks'),
(5,'Electric Vehicles');
INSERT INTO brands VALUES
(1,'Toyota'),
(2,'Honda'),
(3,'Tesla'),
(4,'Ford'),
(5,'Hyundai');
INSERT INTO products VALUES
(1,'Toyota Camry',1,1,2023,30000),
(2,'Honda Civic',2,1,2023,25000),
(3,'Tesla Model 3',3,5,2024,45000),
(4,'Ford F150',4,4,2023,40000),
(5,'Hyundai Creta',5,3,2024,28000);
INSERT INTO customers VALUES
(1,'Arun','Kumar','Chennai','9876543210','arun@gmail.com'),
(2,'Ravi','Sharma','Hyderabad','9876543211','ravi@gmail.com'),
(3,'Priya','Reddy','Hyderabad','9876543212','priya@gmail.com'),
(4,'Karthik','Raj','Bangalore','9876543213','karthik@gmail.com'),
(5,'Sneha','Mohan','Chennai','9876543214','sneha@gmail.com');
INSERT INTO stores VALUES
(1,'AutoHub Chennai','Chennai','9000011111'),
(2,'AutoHub Hyderabad','Hyderabad','9000022222'),
(3,'AutoHub Bangalore','Bangalore','9000033333'),
(4,'AutoHub Mumbai','Mumbai','9000044444'),
(5,'AutoHub Delhi','Delhi','9000055555');

select * from customers 
where city='chennai';

select p.product_name,b.brand_name,c.category_name 
from products p
join brands b
on p.brand_id=b.brand_id
join categories c
on p.category_id=c.category_id;

select c.category_name,
count(p.product_id) as total
from categories c
join products p
on c.category_id=p.category_id
group by category_name;