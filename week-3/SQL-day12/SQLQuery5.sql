use EventDb;
create table participantdetails(
id int primary key,
email varchar(100) not null
references UserInfo(Emailid),
eventid int not null
references EventDetails(eventid),
sessionid int not null
references SessionInfo(sessionid),
isattend bit not null
check(isattend in(0,1))
);