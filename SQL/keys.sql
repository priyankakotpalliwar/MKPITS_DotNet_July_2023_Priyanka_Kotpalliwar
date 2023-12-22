-------4)composite key---
create table sampling(id int ,
name varchar(20),city varchar(20),
primary key(id,name))
insert into sampling values(3,'rita','nagpur')
insert into sampling values(4,'eisha','malad')
insert into sampling values(4,'rita','maglur')

select * from order_details1

create table order_details1(orderid int,productid int,
quantity int,primary key(orderid,productid))

insert into order_details1 values(1,11,2);
insert into order_details1 values(1,12,2);
insert into order_details1 values(1,13,3);
insert into order_details1 values(2,11,2);
sp_help order_details1
----------5)unique key--------
create table sample2(id int unique , names varchar(20),age int )
insert into sample2  values(1,'ravi',2)
insert into sample2 values(1,2,'ravish')
insert into sample2 values (1,2,'mitahal')

alter table sample2
drop column name
select * from sample2
alter table sample2
add  names varchar(20)
create table Emoloyee(id int,names varchar(20),employee_adress varchar(20),
constraint uq_m unique(id,names))
select * from Emoloyee
insert into Emoloyee values(2,'rashi','modi bhavan')
insert into Emoloyee values(2,'rashi','dsag')
sp_help Emoloyee
--------------
create table Employee1(id int,names varchar(20),rno int unique,pno int unique)
insert into Employee1 values(1,'ravism',2,4)
insert into Employee1 values(2,'easg',4,4)