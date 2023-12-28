-----------cursor------
select * from product1
alter table product1
drop coloumn discount_price
declare 
@productname varchar (max),
@unitprice int;
declare cursor_product1 cursor
for select product_name,
unit_price
from
product1;
open cursor_product1;
fetch next from cursor_product1 into
@productname,
@unitprice;

while @@FETCH_STATUS=0
begin
print @productname + cast (@unitprice  as varchar)
fetch next from cursor_product1 into
@productname,
@unitprice;
end;
close cursor_product1;
deallocate cursor_product1;
--////////////////////////////////
declare 
@products_name varchar(max),
@lists_price decimal ;

declare c_product cursor
for select product_name ,price from products

open c_product ;
Fetch next from c_product into 
@products_name,
@lists_price

while @@fetch_status=0
begin 
print @products_name +cast(@lists_price as varchar);
fetch next from c_product into
@products_name,
@lists_price;
end;

close c_product;
deallocate c_product;