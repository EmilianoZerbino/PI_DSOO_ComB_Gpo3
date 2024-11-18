drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
/*Tablas de Datos del Sistema*/
/*-------------------------------------------------------------------------------------------------------------------------------------------------*/

/*drop table if exists disciplinahorario;
drop table if exists socioDisciplina;
drop table if exists noSocioDisciplina;
drop table if exists disciplina;
drop table if exists horario;
drop table if exists socio;
drop table if exists noSocio;
drop table if exists profesor;
drop table if exists direccion;*/


create table direccion(
	IdDireccion int auto_increment,
	calle varchar (50),
	altura int,
	NPiso int,
	NDepto int,
	Barrio varchar(50),
	Localidad varchar (50),
	constraint pk_direccion primary key (IdDireccion)
);

create table socio(
	IdSocio int auto_increment,
	IdDireccion int,
	Dni int,
	Nombres varchar (50),
	Apellidos varchar(50),
	Nacionalidad varchar(30),
    venceCuota Date,
	constraint pk_socio primary key (IdSocio),
	constraint fk_direccionSocio foreign key(IdDireccion) references direccion(IdDireccion)
);ALTER TABLE socio AUTO_INCREMENT = 100001;

create table noSocio(
	IdNoSocio int auto_increment,
	IdDireccion int,
	Dni int,
	Nombres varchar (50),
	Apellidos varchar(50),
	Nacionalidad varchar(30),
    venceCuota Date,
	constraint pk_noSocio primary key (IdNoSocio),
	constraint fk_direccionNoSocio foreign key(IdDireccion) references direccion(IdDireccion)
);

create table profesor(
	IdProfesor int auto_increment,
	IdDireccion int,
	NMatricula int,
	Dni int,
	Nombres varchar (50),
	Apellidos varchar(50),
	Nacionalidad varchar(30),
	constraint pk_profesor primary key (IdProfesor),
	constraint fk_direccionProfesor foreign key(IdDireccion) references direccion(IdDireccion)
);

create table disciplina(
	IdDisciplina int auto_increment,
	Nombre varchar(30),
	IdProfesor int,
	ArancelMensual double,
	MaxInscriptos int,
	constraint pk_disciplina primary key (IdDisciplina),
	constraint fk_profesor foreign key(IdProfesor) references profesor(IdProfesor)
);

CREATE TABLE Horario (
    IdHorario int auto_increment,
    IdDisciplina int,
    Dia enum('Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado') NOT NULL,
    HoraInicio time,
    HoraFin time,
    constraint fk_disciplinaH foreign key(IdDisciplina) references disciplina(IdDisciplina),
    constraint pk_horario primary key (IdHorario)
);

create table socioDisciplina(
	IdSocioDisciplina int auto_increment,
	IdSocio int,
    IdDisciplina int,
    constraint pk_socioDisciplina primary key (IdSocioDisciplina),
	constraint fk_socio foreign key(IdSocio) references socio(IdSocio) on delete cascade,
	constraint fk_disciplina foreign key(IdDisciplina) references disciplina(IdDisciplina)
);

create table noSocioDisciplina(
	IdNoSocioDisciplina int auto_increment,
	IdNoSocio int,
    IdDisciplina int,
    constraint pk_noSocioDisciplina primary key (IdNoSocioDisciplina),
	constraint fk_noSocio foreign key(IdNoSocio) references noSocio(IdNoSocio) on delete cascade,
	constraint fk_ndisciplina foreign key(IdDisciplina) references disciplina(IdDisciplina)
);

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
/*Tablas de Usuarios del Sistema*/
/*-------------------------------------------------------------------------------------------------------------------------------------------------*/

/* table if exists usuario;
drop table if exists roles;*/

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
/*Procedimientos Almacenados*/
/*-------------------------------------------------------------------------------------------------------------------------------------------------*/

DELIMITER $$
CREATE PROCEDURE GetSocioPorDNI(in d INT)
BEGIN 
    
SELECT * FROM socio WHERE dni = d;

END$$

DELIMITER $$
CREATE PROCEDURE GetNoSocioPorDNI(in d INT)
BEGIN 
    
SELECT * FROM nosocio WHERE dni = d;

END$$

DELIMITER $$
CREATE PROCEDURE EliminarSocioPorDNI(in d INT)
BEGIN 
	DECLARE ID INT;
    DECLARE IDDIR INT;
    
SELECT IdSocio, IdDireccion INTO ID, IDDIR FROM socio WHERE Dni = d; 
DELETE FROM sociodisciplina WHERE IdSocio = ID;
DELETE FROM socio where IdSocio = ID;
DELETE FROM direccion WHERE IdDireccion = IDDIR;

END$$

DELIMITER $$
CREATE PROCEDURE EliminarNoSocioPorDNI(in d INT)
BEGIN 
	DECLARE ID INT;
    DECLARE IDDIR INT;
    
SELECT IdNoSocio, IdDireccion INTO ID, IDDIR FROM noSocio WHERE Dni = d; 
DELETE FROM noSociodisciplina WHERE IdNoSocio = ID;
DELETE FROM noSocio where IdNoSocio = ID;
DELETE FROM direccion WHERE IdDireccion = IDDIR;

END$$

DELIMITER $$

CREATE PROCEDURE InscribirSocioActividad(IN d INT, idD INT)
BEGIN
    DECLARE idS INT;
    DECLARE resultMessage VARCHAR(255);

    SELECT IdSocio INTO idS FROM socio WHERE Dni = d;
    
    IF idS IS NOT NULL THEN

        IF NOT EXISTS ( SELECT 1 FROM sociodisciplina WHERE IdSocio = idS AND IdDisciplina = idD ) THEN
        
            INSERT INTO sociodisciplina (IdSocio, IdDisciplina) VALUES (idS, idD);
            SET resultMessage = 'Inscripción de Socio realizada correctamente.';
        ELSE
      
            SET resultMessage = 'El socio ya está inscripto en la disciplina.';
        END IF;
    ELSE
   
        SET resultMessage = 'No se encontró un socio con ese DNI.';
    END IF;
    
    SELECT resultMessage AS Resultado;

END $$

DELIMITER $$

CREATE PROCEDURE InscribirNoSocioActividad(IN d INT, idD INT)
BEGIN
    DECLARE idS INT;
    DECLARE resultMessage VARCHAR(255);

    SELECT IdNoSocio INTO idS FROM nosocio WHERE Dni = d;
    
    IF idS IS NOT NULL THEN

        IF NOT EXISTS ( SELECT 1 FROM nosociodisciplina WHERE IdNoSocio = idS AND IdDisciplina = idD ) THEN
        
            INSERT INTO nosociodisciplina (IdNoSocio, IdDisciplina) VALUES (idS, idD);
            SET resultMessage = 'Inscripción de No Socio realizada correctamente.';
        ELSE
      
            SET resultMessage = 'El No Socio ya está inscripto en la disciplina.';
        END IF;
    ELSE
   
        SET resultMessage = 'No se encontró un socio con ese DNI.';
    END IF;
    
    SELECT resultMessage AS Resultado;

END $$

DELIMITER $$

CREATE PROCEDURE ConsultarDisciplinasPorDNI(in d INT)
BEGIN

    DECLARE ID INT;

    SELECT idSocio INTO ID FROM socio WHERE dni = d;

    IF ID IS NOT NULL THEN
        SELECT sd.idSocio, di.idDisciplina, di.Nombre, di.ArancelMensual, p.Nombres, p.Apellidos, h.dia, h.horaInicio, h.horaFin
        FROM socio s
        JOIN sociodisciplina sd ON s.idSocio = sd.idSocio
        JOIN disciplina di ON sd.idDisciplina = di.idDisciplina
        JOIN profesor p ON di.idProfesor = p.idProfesor
        JOIN horario h ON di.idDisciplina = h.idDisciplina
        WHERE s.dni = d;

    ELSE
        SELECT idNosocio INTO ID FROM nosocio WHERE dni = d;

        IF ID IS NOT NULL THEN
            SELECT nd.idNoSocio, di.idDisciplina, di.Nombre, di.ArancelMensual, p.Nombres, p.Apellidos, h.dia, h.horaInicio, h.horaFin
            FROM nosocio s
            JOIN nosociodisciplina nd ON s.idNoSocio = nd.idNoSocio
            JOIN disciplina di ON nd.idDisciplina = di.idDisciplina
            JOIN profesor p ON di.idProfesor = p.idProfesor
            JOIN horario h ON di.idDisciplina = h.idDisciplina
            WHERE s.dni = d;
        END IF;
    END IF;

END$$
$

DELIMITER $$
CREATE PROCEDURE DesinscribirActividad(in d INT, idD INT)
BEGIN 
    
delete from sociodisciplina sd where (select s.idSocio from socio s where dni=d) = idSocio and idDisciplina = idD;
delete from nosociodisciplina nd where (select n.idNoSocio from nosocio n where dni=d) = idNoSocio and idDisciplina = idD;

END$$

DELIMITER $$

CREATE PROCEDURE ConsultarCuotaDiaria(IN d INT)
BEGIN
    DECLARE cuotaMensual DOUBLE;
    
    select sum(ArancelMensual) into cuotamensual from socio s 
    join sociodisciplina sd on s.idSocio=sd.idSocio 
    join disciplina d on sd.idDisciplina = d.idDisciplina 
    where s.dni=d;
    
    IF cuotaMensual IS NULL THEN
        select sum(ArancelMensual) into cuotamensual from nosocio n 
		join nosociodisciplina nd on n.idNoSocio = nd.idNoSocio 
		join disciplina d on nd.idDisciplina = d.idDisciplina 
		where n.dni=d;
    END IF;

    SELECT cuotaMensual / 30 AS CuotaDiaria;
END$$

DELIMITER $$

CREATE PROCEDURE ConsultarCuotaMensual(IN d INT)
BEGIN
    DECLARE cuotaMensual DOUBLE;
    
    select sum(ArancelMensual) into cuotamensual from socio s 
    join sociodisciplina sd on s.idSocio=sd.idSocio 
    join disciplina d on sd.idDisciplina = d.idDisciplina 
    where s.dni=d;
    
    IF cuotaMensual IS NULL THEN
        select sum(ArancelMensual) into cuotamensual from nosocio n 
		join nosociodisciplina nd on n.idNoSocio = nd.idNoSocio 
		join disciplina d on nd.idDisciplina = d.idDisciplina 
		where n.dni=d;
    END IF;

    SELECT cuotaMensual;
END$$

DELIMITER $$

CREATE PROCEDURE AbonarCuotaDiaria(IN d INT)
BEGIN
    DECLARE ids INT;
    DECLARE idn INT;

    SELECT IdSocio into ids FROM socio WHERE Dni = d;
    SELECT IdNoSocio into idn FROM noSocio WHERE Dni = d;

    IF ids IS NOT NULL THEN
        UPDATE socio SET venceCuota = DATE_ADD(venceCuota, INTERVAL 1 DAY)
        WHERE IdSocio = ids;
    ELSEIF idn IS NOT NULL THEN
        UPDATE noSocio SET venceCuota = DATE_ADD(venceCuota, INTERVAL 1 DAY)
        WHERE IdNoSocio = idn;
    END IF;
END$$

DELIMITER $$

CREATE PROCEDURE AbonarCuotaMensual(IN d INT)
BEGIN
    DECLARE ids INT;
    DECLARE idn INT;

    SELECT idSocio into ids FROM socio WHERE dni = d;
    SELECT idNoSocio into idn FROM noSocio WHERE dni = d;

    IF ids IS NOT NULL THEN
        UPDATE socio SET venceCuota = DATE_ADD(venceCuota, INTERVAL 1 MONTH)
        WHERE IdSocio = ids;
    ELSEIF idn IS NOT NULL THEN
        UPDATE noSocio SET venceCuota = DATE_ADD(venceCuota, INTERVAL 1 MONTH)
        WHERE IdNoSocio = idn;
    END IF;
    
END$$

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
/*Insercion de Datos para ejemplo*/
/*-------------------------------------------------------------------------------------------------------------------------------------------------*/

insert into roles values
(120,'Administrador'),
(121,'Empleado');

insert into usuario(NombreUsu,PassUsu,RolUsu) values
('Juan','Juan123',121),
('Jose','Jose456',121),
('Luis','Luis789',121),
('Ramon','Ramon000',120);

insert into direccion(calle, altura, NPiso, NDepto, Barrio, Localidad) values
('Av. Siempre Viva', 123, 3, 4, 'San Nicolas', 'CABA'),
('Av. Libertador', 1123, 13, 2, 'Monserrat', 'CABA'),
('Av. Lugones', 334, 5, 1, 'Wilde', 'Avellaneda'),
('José Marmol', 776, null, null, 'Santa Marta', 'L. de Zamora'),
('Av. Corrientes', 432, null, null, 'Sarandí', 'Avellaneda'),
('Los Alamos', 23, 2, 4, 'Villa Dominico', 'Avellaneda'),
('Eva Peron', 99, 5, 2, 'Constitución', 'CABA'),
('Los Robles', 1432, 4, 1, 'Retiro', 'CABA'),
('Reconquista', 6587, 6, 2, 'Belgrano', 'CABA'),
('Av. Juan de Garay', 333, null, null, 'Palomar', 'Palomar'),
('San Martín', 1540, 3, 2, 'Almagro', 'CABA'),
('Pueyrredón', 789, 1, 1, 'Caballito', 'CABA'),
('Leandro N. Alem', 456, 4, 3, 'Recoleta', 'CABA'),
('Mitre', 987, 6, 1, 'Villa Urquiza', 'CABA'),
('Rivadavia', 2432, null, null, 'Liniers', 'CABA'),
('Belgrano', 1234, 2, 4, 'Lanús Este', 'Lanús'),
('Las Heras', 678, 3, 5, 'Puerto Madero', 'CABA'),
('Independencia', 432, 4, 2, 'Quilmes', 'Quilmes'),
('Rosales', 900, 5, 1, 'San Fernando', 'San Fernando'),
('Santa Fe', 233, null, null, 'Morón', 'Morón'),
('Alem', 444, 1, 1, 'Barracas', 'CABA'),
('Balcarce', 1290, 6, 3, 'San Telmo', 'CABA'),
('Juan B. Justo', 1120, null, null, 'Lomas de Zamora', 'L. de Zamora'),
('Mariano Acosta', 877, 2, 2, 'Temperley', 'L. de Zamora'),
('Dorrego', 345, 3, 4, 'San Cristóbal', 'CABA'),
('Hipólito Yrigoyen', 999, 2, 3, 'Berazategui', 'Berazategui'),
('Sarmiento', 1045, null, null, 'Tigre', 'Tigre'),
('San Lorenzo', 202, 1, 2, 'Villa del Parque', 'CABA'),
('Córdoba', 554, 4, 1, 'Villa Crespo', 'CABA'),
('San Juan', 876, null, null, 'Monte Grande', 'E. Echeverría');

insert into socio (IdDireccion, Dni, Nombres, Apellidos, Nacionalidad, venceCuota) values
(1, 23156789, 'Juan Pablo', 'Escobar', 'Argentina', '2024-10-01'),  
(2, 24567890, 'Ana María', 'Fernández', 'Uruguay', '2024-10-02'),   
(3, 25789012, 'Carlos', 'González Calvo', 'Chile', '2024-09-30'),  
(4, 26789123, 'María José', 'Rodríguez', 'Paraguay', '2024-10-15'), 
(5, 27891234, 'Luis Alberto', 'Pérez', 'Argentina', '2024-10-20'), 
(6, 28912345, 'Javier', 'Gutiérrez', 'Bolivia', '2024-10-25'),      
(7, 30123456, 'Sofía', 'López Esquibel', 'Perú', '2024-11-12'),   
(8, 31234567, 'Martín', 'Martínez', 'Argentina', '2024-11-15'),  
(9, 32345678, 'Laura', 'Vega', 'Ecuador', '2024-11-18'),          
(10, 33456789, 'Roberto', 'Ramírez', 'Brasil', '2024-10-18');  

insert into noSocio(IdDireccion, Dni, Nombres, Apellidos, Nacionalidad, venceCuota) values
(11, 34123456, 'Marcos', 'Alonso', 'Argentina', '2024-10-01'),  
(12, 35234567, 'Elena', 'Martínez', 'Uruguay', '2024-10-05'),   
(13, 36345678, 'Federico', 'Pineda', 'Chile', '2024-09-28'),    
(14, 37456789, 'Gabriela', 'Suárez', 'Paraguay', '2024-10-15'), 
(15, 38567890, 'Mario', 'Cabrera', 'Argentina', '2024-10-20'),  
(16, 39678901, 'Victoria', 'Ramírez', 'Bolivia', '2024-10-25'), 
(17, 40789012, 'Esteban', 'Córdoba', 'Perú', '2024-11-12'),      
(18, 41890123, 'Agustina', 'Vázquez', 'Argentina', '2024-11-15'), 
(19, 42901234, 'Diego', 'Gómez', 'Ecuador', '2024-11-18'),        
(20, 43123456, 'Natalia', 'Fuentes', 'Brasil', '2024-10-18');

insert into profesor(IdDireccion, NMatricula, Dni, Nombres, Apellidos, Nacionalidad) values
(21, 123456, 40123456, 'Gustavo', 'Reyes', 'Argentina'),
(22, 234567, 41234567, 'Natalia', 'Muñoz', 'Uruguay'),
(23, 345678, 42345678, 'Claudio', 'Martín', 'Chile'),
(24, 456789, 43456789, 'Laura', 'Suárez', 'Paraguay'),
(25, 567890, 44567890, 'Julio', 'Gómez', 'Argentina'),
(26, 678901, 45678901, 'Marcela', 'López', 'Bolivia'),
(27, 789012, 46789012, 'Cristina', 'Ortiz', 'Perú'),
(28, 890123, 47890123, 'Santiago', 'Vargas', 'Argentina'),
(29, 901234, 48901234, 'Lucía', 'Pérez', 'Ecuador'),
(30, 233345, 49012345, 'Roberto', 'Alvarez', 'Brasil');

insert into disciplina (Nombre, IdProfesor, ArancelMensual, MaxInscriptos) values
('Fútbol', 1, 3000.00, 20),
('Natación', 2, 3500.00, 15),
('Básquet', 3, 3200.00, 25),
('Tenis', 4, 4000.00, 10),
('Yoga', 5, 2500.00, 30);

insert into Horario (IdDisciplina, Dia, HoraInicio, HoraFin) values
(1,'Lunes', '18:00:00', '20:00:00'),
(1,'Miércoles', '18:00:00', '20:00:00'),
(2,'Martes', '19:00:00', '21:00:00'),
(2,'Jueves', '19:00:00', '21:00:00'),
(3,'Viernes', '17:00:00', '19:00:00'),
(3,'Sábado', '10:00:00', '12:00:00'),
(4,'Lunes', '09:00:00', '11:00:00'),
(4,'Miércoles', '09:00:00', '11:00:00'),
(5,'Martes', '08:00:00', '10:00:00'),
(5,'Jueves', '08:00:00', '10:00:00');

insert into socioDisciplina (IdSocio, IdDisciplina) values
(100001, 1), (100002, 1), (100003, 1),  
(100004, 2), (100005, 2), (100006, 2),  
(100007, 3), (100008, 3), (100009, 3),  
(100010, 4), (100001, 4), (100002, 4),  
(100003, 5), (100004, 5), (100005, 5);  

insert into noSocioDisciplina (IdNoSocio, IdDisciplina) values
(1, 1), (2, 1), (3, 1),  
(4, 2), (5, 2), (6, 2),  
(7, 3), (8, 3), (9, 3),  
(10, 4), (1, 4), (2, 4),  
(3, 5), (4, 5), (5, 5); 

