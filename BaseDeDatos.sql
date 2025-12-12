create database Proyecto_final;
use Proyecto_final;

create table Empleados (
Codigo int primary key auto_increment,
Nombre varchar(100) not null,
Puesto enum('Operativo','Administrador','Surpevisor','Gerente','Conserge') not null,
Fecha_de_nacimiento varchar(20) not null,
Sexo enum('Masculino','Femenino') not null,
Estado varchar(100) not null
);
