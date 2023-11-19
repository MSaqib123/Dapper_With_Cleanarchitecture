create database [Dapper.API_Clean_Architecture_Repository]

use [Dapper.API_Clean_Architecture_Repository]

create table tblContact(
	ContactId int primary key Identity,
	FirstName varchar(50),
	LastName varchar(50),
	Email varchar(50) unique,
	PhoneNumber varchar(12)
)

SELECT * FROM tblContact (NOLOCK)