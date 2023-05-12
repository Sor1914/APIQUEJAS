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
	Fecha_Creacion DATETIME DEFAULT CURRENT_TIMESTAMP,
	Usuario_Creo VARCHAR(20),
	Fecha_Modifico Datetime,
	Usuario_Modifico VARCHAR(20),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Rol(Nombre_Rol, Estado, Usuario_Creo) VALUES ('ADMINISTRADOR', 'A', 'Sistema');
INSERT INTO Rol(Nombre_Rol, Estado, Usuario_Creo) VALUES ('CENTRALIZADOR', 'A', 'Sistema');
INSERT INTO Rol(Nombre_Rol, Estado, Usuario_Creo) VALUES ('RECEPTOR', 'A', 'Sistema');
INSERT INTO Rol(Nombre_Rol, Estado, Usuario_Creo) VALUES ('CUENTAHABIENTE', 'A', 'Sistema');
INSERT INTO Rol(Nombre_Rol, Estado, Usuario_Creo) VALUES ('CONSULTA', 'A', 'Sistema');


SELECT * FROM USUARIO WHERE USUARIO = '{0}'


CREATE TABLE Cargo(
	Id_Area INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Cargo VARCHAR(15),
	Fecha_Creacion DATETIME DEFAULT CURRENT_TIMESTAMP,
	Usuario_Creo VARCHAR(20),
	Fecha_Modifico Datetime,
	Usuario_Modifico VARCHAR(20),
	Estado VARCHAR(1) DEFAULT 'A'
);

SELECT * FROM CARGO
INSERT INTO Cargo(Nombre_Cargo, Estado, Usuario_Creo) VALUES ('NOASIGNADO','A','Sistema');
INSERT INTO Cargo(Nombre_Cargo, Estado, Usuario_Creo) VALUES ('TITULAR','A','Sistema');
INSERT INTO Cargo(Nombre_Cargo, Estado, Usuario_Creo) VALUES ('SUPLENTE','A','Sistema');
INSERT INTO Cargo(Nombre_Cargo, Estado, Usuario_Creo) VALUES ('ENCARGADO','A','Sistema');
INSERT INTO Cargo(Nombre_Cargo, Estado, Usuario_Creo) VALUES ('JEFE INMEDIATO','A','Sistema');
INSERT INTO Cargo(Nombre_Cargo, Estado, Usuario_Creo) VALUES ('RECEP DE QUEJAS','A','Sistema');
INSERT INTO Cargo(Nombre_Cargo, Estado, Usuario_Creo) VALUES ('CENT DE QUEJAS','A','Sistema');

select * from usuario

UPDATE USUARIO SET Id_Punto_Atencion = 2, Id_Cargo = 2 WHERE Cui = 3034719480109

CREATE TABLE Cuenta(
	Id_Cuenta INT NOT NULL IDENTITY PRIMARY KEY,
	Tipo_Cuenta VARCHAR(3), 
	Numero_Cuenta VARCHAR(25),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Cuenta(Tipo_Cuenta, Numero_Cuenta, Estado) VALUES('AHO','123','A');

CREATE TABLE Region(
	Id_Region INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Region VARCHAR(15),
	Fecha_Creacion DATETIME DEFAULT CURRENT_TIMESTAMP,
	Usuario_Creo VARCHAR(20),
	Fecha_Modifico Datetime,
	Usuario_Modifico VARCHAR(20),
	Estado VARCHAR(1) DEFAULT 'A'
);

INSERT INTO Region(Nombre_Region, Estado, Usuario_Creo) VALUES ('CENTRAL', 'A','Sistema');
INSERT INTO Region(Nombre_Region, Estado, Usuario_Creo) VALUES ('SUR', 'A','Sistema');
INSERT INTO Region(Nombre_Region, Estado, Usuario_Creo) VALUES ('NORORIENTE', 'A','Sistema');
INSERT INTO Region(Nombre_Region, Estado, Usuario_Creo) VALUES ('OCCIDENTE', 'A','Sistema');

CREATE TABLE Punto_Atencion(
	Id_Punto_Atencion INT NOT NULL IDENTITY PRIMARY KEY,
	Nombre_Punto_Atencion VARCHAR (50),
	Id_Region INT FOREIGN KEY REFERENCES Region(Id_Region),
	Estado VARCHAR(1) DEFAULT 'A'
);


select * FROM Punto_Atencion
INSERT INTO Punto_Atencion(Nombre_Punto_Atencion, Id_Region, Estado)
Values('NOASIGNADO', 1, 'A')
INSERT INTO Punto_Atencion(Nombre_Punto_Atencion, Id_Region, Estado)
Values('CENTRALIZADOR', 1, 'A')

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
	Nombre VARCHAR(50),	
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
	Query VARCHAR(1000),
	Opcion VARCHAR(30),
	Usuario VARCHAR(15),	
	Fecha DATETIME DEFAULT CURRENT_TIMESTAMP,		
);







INSERT INTO Usuario(Usuario, Pass, Nombres, Apellidos, Email, Cui, Departamento, Id_Rol, Id_Cargo, Id_Punto_Atencion, Estado)
VALUES ('JSOR',ENCRYPTBYPASSPHRASE('JS0R', 'Jonathansor200066' ),'Jonathan','Sor','Jonathansor2000sm@gmail.com','3034719480109','Guatemala',1,1,1,'A');





SELECT * FROM Punto_Atencion 
UPDATE Punto_Atencion SET ESTADO = 'A'

SELECT * FROM REGION WHERE Estado = 'A'

SELECT * FROM Punto_Atencion WHERE ESTADO = 'A' AND Id_Region = '1' 


//Obtener usuarios asociados al punto de atención
SELECT Usuario, Cui, Nombres, Apellidos, CARGO.Nombre_Cargo  FROM USUARIO 
INNER JOIN CARGO
	ON CARGO.Id_Area = Id_Cargo 
WHERE USUARIO.Estado = 'A' AND Id_Punto_Atencion = '1'

select * FROM USUARIO 
UPDATE USUARIO SET ESTADO = 'A'

SELECT Id_Punto_Atencion IDPUNTOATENCION, Nombre_Punto_Atencion NOMBREPUNTOATENCION
FROM Punto_Atencion WHERE ID_REGION = {0} AND ESTADO = 'A'

SELECT Usuario.Id_Usuario, Cui, Nombres, Apellidos, CARGO.Nombre_Cargo, Punto_Atencion.Nombre_Punto_Atencion,
REGION.Nombre_Region, USUARIO.Id_Punto_Atencion, Punto_Atencion.Id_Region, usuario.Id_Cargo FROM USUARIO 
INNER JOIN CARGO
	ON CARGO.Id_Area = Id_Cargo 
INNER JOIN Punto_Atencion
	ON USUARIO.Id_Punto_Atencion = Punto_Atencion.Id_Punto_Atencion
INNER JOIN Region
	ON Punto_Atencion.Id_Region = REGION.Id_Region
WHERE USUARIO.Estado = 'A' AND USUARIO.Id_Punto_Atencion = {0} 

SELECT * FROM USUARIO 

UPDATE USUARIO SET Id_Punto_Atencion = {0}, Id_Cargo = {1}, Estado = '{2}' WHERE Id_Usuario = {3}

select * from Punto_Atencion

SELECT Usuario.Id_Usuario, Cui, Nombres, Apellidos, CARGO.Nombre_Cargo, Punto_Atencion.Nombre_Punto_Atencion,
REGION.Nombre_Region, USUARIO.Id_Punto_Atencion, Punto_Atencion.Id_Region, usuario.Id_Cargo FROM USUARIO 
INNER JOIN CARGO
	ON CARGO.Id_Area = Id_Cargo 
INNER JOIN Punto_Atencion
	ON USUARIO.Id_Punto_Atencion = Punto_Atencion.Id_Punto_Atencion
INNER JOIN Region
	ON Punto_Atencion.Id_Region = REGION.Id_Region
WHERE USUARIO.Estado = 'A' 

select Id_Area, Nombre_Cargo from cargo

select * from Punto_Atencion

SELECT Id_Punto_Atencion Id, Nombre_Punto_Atencion NombrePuntoAtencion, Id_Region
FROM Punto_Atencion WHERE ESTADO = 'A' AND Id_Punto_Atencion <> 1

SELECT Id_Punto_Atencion Id, Nombre_Punto_Atencion NombrePuntoAtencion, Id_Region
FROM Punto_Atencion WHERE ESTADO = 'A' AND Id_Punto_Atencion <> 1

SELECT Usuario.Id_Usuario, Cui, Nombres, Apellidos, CARGO.Nombre_Cargo, Punto_Atencion.Nombre_Punto_Atencion,
REGION.Nombre_Region, USUARIO.Id_Punto_Atencion, Punto_Atencion.Id_Region, usuario.Id_Cargo FROM USUARIO 
INNER JOIN CARGO
	ON CARGO.Id_Area = Id_Cargo 
INNER JOIN Punto_Atencion
	ON USUARIO.Id_Punto_Atencion = Punto_Atencion.Id_Punto_Atencion
INNER JOIN Region
	ON Punto_Atencion.Id_Region = REGION.Id_Region
WHERE USUARIO.Estado = 'A' 

SELECT Usuario.Usuario, Usuario.Id_Usuario, Cui, Nombres, Apellidos, CARGO.Nombre_Cargo, Punto_Atencion.Nombre_Punto_Atencion,
REGION.Nombre_Region, USUARIO.Id_Punto_Atencion, Punto_Atencion.Id_Region, usuario.Id_Cargo FROM USUARIO 
INNER JOIN CARGO
	ON CARGO.Id_Area = Id_Cargo 
INNER JOIN Punto_Atencion
	ON USUARIO.Id_Punto_Atencion = Punto_Atencion.Id_Punto_Atencion
INNER JOIN Region
	ON Punto_Atencion.Id_Region = REGION.Id_Region
WHERE USUARIO.Estado = 'A' 



SELECT Nombres, Apellidos, Email, Id_Cargo FROM USUARIO WHERE Estado = 'A' AND Cui = '{0}'
SELECT Id_Area, Nombre_Cargo FROM Cargo WHERE Estado = 'A'

SELECT * FROM BITACORA 

USE [QUEJAS]
GO

INSERT INTO [dbo].[Bitacora]
           ([Nombre_Tabla]
           ,[Registro_Antes]
           ,[Registro_Despues]
           ,[Tipo_Movimiento]
           ,[Usuario]
           ,[Email]
           ,[Fecha])
     VALUES
           ('{0}','{0}','{0}','{0}','{0}','{0}', CURRENT_TIMESTAMP)           


		  
		  INSERT INTO [dbo].[Bitacora]
           ([Nombre_Tabla]
           ,[Query]
           ,[Opcion]
           ,[Usuario]
           ,[Fecha])
     VALUES
           ('Punto_Atencion','UPDATE Punto_Atencion SET Estado = 'E' WHERE Id_Punto_Atencion = 4','Punto Atencion','JSOR', CURRENT_TIMESTAMP)

		   INSERT INTO [dbo].[Bitacora]
           ([Nombre_Tabla]
           ,[Query]
           ,[Opcion]
           ,[Usuario]
           ,[Fecha])
     VALUES
           ('Punto_Atencion','UPDATE Punto_Atencion SET Estado = "E" WHERE Id_Punto_Atencion = 4','Punto Atencion','JSOR', CURRENT_TIMESTAMP)


		   select * from Bitacora

		   select * from Usuario //9

		   update usuario set Id_Punto_Atencion = 1009 where Id_Usuario = 11
		   
		   select * from Bitacora

		   select * FROM Punto_Atencion

		   select * from Region

		   insert into region(Nombre_Region, Estado) 
		   values ('SUROCCIDENTE', 'A')


		  select * from usuario


SELECT Nombres, Apellidos, Email, Id_Cargo, Punto_Atencion.Nombre_Punto_Atencion, USUARIO.Id_Punto_Atencion FROM USUARIO 
INNER JOIN Punto_Atencion 
	ON Punto_Atencion.Id_Punto_Atencion = Usuario.Id_Punto_Atencion
WHERE Usuario.Estado = 'A' AND Cui = '{0}'

SELECT * FROM Punto_Atencion

SELECT * FROM Tipo_Queja


INSERT INTO Tipo_Queja(Siglas_Tipo, Nombre, Correlativo)
VALUES('{0}', '{1}', 0)


UPDATE Tipo_Queja SET NOMBRE = '{0}' WHERE Id_Tipo = {1}

UPDATE Tipo_Queja SET Estado = 'E' WHERE Id_Tipo = {1}



SELECT * FROM Tipo_Queja
select * FROM BITACORA

INSERT INTO Tipo_Queja(Siglas_Tipo, Nombre, Correlativo)
VALUES('QMP', 'Queja por mal servicio', 0)