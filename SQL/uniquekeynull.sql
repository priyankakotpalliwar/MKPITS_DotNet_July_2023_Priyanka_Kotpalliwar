---------------voilation of unique key--------
create table hr_person( person_id int identity primary key,
person_name varchar(255) null,person_state varchar(20) not null,
email varchar(255),
constraint unique_email unique (email))
---------------------------

----------one null in unique constatraint-------------
insert into hr_person (person_name,person_state)
values('manisha','maharashtra')
select * from hr_person
------------there can be only one null element in the unique constraint-------
insert into hr_person(person_name,person_state)
values('mania','jamshedpur')
----------------unique constraint for group of coloumn-------------
create table table_name(
id int identity primary key,
person_id int,
skill_id int,
updated_at date,
unique(person_id,skill_id))
drop table table_name
insert  into table_name values(123,456,'2014-12-12')
select *  from table_name
insert into table_name values(345,567,'2013-11-11')
---------add unique constraint to existing coloumn---------
alter table table_name
add constraint validate
unique(person_id,skill_id)

alter table hr_person
add  constraint unique_person unique(person_state);
 ---------------------------- delete unique constraint--
 alter table hr_person
 drop constraint unique_email;
 sp_help hr_person