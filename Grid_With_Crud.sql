drop table if exists selfinfo;
create table selfinfo(
id int identity primary key not null,
name varchar(50),
email varchar(50),
phone int
);

select * from selfinfo;

drop procedure if exists self_curd
create procedure self_curd
 @Action varchar(20),
 @id int = null,
 @name varchar (50) = null,
 @email varchar(50) = null,
 @phone int = null
as
begin
set nocount on;

if @Action ='select'
begin 
select @id,name,email,phone from selfinfo
end

if @Action = 'insert'
begin
insert into selfinfo(name,email,phone)values(@name,@email,@phone)
end

if @Action = 'update'
begin 
update selfinfo
set name=@name, email=@email,phone=@phone
where id=@id
end

if @Action = 'delete'
begin
delete from selfinfo
where id=@id
end

end
