use day2;
CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(50)
);
CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50)
);
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),
    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);
INSERT INTO brands VALUES
(1, 'Nike'),
(2, 'Adidas'),
(3, 'Puma');
INSERT INTO categories VALUES
(1, 'Shoes'),
(2, 'T-Shirts'),
(3, 'Accessories');
INSERT INTO products VALUES
(101, 'Air Max', 1, 1, 2024, 750),
(102, 'Running Pro', 2, 1, 2023, 450),
(103, 'Sports Tee', 2, 2, 2024, 550),
(104, 'Cap Classic', 3, 3, 2022, 300),
(105, 'Ultra Boost', 1, 1, 2025, 1200);
select *from products;

select p.product_name,b.brand_name,c.category_name,p.model_year,p.list_price
from products p
inner join brands b
on p.brand_id=p.brand_id
inner join categories c
on p.category_id=c.category_id
where p.list_price>500
order by p.list_price asc;