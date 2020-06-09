/*Добавление*/
INSERT INTO Users(Users_Login, Users_Password, Users_Name, Users_Img, Users_Email, Users_City) VALUES ('Admin', '123456', 'Admini', 'img', 'Admin@mail.ru', 'Novosibirsk');
INSERT INTO Themes(Themes_Name, Themes_Content, Themes_Creator, Themes_Date) VALUES ('Правила', 'Правила пользования форумом', 1, '2020-05-05');
INSERT INTO Comments(Comment_Theme_Id,Comment_Creator, Comment_Content, Comment_Files, Comment_Date) VALUES (1,1, 'Понял(а)!', '/', '2020-05-07');
/*Удаление*/
DELETE FROM Comments WHERE Comment_Id = 1;
DELETE FROM Themes WHERE Themes_Id = 1;
DELETE FROM Users WHERE Users_Id = 1;
/*Вывод таблицы*/
SELECT * FROM Users;
SELECT * FROM Themes;
SELECT * FROM Comments;