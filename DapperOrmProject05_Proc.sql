use DapperDemo
if exists (select * from sysobjects where name='stuinfo')
drop table stuinfo
go
create table stuinfo
(
	stuName varchar(20) not null,
	stuNo int not null,
	stuSex varchar(20),
	stuAge int not null,
	stuSeat int identity(1,1),
	stuAddress varchar(50),
)
go

select * from stuinfo
insert into stuinfo values('张秋林', 1001, '男', 25, '苏州高新区')
insert into stuinfo values('王林', 1002, '女', 25, '苏州园区')
insert into stuinfo values('张老三', 1003, '男', 25, '苏州高新区')	
insert into stuinfo values('张扬', 1004, '男', 25, '苏州高新区')	
insert into stuinfo values('田小六', 1005, '女', 25, '杭州新区')
insert into stuinfo values('赵四', 1006, '男', 25, '苏州高新区')

----添加当前表的主键列
alter table stuinfo
add constraint PK_StuNo primary key(stuNo) --主键

----年龄约束
alter table stuinfo
add constraint CK_StuAge check(stuAge >= 18 and stuAge <= 35)

----创建一个成绩表stumark examno stuno writtenexam labexam
if exists (select * from sysobjects where name='stumark')
drop table stumark
go
create table stumark
(
	examNo varchar(20) not null,
	stuNo int not null,
	writtenExam int not null,
	labExam int not null
)
alter table stumark
add constraint PK_ExamNo primary key(examNo) --主键

select * from stumark
select * from stuinfo
----插入五条数据
insert into stumark
select 'Geekhome001',1001,75,80 union
select 'Geekhome002',1002,65,86 union
select 'Geekhome003',1003,55,59 union
select 'Geekhome004',1004,96,72 union
select 'Geekhome005',1005,56,72 union
select 'Geekhome006',1006,65,78
go
----外键约束：两表之间的主外键关系创建

----创建学生表和成绩表之间的主从表关系：主外键关系
alter table stumark
add constraint FK_Stuno foreign key(stuNo) references stuinfo(stuNo)

----存储过程的创建：①不带参数的存储过程，未通过考试的学生名单
if exists (select * from sysobjects where name='P_stuMarkInfo')
drop proc P_stuMarkInfo
go
create proc P_stuMarkInfo
as
select * from stuinfo where stuNo not in
(select stuNo from stumark where writtenExam >= 60 and labExam>=60)

----执行存储过程
exec P_stuMarkInfo


----存储过程的创建：②带参数的存储过程
----笔试和机试的及格线由用户指定，并且统计出未通过考试的人数
if exists (select * from sysobjects where name='P_stuMarkInfo1')
drop proc P_stuMarkInfo1
go
create proc P_stuMarkInfo1
@writeLevel int,  ----输入参数：笔试及格线
@labLevel int,    ----输入参数：机试及格线
@examNum int output     ----输出参数：未通过考试的人数
as

select @examNum = count(*) from stuinfo where stuNo not in
(select stuNo from stumark where writtenExam >= @writeLevel and labExam>=@labLevel)


----执行存储过程
declare @countNum int
exec P_stuMarkInfo1 60, 60, @countNum output

print '未通过考试的人数：' + convert(varchar(20), (@countNum)) 

-----多表连接查询
select * from stuinfo inner join stumark on stuinfo.stuNo = stumark.stuNo

-----多表连接查询实例二
if exists (select * from sysobjects where name='UserInfo')
drop table UserInfo
go

Create Table UserInfo
(
	[UserId]   [int] IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	[Username] [nvarchar] (256) NOT NULL,
	[PasswordHash] [nvarchar] (500) NULL,
	[Email]  [nvarchar] (256) NULL,
	[PhoneNumber] [nvarchar](30) NULL,
	[IsFirstTimeLogin] [bit] DEFAULT(1) NOT NULL,
	[AccessFailedCount]  [int] DEFAULT(0) NOT NULL,
	[CreateDate]    [datetime] DEFAULT(GETDATE()) NOT NULL,
	[IsActive]    [bit] DEFAULT(1) NOT NULL
)

insert into UserInfo(Username, PasswordHash, Email, PhoneNumber)
values('Jack', '123456', 'Jack_Wang@igeekhome.com', '13542671841')

insert into UserInfo(Username, PasswordHash, Email, PhoneNumber)
values('Tom', '456123', 'Tom_Zhang@igeekhome.com', '13978674541')

insert into UserInfo(Username, PasswordHash, Email, PhoneNumber)
values('Hem', '852369', 'Hem_Zang@igeekhome.com', '13771976253')

select * from UserInfo

if exists (select * from sysobjects where name='Role')
drop table [Role]
go
CREATE TABLE [Role]
(
	[RoleId]  [int] IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
)
insert into [Role] values('学生')
insert into [Role] values('教师')
insert into [Role] values('工人')

select * from [Role]

if exists (select * from sysobjects where name='UserRole')
drop table UserRole
go
CREATE TABLE UserRole
(
	[Id] [int] IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	[UserId] [int] FOREIGN KEY REFERENCES UserInfo ([UserId]) NOT NULL,
	[RoleId] [int] FOREIGN KEY REFERENCES [Role] ([RoleId]) NOT NULL
)
insert into UserRole values(1,2)
insert into UserRole values(2,1)
insert into UserRole values(3,2)

select * from UserRole


----------接上，多表查询操作查询语句sql
select u.*, r.* from UserInfo u
inner join UserRole ur on ur.UserId = u.UserId
inner join Role r on r.RoleId = ur.RoleId

select u.UserId, u.UserName, u.PasswordHash, r.RoleId, r.RoleName from UserInfo u
inner join UserRole ur on ur.UserId = u.UserId
inner join Role r on r.RoleId = ur.RoleId









