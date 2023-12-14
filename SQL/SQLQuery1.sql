create database sample

create  table  sample(id int)
create table student(rno  int,name varchar(20))
create table product(productid int,productname varchar(20),price int, quantity int)
insert into product values(2433,'soap',50,1)

insert into product values(2689,'nirma',150,2)

insert into product values(2090,'shampoo',2,3)

insert into product values(2893,'liquid detergent',1150,3)
insert into student values(1,'amit')
insert into  student values(2,'priyanka')
insert into student values(2,'shreya')
select * from sample
select * from student
select * from product


select *from product order by productid 
create table coustmer(custid int primary key,custname varchar(20))
insert into coustmer values(1,'diop')
insert into coustmer values(2,'SIOP')

select * from coustmer