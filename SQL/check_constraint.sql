create table products(
Product_ID int identity primary key,
Product_name varchar(255)not null,
Unit_Price dec(10,3)check(Unit_Price >0))
select * from products
insert into products values('eisha',250)
insert into products values('miesha',1234567)
insert into products values('lisa',0)
drop table result
create table result(Rollno int  identity primary key,
marks int check(marks > 0))
select * from result
insert into result values(29)
insert into result values(0)
insert into result values(50)
insert into result values(1,30)
create table teacher(teacher_rollno int primary key,
teacher_name varchar(250))
insert into teacher values (1,'simta')
select * from teacher
insert into teacher values('shreya')
create table product1(product_id int identity primary key,product_name varchar(255) not null,
unit_price dec(10,2) constraint positive_price check(unit_price>0))
--sql server check constraint
select * from product1
insert into  product1 values('sara',0)
insert into products(Product_name,Unit_Price)
values('bikecycle',null)
----check costraint into multiple coloumn
create table product2(product_id int identity primary key,product_name varchar(300),
unit_price dec(10,2) constraint unitprice check(unit_price>0),
discount_price dec(10,2) constraint disprice check(discount_price >0),
check(discount_price<unit_price))

select * from product2
insert into product3 values(120,21)
insert into product2 values('ipad',12,22)
insert into product2 values('keyboard',0,0)
-----another way of writing coloumn constraint
create table product3(id int identity primary key,
unit_price dec(10,2),
discount_price dec(10,2),
check(unit_price>0),
check(discount_price>0),
check(unit_price>discount_price))
select * from product3
-----------OR
CREATE TABLE product4(id int identity primary key,
unit_price dec(10,2),
discount_price dec(10,2),
check(unit_price>0)
,check(discount_price>0 AND unit_price>discount_price))

select * from product4
insert into product4 values(220,90)
insert into product4 values(20,200)
---------table constraint----------
create table test.products(
Product_id int identity primary key,
unit_price dec(10,2),
discount_price dec(10,2),
check(unit_price>0),
check(discount_price>0),
constraint validate_price check(unit_price>discount_price));
---add check constraint--
create table product5( product_id int identity primary key,
product_name varchar(200) not null,
unit_price dec(10,2))
select * from product5
alter table product5
add constraint positive_pricing check(unit_price>0)

insert into product5 values('nisha',20)
---------to add new coloumn ----
alter table product5
add discount_price dec(10,2)
check(discount_price>0)

----to check structure of table---
alter table product5
add constraint validating_price
check(unit_price>discount_price)


insert into product5 values('mala',255,29)


----------remove check constraint-----------
alter table product5
drop constraint validating_price;

EXEC sp_help 'product5'













































































