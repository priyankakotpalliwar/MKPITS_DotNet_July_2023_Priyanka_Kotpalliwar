
select *from coustmer
select * from product
insert into product values('sohan',20000,10)
insert into product values('roshni',50000,9)
insert into product values('ishani',30000,9)
insert into product values('shamal',60000,5)
insert into product values('saikiran',90000,7)
insert into product values('saksham',40000,8)


select  TOP 3
 fees ,studentname from product 
order by fees asc
drop table Table_1
insert into Table_1 values('soham','headphone',12,1500)
insert into Table_1 values('ojefa','earphone',22,1000)
insert into Table_1 values('naomi','mobile cover',32,1100)
insert into Table_1 values('meoko','screen gaurd',42,800)
select TOP 4 productname,price from Table_1
order by price desc
create table coustmer(custid int,custname varchar(20), city varchar(20));
insert into coustmer values(2,'heralal','nagpur')
insert into coustmer values(3,'modilal','nagpur')
insert into coustmer values(4,'panalal','nagpur')
insert into coustmer values(5,'haldiram','nagpur')
insert into coustmer values(6,'jethalal','mumbai')
insert into coustmer values(7,'mehta','mumbai')
insert into coustmer values(8,'iyer','mumbai')
insert into coustmer values(9,'babita','kolkata')
insert into coustmer values(10,'bandeya','kolkata')
insert into coustmer values(11,'jeetu','kolkata')

select custid,city from coustmer
order by len(custid)desc;

