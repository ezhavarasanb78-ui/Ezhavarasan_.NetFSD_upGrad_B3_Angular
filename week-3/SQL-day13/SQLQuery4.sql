
CREATE TABLE productso (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100)
);
CREATE TABLE storeso (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);
CREATE TABLE stocks (
    store_id INT,
    product_id INT,
    quantity INT,
    PRIMARY KEY (store_id, product_id),
    FOREIGN KEY (store_id) REFERENCES storeso(store_id),
    FOREIGN KEY (product_id) REFERENCES productso(product_id)
);
CREATE TABLE ordero_items (
    item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    FOREIGN KEY (product_id) REFERENCES productso(product_id)
);

INSERT INTO productso VALUES
(1, 'Laptop'),
(2, 'Mobile'),
(3, 'Tablet');
INSERT INTO storeso VALUES
(1, 'Chennai Store'),
(2, 'Madurai Store');
INSERT INTO stocks VALUES
(1, 1, 50),   
(1, 2, 30),   
(2, 1, 20),   
(2, 3, 40);   

INSERT INTO ordero_items VALUES
(1, 101, 1, 5),   
(2, 102, 1, 3),   
(3, 103, 2, 10);  

select * from stocks;

SELECT 
    p.product_name,
    s.store_name,
    st.quantity AS available_stock,
    ISNULL(SUM(oi.quantity), 0) AS total_quantity_sold
FROM stocks st
INNER JOIN productso p
    ON st.product_id = p.product_id
INNER JOIN storeso s
    ON st.store_id = s.store_id
LEFT JOIN ordero_items oi
    ON st.product_id = oi.product_id
GROUP BY 
    p.product_name,
    s.store_name,
    st.quantity
ORDER BY 
    p.product_name;