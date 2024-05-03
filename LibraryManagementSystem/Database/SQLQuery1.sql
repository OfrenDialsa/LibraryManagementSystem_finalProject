create table users
(
	id int primary key identity (1,1),
	email varchar(max) null,
	username varchar(max) null,
	password varchar(max) null,
	date_register date null
)

select * from users