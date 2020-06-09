if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users')
create table Users
(
Users_Id int primary key identity,
Users_Login varchar(100) unique NOT NULL,
Users_Password varchar(30) NOT NULL,
Users_Name varchar(100) NOT NULL,
Users_Img varchar(100) NOT NULL,
Users_Email varchar(max) NOT NULL,
Users_City varchar(max) NOT NULL
);
if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Themes')
create table Themes
(
Themes_Id int primary key identity,
Themes_Name varchar(100) NOT NULL,
Themes_Content varchar(max) NOT NULL,
Themes_Creator int NOT NULL,
Themes_Date DateTime NOT NULL,
constraint FK_User_ID foreign key(Themes_Creator) references Users(Users_Id) 
on delete cascade
on update cascade
);
if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Comments')
create table Comments
(
Comment_Id int primary key identity,
Comment_Theme_Id int NOT NULL,
Comment_Creator int NOT NULL,
Comment_Content varchar(max) NOT NULL,
Comment_Files varchar(max) NOT NULL,
Comment_Date datetime NOT NULL,
constraint FK_Comment_ID foreign key(Comment_Theme_Id) references Themes(Themes_Id),
constraint FK_Profile_ID foreign key(Comment_Creator) references Users(Users_Id) 
on delete cascade
on update cascade
);