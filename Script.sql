Create database Gym;
use Gym

create table Plann(CodigoPlan nvarchar(60) primary key, Nombre nvarchar(60), Valor nvarchar(60));

create table Cliente(Identificacion nvarchar(60) primary key, Nombre nvarchar(60), Apellido nvarchar(60), Edad nvarchar(60),Telefono nvarchar(60), Sexo nvarchar(60),
					Direccion nvarchar(60), CodPlan nvarchar(60), Plann nvarchar(60), ValorPlan nvarchar(60),Fecha nvarchar(60));

alter table Cliente add constraint FK_CodPlan foreign key (CodPlan) references Plann (CodigoPlan);

insert into Plann(CodigoPlan, Nombre, Valor) values ('01','Mensualidad','20000');
insert into Plann(CodigoPlan, Nombre, Valor) values ('02','Bono','10000');


select *from Cliente
select * from Plann



