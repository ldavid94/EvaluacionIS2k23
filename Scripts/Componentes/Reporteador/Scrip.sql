create database reporteria;
use reporteria;

create table reportes(
	id int,
    ruta varchar(100),
    nombre_archivo varchar(50),
    aplicacion varchar(50),
    estado int(1)
);
