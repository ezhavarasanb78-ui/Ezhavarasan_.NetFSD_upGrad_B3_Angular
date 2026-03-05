create database day3;
use day3;
CREATE TABLE categories(
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50)
);
CREATE TABLE products(
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50),
    model_year INT,
    list_price DECIMAL(10,2),
    category_id INT,
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);
INSERT INTO categories VALUES
(1,'Cars'),
(2,'Bikes'),
(3,'Trucks');
INSERT INTO products VALUES
(1,'Honda Civic',2017,20000,1),
(2,'Toyota Corolla',2018,22000,1),
(3,'BMW X5',2019,50000,1),
(4,'Yamaha R15',2018,4000,2),
(5,'Royal Enfield',2019,6000,2),
(6,'KTM Duke',2020,5500,2),
(7,'Ford F150',2018,30000,3),
(8,'Tata Truck',2019,25000,3),
(9,'Volvo Truck',2020,45000,3);

select * from products;

select concat(p.product_name,'(',p.model_year,')') as prod,
p.list_price,
p.list_price-c.avgpr as prdif
from products p
join(
     select category_id,AVG(list_price) as avgpr
     from products 
     group by category_id)
     c
on p.category_id=c.category_id
where p.list_price>c.avgpr;