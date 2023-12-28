select * from productqty
declare
@pr_region varchar (max),
@pr_product varchar(max),
@pr_quantity int;
declare cursorpro cursor
for select region,product,quantity
from productqty where product='mouse'

open cursorpro;
fetch next from cursorpro into
@pr_region,
@pr_product,
@pr_quantity;

while @@FETCH_STATUS=0
begin
print cast(@pr_quantity as varchar)+@pr_region+@pr_product
fetch next from cursorpro into
@pr_region,
@pr_product,
@pr_quantity;



end;
close cursorpro;
deallocate cursorpro;
