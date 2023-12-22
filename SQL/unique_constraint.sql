----unique constraint---
create table person(Person_id int identity primary key,
First_name varchar(255),Last_name varchar(255),
email varchar(255)unique)
select* from person
insert into person values('priyanka','kotpalliwar','yanka@gmail.com')
insert into person values('shreya','manikar','priyank@gmail.com')
----unique constraint as coloumb constraint------------------
create table person1(Person_name int identity primary key,
first_name varchar(200) not null,last_name varchar(255),
email varchar(200),
unique(email))
INSERT INTO hr.person(first_name, last_name, email)
VALUES('Jane','Doe','j.doe@bike.stores');

insert into hr.persom(First_name,Last_name,email)values('maria','gomes','maria@gmail.com')
sp_help person