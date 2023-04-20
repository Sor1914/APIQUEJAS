DROP TABLE Bitacora; 
DROP TABLE Detalle_Queja;
DROP TABLE Encabezado_Queja;
DROP TABLE Estado;
DROP TABLE Origen_Queja;
DROP TABLE Tipo_Queja;
DROP TABLE Usuario;
DROP TABLE Cargo; 
DROP TABLE Cuenta;
DROP TABLE Punto_Atencion; 
DROP TABLE Region; 
DROP TABLE Rol;  



CREATE TABLE Rol(
	Id_Rol INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Rol VARCHAR(15),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Rol(Nombre_Rol, Estado) VALUES ('GENERICO', 'A');

CREATE TABLE Cargo(
	Id_Area INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Cargo VARCHAR(15),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Cargo(Nombre_Cargo, Estado) VALUES ('CLIENTE','A');


CREATE TABLE Cuenta(
	Id_Cuenta INT NOT NULL IDENTITY PRIMARY KEY,
	Tipo_Cuenta VARCHAR(3), 
	Numero_Cuenta VARCHAR(25),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Cuenta(Tipo_Cuenta, Numero_Cuenta, Estado) VALUES('AHO','123456','A');

CREATE TABLE Region(
	Id_Region INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Region VARCHAR(15),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Region(Nombre_Region, Estado) VALUES ('PRUEBA', 'A');

CREATE TABLE Punto_Atencion(
	Id_Punto_Atencion INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Punto_Atencion VARCHAR (15),
	Id_Region INT FOREIGN KEY REFERENCES Region(Id_Region),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Punto_Atencion (Nombre_Punto_Atencion, Id_Region, Estado)
VALUES ('NoAsignado', 1, 'A');

CREATE TABLE Usuario(
     Id_Usuario int NOT NULL IDENTITY PRIMARY KEY,	 
	 Usuario VARCHAR(15),
	 Pass VARBINARY(MAX),
	 Nombres VARCHAR(20),
	 Apellidos VARCHAR(20),
	 Email VARCHAR(50),	 
	 Cui VARCHAR(15),
	 Departamento VARCHAR(15),
	 Id_Rol INT FOREIGN KEY REFERENCES Rol(Id_Rol),
	 Id_Cargo INT FOREIGN KEY REFERENCES Cargo(Id_Area),
	 Id_Punto_Atencion INT FOREIGN KEY REFERENCES Punto_Atencion(Id_Punto_Atencion),	 
	 Estado VARCHAR(1) DEFAULT 'A'
);

CREATE TABLE Tipo_Queja(
	Id_Tipo INT NOT NULL IDENTITY PRIMARY KEY,
	Siglas_Tipo VARCHAR(5),
	Nombre VARCHAR(15),	
	Correlativo INT,
	Estado VARCHAR(1) DEFAULT 'A'
);

CREATE TABLE Origen_Queja(
	Id_Origen INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre VARCHAR(5),
    Estado VARCHAR(1) DEFAULT 'A'
);


CREATE TABLE Estado(
	Id_Estado INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre VARCHAR(20),
	Estado VARCHAR(1) DEFAULT 'A'
);

CREATE TABLE Encabezado_Queja(
	Id_Encabezado INT NOT NULL IDENTITY PRIMARY KEY,
	Nombres VARCHAR(25),
	Apellidos VARCHAR(25),
	Email VARCHAR(50),
	Telefono VARCHAR(8),
	Id_Usuario INT FOREIGN KEY REFERENCES Usuario(Id_Usuario),
	Detalle VARCHAR(1000),
	Id_Estado_Externo INT FOREIGN KEY REFERENCES Estado(Id_Estado),
	Id_Estado_Interno INT FOREIGN KEY REFERENCES Estado(Id_Estado),
	Fecha_Ingreso DATETIME DEFAULT CURRENT_TIMESTAMP,
	Id_Tipo INT FOREIGN KEY REFERENCES Tipo_Queja(Id_Tipo),
	Ingreso_Queja VARCHAR(20),
	Id_Origen INT FOREIGN KEY REFERENCES Origen_Queja(Id_Origen),
	Direccion_Archivo VARCHAR(100),
	JUSTIFICACION VARCHAR(1000),
	Id_Punto_Atencion INT FOREIGN KEY REFERENCES Punto_Atencion(Id_Punto_Atencion),
	Respuesta VARCHAR(100),
);

CREATE TABLE Detalle_Queja(
	Id_Detalle INT NOT NULL IDENTITY PRIMARY KEY,
	Id_Encabezado INT FOREIGN KEY REFERENCES Encabezado_Queja(Id_Encabezado),
	Comentario VARCHAR(1000),
	Direccion_Archivo VARCHAR(100),
	Fecha_Detalle DATETIME DEFAULT CURRENT_TIMESTAMP,
    Id_Usuario INT FOREIGN KEY REFERENCES Usuario(Id_Usuario)
);

CREATE TABLE Bitacora(
	Id_Bitacora INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Tabla VARCHAR(15),
	Registro_Antes VARCHAR(1000),
	Registro_Despues VARCHAR(1000),
	Tipo_Movimiento VARCHAR(15),
	Usuario VARCHAR(15),
	Email VARCHAR(50),
	Fecha DATETIME DEFAULT CURRENT_TIMESTAMP,		
);




