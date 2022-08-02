use Gym

create table Plann(CodigoPlan nvarchar(60) primary key, Nombre nvarchar(60), Valor nvarchar(60));

create table Cliente(Identificacion nvarchar(60) primary key, Nombre nvarchar(60), Apellido nvarchar(60), Edad nvarchar(60), Sexo nvarchar(60),
					Direccion nvarchar(60), CodPlan nvarchar(60), Plann nvarchar(60), ValorPlan nvarchar(60),Fecha datetime);

alter table Cliente add constraint FK_CodPlan foreign key (CodPlan) references Plann (CodigoPlan);

insert into Plann(CodigoPlan, Nombre, Valor) values ('01','Bajo','20000');

drop table Cliente

drop table Plann

select *from Cliente
select * from Plann

