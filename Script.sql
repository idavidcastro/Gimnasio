use Gym
create table Cliente(Identificacion nvarchar(15) primary key, Nombre nvarchar(15), Apellido nvarchar(15), Edad nvarchar(15), Sexo nvarchar(15), Direccion nvarchar(15), Plann nvarchar(15), Fecha datetime);



select * from Cliente

alter table Cliente add constraint FK_codPlan foreign key (Plann) references Plann(CodigoPlan); 


use gym

select * from Plann