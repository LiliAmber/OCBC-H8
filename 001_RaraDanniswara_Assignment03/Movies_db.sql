create table movies (
Id int primary key,
Name varchar(255),
Genre varchar(255),
Duration varchar(255),
ReleaseDate varchar(255)
);

insert into movies value(1, "Bad Boys For Life", "Action/Comedy", "2h 5 mins", "2020-01-23T00:00:00");
insert into movies value(2, "John Wick", "Action/Thriller", "1h 41 mins", "2014-10-24T00:00:00");
insert into movies value(3, "The Martian", "Scifi/Drama", "2h 31 mins", "2015-10-02T00:00:00");
insert into movies value(4, "How To Train Your Dragon : The Hidden World", "Animation/Family", "1h 45 mins", "2019-02-22T00:00:00");