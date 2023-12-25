------------assignment subquery-------

create table students(rno int ,stud_name varchar(20),email varchar (200),city varchar(200),courseid int)
insert into students values(1,'priyanka','priyanka@gmail.com','nagpur',315)
insert into students values(2,'riya','riya@gmail.com','nagpur',415)
insert into students values(3,'eisha','eisha@hmail.com','nagpur',413)
insert into students values(4,'alka','alka@gmail.com','nagpur',444)
drop table students
select * from students

create table fees(feesid int,rno int,feesdate date,amount int,courseid int)
select * from fees
insert into fees values(121,2,'2013-2-12',5000,221)
insert into fees values(231,4,'2013-4-14',4000,231)
insert into fees values(345,5,'2014-5-10',5000,234)
select stud_name,email,city,courseid, rno
from students
where  rno in 
(select rno from fees where stud_name='riya')