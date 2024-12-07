Create database WebEventPoster;

Create Table Client (
ClientID int primary key,
FullName nvarchar(100),
Email nvarchar(100),
BirthDate Date
)


create table Country (
CountryID int primary key,
CountryName nvarchar(100),
)


create table City (
CityID int primary key,
CityName nvarchar(100),
CountryID int foreign key references Country(CountryID)
)


create table EventCategory (
EventCategoryID int primary key,
CategoryName nvarchar(100)
)


create table Event (
EventID int primary key,
EventName nvarchar(100),
EventDate Date,
EventTime Time,
EventLocation nvarchar(150),
MaxTicket int,
Price decimal(20,3),
Descriptions nvarchar(max),
PosterURL varchar(100),
AgeRestrict nvarchar(100)
)


create table TicketTransaction (
TransactionID int primary key,
EventID int foreign key references Event(EventID),
EventCategoryID int foreign key references EventCategory(EventCategoryID),
CountryID int foreign key references Country(CountryID),
CityID int foreign key references City(CityID),
ClientID int foreign key references Client(ClientID),
Qty int,
TotalPrice decimal(20,3),
TransactionDate Datetime,
TransUpdateDate Datetime
)


