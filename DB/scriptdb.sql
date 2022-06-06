create database pub;
go
use pub;
go

create table Brand
(
	Id int identity(1,1) not null,
	Name varchar(100) not null,
	constraint PK_Brand primary key clustered(Id)
)
go

create table Beer
(
	Id int identity(1,1) not null,
	Name varchar(100) not null,
	BrandId int not null,
	constraint PK_Beer primary key clustered(Id),
	constraint FK_Beer_Brand foreign key(BrandId) references Brand(Id)
)
go

INSERT INTO Brand (Name) 
VALUES ('Club'),
		('Pilsener'),
		('Heineken'),
		('Budweiser'),
		('Corona'),
		('Brahma');
go


SELECT * FROM Brand;
SELECT * FROM Beer;

