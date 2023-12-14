select * from salesman
drop table salesman
create table salesman(salesman_id int identity(50001,1),name varchar(20),city varchar(20),commision float)
insert into salesman values(  'James Hoog', ' New York ' ,0.15)
insert into salesman values('Nail Knite' , 'Paris', 0.13)
insert into salesman values('Pit Alex  ','London', 0.11)
insert into salesman values('Mc Lyon ','Paris ',0.14)
insert into salesman values( 'Paul Adam ',' Rome',0.13)
insert into salesman values( 'Lauson Hen','San Jose ', 0.12)

select name,commision  from salesman

