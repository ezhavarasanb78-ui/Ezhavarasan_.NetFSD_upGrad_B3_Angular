create database day2;
use day2;

create table customers (
    customerid int primary key,
    firstname varchar(50),
    lastname varchar(50)
);

CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    customerid INT,
    order_date DATE,
    order_status INT,
    FOREIGN KEY (customerid)
        REFERENCES customers(customerid)
);

select * from orders;


insert into customers values
(1, 'Arun', 'Kumar'),
(2, 'Priya', 'Sharma'),
(3, 'Rahul', 'Verma');
select * from customers;

insert into orders values
(101, 1, '2026-03-01', 1), 
(102, 2, '2026-02-28', 4),  
(103, 3, '2026-02-27', 2),  
(104, 1, '2026-03-03', 4),
(105, 2, '2026-03-02', 1);   
select * from orders;

select c.firstname,c.lastname,o.order_id,o.order_date,o.order_status from customers c 
inner join orders o on c.customerid=o.customerid
where o.order_status=1 or 
o.order_status=4
order by o.order_date desc; 