create table stores(store_id int identity(1,1) primary key, store_name varchar(200)not null,phone varchar(20),email varchar(200)
,street varchar(200),city varchar
(20),State varchar(20),zip_code varchar(10))
select * from stores
drop table stores
insert into stores values('jana','9022440562','shreya@200','naidu basti','nagpur','maharashtra','44003')
insert into stores values('mana','934146770','priyankak@2002','mohan nagar','nagpur','maharasshtra','440001')
insert into stores values('mania','9325452452','maria@3003','chritian colony','nagpur','maharashtra','40023') 
create table staff( staff_id int identity primary key,first_name varchar(20)