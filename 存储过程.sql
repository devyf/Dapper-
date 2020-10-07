create procedure pro_student1
as 
select * from Student;
select * from School;

exec pro_student1

go
create procedure pro_student2
(
	@name varchar(50),
	@sname varchar
)
as 
select * from Student where Name = @name;
select * from School where SchoolName = @sname;

exec pro_student2 '王小二', '西南财经大学'

go
create procedure pro_student3
(
	@name varchar(50),
	@sAge int output
)
as 
select @sAge = Age from Student where Name = @name;

declare @outAge int;
exec pro_student3 '王小二',@outAge output
print @outAge