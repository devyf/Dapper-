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
insert into stuinfo values('������', 1001, '��', 25, '���ݸ�����')
insert into stuinfo values('����', 1002, 'Ů', 25, '����԰��')
insert into stuinfo values('������', 1003, '��', 25, '���ݸ�����')	
insert into stuinfo values('����', 1004, '��', 25, '���ݸ�����')	
insert into stuinfo values('��С��', 1005, 'Ů', 25, '��������')
insert into stuinfo values('����', 1006, '��', 25, '���ݸ�����')

----��ӵ�ǰ���������
alter table stuinfo
add constraint PK_StuNo primary key(stuNo) --����

----����Լ��
alter table stuinfo
add constraint CK_StuAge check(stuAge >= 18 and stuAge <= 35)

----����һ���ɼ���stumark examno stuno writtenexam labexam
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
add constraint PK_ExamNo primary key(examNo) --����

select * from stumark
select * from stuinfo
----������������
insert into stumark
select 'Geekhome001',1001,75,80 union
select 'Geekhome002',1002,65,86 union
select 'Geekhome003',1003,55,59 union
select 'Geekhome004',1004,96,72 union
select 'Geekhome005',1005,56,72 union
select 'Geekhome006',1006,65,78
go
----���Լ��������֮����������ϵ����

----����ѧ����ͳɼ���֮������ӱ��ϵ���������ϵ
alter table stumark
add constraint FK_Stuno foreign key(stuNo) references stuinfo(stuNo)

----�洢���̵Ĵ������ٲ��������Ĵ洢���̣�δͨ�����Ե�ѧ������
if exists (select * from sysobjects where name='P_stuMarkInfo')
drop proc P_stuMarkInfo
go
create proc P_stuMarkInfo
as
select * from stuinfo where stuNo not in
(select stuNo from stumark where writtenExam >= 60 and labExam>=60)

----ִ�д洢����
exec P_stuMarkInfo


----�洢���̵Ĵ������ڴ������Ĵ洢����
----���Ժͻ��Եļ��������û�ָ��������ͳ�Ƴ�δͨ�����Ե�����
if exists (select * from sysobjects where name='P_stuMarkInfo1')
drop proc P_stuMarkInfo1
go
create proc P_stuMarkInfo1
@writeLevel int,  ----������������Լ�����
@labLevel int,    ----������������Լ�����
@examNum int output     ----���������δͨ�����Ե�����
as

select @examNum = count(*) from stuinfo where stuNo not in
(select stuNo from stumark where writtenExam >= @writeLevel and labExam>=@labLevel)


----ִ�д洢����
declare @countNum int
exec P_stuMarkInfo1 60, 60, @countNum output

print 'δͨ�����Ե�������' + convert(varchar(20), (@countNum)) 

