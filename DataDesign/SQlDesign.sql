create database Memmory;

use Memmory;

create table Subjects(
	SubjectID int identity(1,1) primary key,
	SubjectName nvarchar(200) not NULL UNIQUE
)
create table Chapters(
	ChapterID int identity(1,1) primary key,
	ChapterName nvarchar(200) not NULL UNIQUE,
	SubjectID int,
	foreign key (SubjectID) references Subjects(SubjectID)
)
create table Units(
	UnitID int identity(1,1) primary key,
	UnitName nvarchar(200) not NULL UNIQUE,
	ChapterID int,
	foreign key (ChapterID) references Chapters(ChapterID)
)
create table Concepts(
	ConceptID int identity(1,1) primary key,
	ConceptName nvarchar(200) not NULL UNIQUE,
	Author nvarchar(200),
	Year char(4),
	Content ntext not NULL,
	UnitID int,
	foreign key (UnitID) references Units(UnitID)
)