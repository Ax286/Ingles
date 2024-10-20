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
foreign key (ct) references Categoria (ct)
)

insert into Categoria(ct,nombre) values (1,'Otro')
insert into Palabra (ct,espaniol,ingles) values (1,'blender','liquadora')

select * from Palabra
select * from Categoria

drop table Palabra

delete from Palabra where espaniol='Otro'
