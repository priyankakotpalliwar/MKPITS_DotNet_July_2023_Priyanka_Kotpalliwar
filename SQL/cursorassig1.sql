select * from customer
declare 
@customername varchar(max),
@custstate varchar(max),
@custcity varchar(max);
declare cursorcustomer cursor
for select cust_name,cust_state,cust_city
from customer
open cursorcustomer
fetch next from cursorcustomer into 
@customername,
@custstate,
@custcity;
while @@FETCH_STATUS=0
begin
print @customername+cast(@custstate as varchar)
fetch next from cursorcustomer into
@customername,
@custstate,
@custcity
end;
close cursorcustomer;
deallocate cursorcustomer;



