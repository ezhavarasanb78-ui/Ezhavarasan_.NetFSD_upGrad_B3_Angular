use EventDb;
create table SessionInfo(
 sessionid int primary key,
 eventid int not null
 references EventDetails(eventid),
 sessiontitle varchar(50) not null
 check (len(sessiontitle) between 1 and 50),
 speakerid int not null
 references SpeakerDetails(speakerid),
 decription varchar(255) null,
 sessionstart datetime not null,
 sessionend datetime not null,
 sessionurl varchar(255)
 );
