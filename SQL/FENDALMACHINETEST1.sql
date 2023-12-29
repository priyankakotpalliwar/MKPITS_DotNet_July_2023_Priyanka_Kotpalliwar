----------table nation------------

create table TableNation(NationID int primary key 
,NationName varchar(500) not null)
insert into TableNation values(1,'Brazil')
insert into TableNation values(2,'India')
insert into TableNation values(3,'Palestine')
insert into TableNation Values(4,'Ukraine')
insert into TableNation Values(5,'Singapore')

select * from TableNation
select * from TableState
------------table state---------
select * from TableState
create table TableState(StateID int primary key not null
,NationID int foreign key References TableNation(NationID),
StateName varchar(500))
insert into TableState values(201,1,'jeddah')
insert into TableState values(202,2,'rajasthan')
insert into TableState values(203,3,'PalestineState')
insert into TableState values(204,4,'Ukraine')
insert into TableState values(205,5,'SingaporeState')

-------Table City-----
drop table TableCity
create table TableCity(CityID int primary key,StateID int foreign key  references 
TableState(StateID),CityName varchar(500))
insert into TableCity values(100,201,'ludiana')
insert into TableCity values(200,202,'moscow')
insert into TableCity values(300,203,'mumbai')
insert into TableCity values(400,204,'sanfransisco')
insert into TableCity values(500,205,'chicago')

select * from TableCity


------------- table course regdetail----
select * from CourseRegDetail
create table CourseRegDetail(CourseRegID int primary key,
CategoryInd int,FullName varchar(1500),GenderInd int)

insert into CourseRegDetail values(101,20,'Rajkumari',150)
,(102,21,'harddy',250),(103,22,'manu',350),(104,23,'balu',450),
(105,24,'shiv',550)

------------------tableRegAddress----

create table RegAddress(RegAddressID int not null,
CourseRegID int foreign key REFERENCES CourseRegDetail(CourseRegID),
NationID int foreign key references TableNation(Nationid),
StateID int foreign key references TableState(StateID) ,CityID int foreign key references 
TableCity(CityID))

SELECT * from RegAddress
sp_help   RegAddress 
insert into RegAddress values(90,101,1,201,100)
insert into RegAddress values(91,102,2,202,200)
insert into RegAddress values(92,103,3,203,300)
insert into RegAddress values(93,104,4,204,400)
insert into RegAddress values(94,105,5,205,500)
----------table fess detail---
create table TableFeeDetail(FeeID int,
CourseRegID int foreign key references CourseRegDetail(CourseRegID)
,TotalAmount decimal,MinPer decimal,PaidAmount decimal,BalAmount decimal,
PaidDate datetime)
select * from TableFeeDetail

insert into TableFeeDetail values(1088,101,5000,299,3000,200,2013-5-5)
insert into TableFeeDetail values(1088,102,1000,593,400,244,2019-4-12)
insert into TableFeeDetail values(1088,103,2000,242,200,32,2011-4-5)
insert into TableFeeDetail values(1088,104,3000,252,900,244,2017-3-9)
insert into TableFeeDetail values(1088,105,5000,452,150,424,2018-3-10)
