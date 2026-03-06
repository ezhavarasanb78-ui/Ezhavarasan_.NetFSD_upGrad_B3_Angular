use day4;
create view prod 
as
select p.product_name,b.brand_name,c.category_name
from products p
join brands b
on p.brand_id=b.brand_id
join categories c
on c.category_id=p.category_id;

select * from prod;

create index new1 on products(product_id);
select * from new1;

create index new2
on products(category_id);

create index new3
on customers(customer_id);
