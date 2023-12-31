create database Assignment14Db
use Assignment14Db

create table Category
(CatId int primary key,
CatName nvarchar(50) 
)
create table Course
(CId int primary key,
CName nvarchar(50),
CFee float,
CStartDate Date ,
CatId int foreign key references Category(CatId) on delete cascade on update Cascade
)