CREATE TABLE pais (
    Id int PRIMARY KEY AUTO_INCREMENT,
    NombrePais varchar(50)
);

ALTER TABLE pais RENAME TO country;

CREATE TABLE departamento (
    Id int PRIMARY KEY AUTO_INCREMENT,
    NombreDepartamento varchar(50),
    IdDepartamentoFk int NOT NULL,
    CONSTRAINT FOREIGN KEY(IdDepartamentoFk) REFERENCES pais (Id)
);

ALTER TABLE departamento RENAME TO state;

ALTER TABLE departamento 
RENAME COLUMN IdDepartamentoFk TO IdPaisFk;

CREATE TABLE ciudad (
    Id int PRIMARY KEY AUTO_INCREMENT,
    NombreCiudad varchar(50) NOT NULL,
    IdDepartamentoFk int NOT NULL, 
    CONSTRAINT FOREIGN KEY(IdDepartamentoFk) REFERENCES departamento (Id)
);

ALTER TABLE ciudad RENAME TO city;

CREATE TABLE raza (
    Id int PRIMARY KEY AUTO_INCREMENT,
    NombreRaza varchar(50) NOT NULL
);

ALTER TABLE raza RENAME TO breed;

CREATE TABLE servicio(
    Id int PRIMARY KEY AUTO_INCREMENT,
    Nombre varchar(50) NOT NULL,
    Precio double(11,2) NOT NULL
);

ALTER TABLE servicio RENAME TO service;

CREATE TABLE cliente(
    Id int PRIMARY KEY  AUTO_INCREMENT,
    Nombre varchar(50) NOT NULL,
    Apellidos varchar(50) NOT NULL, 
    Email varchar(50) NOT NULL
);

ALTER TABLE cliente RENAME TO client;

CREATE TABLE clienteTelefono(
    Id int PRIMARY KEY AUTO_INCREMENT,
    Numero varchar(50) NOT NULL,
    IdClienteFk int NOT NULL,
    CONSTRAINT FOREIGN KEY(IdClienteFk) REFERENCES cliente (Id)
);

ALTER TABLE clienteTelefono RENAME TO clientPhone;

CREATE TABLE clienteDireccion(
    Id int PRIMARY KEY AUTO_INCREMENT,
    TipoVia varchar(10) NOT NULL,
    NumeroPri int NOT NULL,
    Letra varchar(10) NOT NULL,
    Bis varchar(10) NOT NULL,
    LetraSec varchar(10) NOT NULL,
    Cardinal varchar(10) NOT NULL,
    NumeroSec int NOT NULL,
    LetraTer varchar(10) NOT NULL,
    NumeroTer int NOT NULL,
    CardinalSec varchar(10) NOT NULL,
    Complemento varchar(50) NOT NULL,
    CodigoPostal varchar(50) NOT NULL,
    IdClienteFk int NOT NULL,
    IdCiudadFk int NOT NULL,
    CONSTRAINT FOREIGN KEY(IdClienteFk) REFERENCES cliente (Id),
    CONSTRAINT FOREIGN KEY(IdCiudadFk) REFERENCES ciudad (Id)
);

ALTER TABLE clienteDireccion RENAME TO clientAddress;

CREATE TABLE mascota (
    Id Int PRIMARY KEY AUTO_INCREMENT,
    Nombre varchar(50) NOT NULL,
    Especie varchar(50) NOT NULL,
    FechaNacimiento date NOT NULL,
    IdRazaFk int NOT NULL,
    IdClienteFk int NOT NULL,
    CONSTRAINT FOREIGN KEY(IdRazaFk) REFERENCES raza (Id),
    CONSTRAINT FOREIGN KEY(IdClienteFk) REFERENCES cliente (Id)
);

ALTER TABLE mascota RENAME TO pet;

CREATE TABLE cita (
    Id int PRIMARY KEY AUTO_INCREMENT,
    Fecha date NOT NULL,
    Hora time NOT NULL, 
    IdClienteFk int NOT NULL,
    IdMascotaFk int NOT NULL,
    IdServicioFk int NOT NULL,
    CONSTRAINT FOREIGN KEY(IdClienteFk) REFERENCES cliente (Id),
    CONSTRAINT FOREIGN KEY(IdMascotaFk) REFERENCES mascota (Id),
    CONSTRAINT FOREIGN KEY(IdServicioFk) REFERENCES servicio (Id)
);

ALTER TABLE cita RENAME TO appointment;

CREATE TABLE user(
    Id int PRIMARY KEY AUTO_INCREMENT,
    UserName varchar(100) NOT NULL,
    Email varchar(100) NOT NULL,
    Password varchar(150) NOT NULL
);

CREATE TABLE rol(
    Id int PRIMARY KEY AUTO_INCREMENT,
    Nombre varchar(150) NOT NULL
);

CREATE TABLE refreshToken (
    Id int PRIMARY KEY AUTO_INCREMENT,
    Token varchar(250) NOT NULL,
    Expires datetime NOT NULL,
    Created datetime NOT NULL,
    Revoked datetime,
    IdUserfK int NOT NULL,
    CONSTRAINT FOREIGN KEY(IdUserfK) REFERENCES user(Id)
);

CREATE TABLE userRol (
    IdUser int NOT NULL,
    IdRol int NOT NULL,
    CONSTRAINT PRIMARY KEY (IdUser, IdRol),
    CONSTRAINT FOREIGN KEY(IdUser) REFERENCES user(Id),
    CONSTRAINT FOREIGN KEY(IdRol) REFERENCES rol(Id)
);