select * from customer
create table customer(cust_id int,cust_name varchar(20),cust_state varchar(20),cust_city varchar(20))
insert into customer values(2,'aisha','mah','nagpur')
insert into customer values(3,'chandu','mp','bhopal')
insert into customer values(4,'ayushi','mp','bhopal')
insert into  customer values(1,'alisha','mah','nagpur')
 
create table orders (order_id int,cust_id int, order_date date,product_name varchar(20),qty int)
select * from orders

exec sp_help customer
insert into orders values(1,2,'2012-2-2','mouse',2)
insert into orders values(2,3,'2013-3-12','keyboard',4)
insert into orders values(3,4,'2013-2-10','laptop',1)
insert into orders values(4,2,'2010-3-9','wire',5)
select cust_id,cust_city from customer  where cust_city='nagpur'

select * from orders
select * from customer
select order_id,cust_id,order_date,product_name,qty
from orders
where cust_id in
(select cust_id from customer where cust_city='bhopal') 

update orders
set cust_id=1 
where product_name='mouse';
select order

cust_id int,cust_name varchar(20),cust_state varchar(20),cust_city varchar(20))

select *from orders
select cust_id,cust_name,cust_state,cust_city
from customer
where cust_id in
(select cust_id from orders where product_name='keyboard') 
select  cust_id,order_date,product_name
from orders
where cust_id in
(select cust_id from customer where product_name='wire')




































