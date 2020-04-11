create database AuthProject
use AuthProject

create table Users(
	Id int primary key identity,
	Name nvarchar(100) not null,
	Email nvarchar(300) unique,
	Password nvarchar(300) not null,
	IsAdmin bit default 0 not null,
	IsActivated bit default 0 not null,
	IsDeleted bit default 0 not null
)

select * from Users