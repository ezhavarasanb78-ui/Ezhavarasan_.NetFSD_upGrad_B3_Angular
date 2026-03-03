use EventDb;
create table EventDetails(
 eventid int not null primary key,
 eventname varchar(50) not null,
 check (len(eventname) between 1 and 50 ),
 eventcategory varchar(50) not null
 check (len(eventcategory) between 1 and 50),
 eventdate datetime not null,
 description varchar(255) null,
 status varchar(10) not null
 check (status in('active','inactive'))
 );