create database EventDb;
use EventDb;
create table UserInfo( 
Emailid varchar(100) primary key,
UserName varchar(50) NOT NULL check (len(UserName) between 1 AND 50 ),
Role varchar(20) NOT NULL 
CHECK (Role IN( 'ADMIN','PARTICIPANT')),
Password varchar(20) NOT NULL 
check (len(Password) between 6 and 20)
);