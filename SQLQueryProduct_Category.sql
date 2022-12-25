CREATE TABLE Categories
(
   id INT IDENTITY primary key,
   CategoryName nvarchar(50)
);

insert into Categories values 
('books'),
('presents'),
('cars');

CREATE TABLE Products
(
   id INT IDENTITY primary key,
   ProductName nvarchar(50)
);

insert into Products values 
('attack on titan'),
('bottle'),
('kia sport'),
('death note');


Create Table Product_Category
(
    ProductId int  foreign key references Products(id),
    CategoryId int foreign key references Categories(id)
);

insert into Product_Category values
(1,1),
(2,2),
(3,3);


SELECT product.ProductName, categories.CategoryName
FROM Products product
   left JOIN Product_Category pc
      on product.id = pc.ProductId
   left join Categories categories
      on categories.id = pc.CategoryId
ORDER BY product.ProductName
