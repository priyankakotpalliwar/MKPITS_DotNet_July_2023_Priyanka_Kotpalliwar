select * from product1
declare
@productname varchar(max),
@price decimal;
declare cursorit cursor
for select product_name,unit_price
from product1 where unit_price>300

open cursorit;
fetch next from cursorit into
@productname,
@price;
while @@FETCH_STATUS=0
begin
print @productname+cast(@price as varchar)
fetch next from cursorit into
@productname,
@price
end
close cursorit;
deallocate cursorit;
