if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users')
drop table Users;
if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Themes')
drop table Themes;
if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Comments')
drop table Comments;