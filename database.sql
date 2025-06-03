drop database Agenda;
create database Agenda
char set utf8mb4
collate utf8mb4_unicode_ci;

use Agenda;

create table usuarios(
Id_usuario int auto_increment primary key,
nome varchar(100) not null,
email varchar(100) not null,
senha varchar(100) not null
);

create table Compromisos(
Id_compromisos int auto_increment primary key,
dia date not null,
horario  time not null,
descriçao varchar(100) not null,
Id_usuario int,
foreign key (Id_usuario) references usuarios(Id_usuario)
);

select * from usuarios;
select * from Compromisos;