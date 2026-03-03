use EventDb;
create table SpeakerDetails(
speakerid int primary key,
speakername varchar not null
check (len(speakername) between 1 and 50 ));