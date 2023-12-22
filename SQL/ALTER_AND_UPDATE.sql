select * from person

insert into person values('manika','karnika','mani@gmail.com')
select * from product1
insert into product1 values('desktop',300)
insert into product1 values('mouse',200)
---------------------------update--------
------1)get set--------
update product1 set unit_price=30
where product_name = 'desktop'

update product1 set unit_price=500
where product_name='sara'
update product1 set product_name='mic'
where unit_price=500
-------2)And-------------
update product1 set unit_price=200
where product_name='mic' and unit_price=500

select * from product1
update product1 set unit_price=340
where product_name='desktop' and unit_price=30
--------3)DELETE----------
delete from product1
where product_name='mouse'


-----------------------------------
create table sample123(id int identity primary  key,name_s varchar (20))
insert into sample123 values('laptop')
insert into sample123 values('ravish')
insert into sample123 values('bhavin')
insert into sample123 values('shrey')
insert into sample123 vaLues('bani')
insert into sample123 values('panino')
select * from  newsample
delete from sample123
-------------turncate table-----
truncate table sample123
insert into sample123 values('hippo')
insert into sample123 values('neemo')
------------adding one more coloumn---------
alter table newsample
add price int
sp_help sample123
-----------query to rename coloumn-----------
exec sp_rename 'sample123.price'
,'pehoww','column'
---------query to rename table---------
sp_rename 'sample123','newsample'
----------query to change  datatype of coloumn----
alter table newsample
alter column  price dec(10,2)
select*from newsample
-------query to drop column-
alter table newsample
drop column pehoww
sp_help newsample
