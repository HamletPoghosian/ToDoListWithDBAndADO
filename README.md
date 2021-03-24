# ToDoListWithDBAndADO
![GitHub Logo](https://images-na.ssl-images-amazon.com/images/I/417elukPtcL.jpg)
## The project Can We Create Our Task . 
## Insert DataBase  our Task .
![GitHub Logo](https://thumbs.gfycat.com/AppropriateBarrenDragon-small.gif)
## Delete Update And Search from DB
![GitHub Logo](https://cdn.dribbble.com/users/1581195/screenshots/3695151/delete.gif)
### DataBase Creating Code

~~~SQL

CREATE TABLE Task
(
	
	Id int IDENTITY(1,1) PRIMARY KEY,
	TaskDescription NVARCHAR(50) NOT NUll,
	IsComletid BIT  NOT NULL DEFAULT 0,
)


~~~
