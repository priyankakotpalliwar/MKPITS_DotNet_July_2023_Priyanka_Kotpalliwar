create table vendor_groups( group_id int identity primary  key,group_name varchar(100) not null)
drop table vendors

create table vendors(vendor_id int identity primary key,vendor_name varchar(100)not null,group_id int not null,
constraint fk_group foreign key(group_id) REFERENCES vendor_groups(group_id));
insert into vendor_groups values('MKPITS')

select * from vendor_groups
insert into vendors (vendor_name,group_id)
values('amit',123)
insert into vendors  values('shreya',342)
select * from vendors