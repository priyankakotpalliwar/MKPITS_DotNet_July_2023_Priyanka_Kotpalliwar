select * from productqty
drop  table productqty
create table productqty(id  int identity primary key ,region varchar(20),product varchar(200),
Year bigint ,quantity int,price int)
insert into productqty values('East','computer',2020,130,50000)
insert into productqty values('south','computer',2020,450,35000)
insert into productqty values('north','computer',2020,250,40000)
insert into productqty values('East','hardisk',2020,190,5500)
insert into productqty values('west','computer',2021,250,45000)
insert into productqty values('south','hardisk',2021,550,4400)
insert into productqty values('west','hardisk',2021,650,7500)
insert into productqty values('east','pendrive',2021,120,800)
insert into productqty values('north','mouse',2019,160,1500)
insert into productqty values('south','pendrive',2019,270,750)
insert into productqty values('east','mouse',2019,2000,1200)
insert into productqty values('west','pendrive',2019,190,650)

-----------sql server minimum fuction------
select product,quantity,price
from productqty
where price =(
select min (price) as "minimum quantiy"
from productqty)



------------max fuction------

select product,quantity,price
from productqty
where price=(
select max (price) as "maximum quantity"
from productqty)
----------group by clause------
select product,min(quantity) AS "minimun quantity"
from productqty
group by product

----------having clause---------
select product, min(quantity) as "minimum quantity"
from productqty
group by product
having min(quantity)>100;
--group by product;
select * from productqty 
