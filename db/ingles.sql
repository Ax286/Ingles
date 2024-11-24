create database ingles

use ingles

create table Categoria(
ct int primary key,
nombre varchar(30)
)

create table Palabra(
ct int,
espaniol varchar(30),
ingles varchar(30),
Correcto int,
Incorrecto int,
foreign key (ct) references Categoria (ct)
)

insert into Categoria(ct,nombre) values (1,'Otro')
insert into Palabra (ct,espaniol,ingles,Correcto,Incorrecto) values (1,'licuadora','blender',0,0)

update Palabra set Correcto=1 where espaniol='licuadora'

alter table Palabra add Total as (Correcto+Incorrecto)

alter table Palabra drop column Porcentaje

alter table Palabra add Porcentaje as case when (Correcto+Incorrecto)=0 then 0 else Correcto*100/(Correcto+Incorrecto) end

alter table Palabra add Porcentaje as case when (Total)=0 then 0 else Correcto*100/(Total) end

select * from Palabra
select * from Categoria

drop table Palabra

delete from Palabra where espaniol='blender'

drop table Palabra 

select * from Palabra where Porcentaje<50

select * from Palabra where Total<(select AVG(Total) from Palabra) or Porcentaje<50
