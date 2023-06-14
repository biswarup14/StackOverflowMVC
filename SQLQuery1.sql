create database Proj_Stackoverflow

use Proj_Stackoverflow

create table Categories(
CategoryID int primary key identity(1,1),
CategoryName nvarchar(max))


create table Users(
UserID int primary key identity(1,1),
Email nvarchar(max),
PasswordHash nvarchar(max),
Name nvarchar(max),
Mobile nvarchar(max),
IsAdmin bit default(0))



create table Questions(
QuestionID int primary key identity(1,1),
QuestionName nvarchar(max),
QuestionDateAndTime datetime,
UserID int references Users(UserID) on delete cascade,
CategoryID int references Categories(CategoryID) on delete cascade,
VotesCount int,
AnswersCount int,
ViewsCount int)


create table Answers(
AnswerID int primary key identity(1,1),
AnswerText nvarchar(max),
AnswerDateAndTime datetime,
UserID int references Users(UserID),
QuestionID int references Questions(QuestionID) on delete cascade,
VotesCount int)


create table Votes(
VoteID int primary key identity(1,1),
UserID int references Users(UserID),
AnswerID int references Answers(AnswerID) on delete cascade,
VoteValue int)

insert into Users values ('admin@gmail.com', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Admin', '0000000', 1)

insert into Users values ('test@gmail.com', 'ecd71870d1963316a97e3ac3408c9835ad8cf0f3c1bc703527c30265534f75ae', 'Test', '0000000', 0)

select * from Users

insert into Categories values('HTML')
insert into Categories values ('JavaScript')
insert into Categories values ('CSS')
insert into Categories values ('NodeJS')

select * from Categories

insert into Questions values ('How to create a git repository', '2022-06-30 10:30am',1,2,0,0,0)
insert into Questions values ('How to use Microsoft sql server', '2023-05-18 9:30pm',2,1,0,0,0)

select * from Questions
