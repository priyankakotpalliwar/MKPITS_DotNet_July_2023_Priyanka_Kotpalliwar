create table Employee2(empid int identity primary key,Empname varchar(20),
empcontact bigint,empemail varchar(200),empdepartment varchar (200),empcity varchar(20),empsalary bigint)
 insert into Employee2 values ('rakesh',984983202,'rakesh@gmail.com','computer','ahmdabad',20000),
 ('karan',9567983202,'karan@gmail.com','account','mumbai',20000),
 ('keval',9847692849,'keval@gmail.com','management','mumbai',190000),
 ('rina',9098734542,'rina@gmail.com','account','nagpur',25000),
 ('rahul',984983202,'rahul@gmail.com','account','nagpur',20000),
 ('rohan',935356702,'rohan@gmail.com','computer','mumbai',20000),
 ('ketan',923454502,'kk@gmail.com','management','ahmdabad',20000)
 insert into Employee2 values('priyanka',9022440562,'priyankakotpalliwar@gmail.com','computer','ahmdabad',20000)
 select * from Employee2
 update Employee2 set empsalary=18000
 where Empname='rohan'
 update Employee2 set empsalary=15000
 where Empname='ketan'
 ------their are two types of user defined function in sql----
 ---1)table valued function
 --2)saclar valued function

 ----1) table values function
 create function f1()
 returns table
 as
 return(select * from Employee2)

 select * from f1()

 create function f2()
 returns table
 as 
 return(select * from Employee1)


 create function f3()
 returns table
 as
 return(select * from Emoloyee)

 -----------2)scalar function-
 create function func1
 (
 @id ,
 @empcity varchar(50),
 @empcontact varchar(50))

 returns nvarchar(100)
 
 as
 begin return(select @empname+' '+@empcity+' ' +@empcontact+' ')
 end



 select dbo.func1(empname,empcity,empcontact)as'detail' from Emoloyee
 ------example2---

 create table stud1(rno int,m1 int,m2 int ,m3 int)
 insert into stud1 values(2,42,32,23),(3,34,45,56)
 insert into stud1 values(4,11,11,11)
 select * from stud1
 create function eno1(
 
 @m1 int,
 @m2 int,
 @m3 int)
 returns int
 as
 begin
 return(select @m1-' '+@m2-' '-@m3+'')
 end
 
 select  dbo.eno1(m1,m2,m3) as 'total marks' from stud1



