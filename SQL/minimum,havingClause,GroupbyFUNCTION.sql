----max function---
select product,quantity,price
from productqty
where quantity=(
select max(quantity) as "maximum price"
from productqty);
---------------ORDER BY PRODUCT --------

SELECT product,max(quantity) as" maximim quantity "
from productqty
group by product
order by product
----sql average function----
select avg(quantity) as "average quantity"
from productqty
where product='mouse';
select * from productqty

------------ sql sum function------------
select * from fees
select rno,sum(amount) from fees
group by rno
