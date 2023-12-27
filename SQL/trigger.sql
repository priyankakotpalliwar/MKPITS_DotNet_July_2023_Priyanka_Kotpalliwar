create table employee(employee_id int primary key,employee_name varchar(20))
select* from employee
select* from employee_log
create table employee_log(logID int identity(1,1) not null,empID int not null,
operation nvarchar(100) not null,updateDATE datetime not null)
create trigger empt
on employee
for insert
as
insert into
employee_log(empID,operation,ename,updateDATE)
select employee_id,'insert',employee_name,GETDATE() from
inserted;
insert into employee values  (1,'siya')
insert into employee values (2,'ayushi')
select * from dbo.employee_log

create trigger empui
on employee
for insert
as
insert into
employee_log(empID,operation,updateDATE)
select employee_id,'insert',GETDATE() from inserted









--------------after triggers--
create trigger empu
on employee
after update
as
insert into
employee_log(empID,operation,updateDATE)
select employee_id,'update',GETDATE() from deleted;
UPDATE employee set employee_name='rishi' where employee_id=2





create trigger emp_delete
on employee
after delete
as
insert into
employee_log(empID,operation,updateDATE)
select employee_id,'delete',GETDATE() from deleted

delete from employee where employee_id=2