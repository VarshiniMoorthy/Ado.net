use[DataCollection];

create table programmersDetails(name varchar(10),
prof1 varchar(20),
prof2 varchar(10),
salary float)



Create Procedure sp_GetProgammerDetail
@name varchar(10),
@prof1 varchar(20),
@prof2 varchar(10),
@salary float
as
begin
Insert into programmersDetails(name,prof1,prof2,salary)
Values(@name,@prof1,@prof2,@salary);
end



 Create Procedure sp_UpdateProf1
@prof1 varchar(10),
@name varchar(15)
as
begin
	UPDATE programmersDetails SET prof1 = @prof1 WHERE name = @name
end


Create Procedure sp_DeleteProgrammerDetail
@name varchar(10)
as
begin 
Delete from programmersDetails where name = @name
end


Create Procedure sp_DisplayProgrammerDetail
as
Begin
	Select * from programmersDetails
end





create table Audittables(id numeric,name varchar(10));
select * from Audittables;
--drop Audit;

