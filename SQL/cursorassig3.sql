select * from coustmer
declare 
@c_name varchar (max),
@c_city varchar (max);
declare cursorcoustmer cursor
for select custname,city 
from coustmer where custid>3

open cursorcoustmer;
fetch next from cursorcoustmer into
@c_name,
@c_city;

while @@FETCH_STATUS=0
begin
print @c_name+cast(@c_city as varchar)
fetch next from cursorcoustmer into
@c_name,
@c_city;
end;
close cursorcoustmer;
deallocate cursorcoustmer;

