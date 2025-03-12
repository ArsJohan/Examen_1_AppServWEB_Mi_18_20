USE master;
GO

CREATE DATABASE VentasVivienda;
GO
USE VentasVivienda;

CREATE TABLE Agencia(
codigo INT PRIMARY KEY,
nombre VARCHAR(255),
sede VARCHAR(255)
);
GO

CREATE TABLE Cliente(
codigo INT PRIMARY KEY,
nombre VARCHAR(255),
apellido VARCHAR(255),
telefono VARCHAR(255),
correo VARCHAR(255)
);
GO

CREATE TABLE TipoVivienda(
codigo INT PRIMARY KEY,
nombre VARCHAR(255),
activo BIT
);
GO

CREATE TABLE Vivienda (
    codigo INT PRIMARY KEY,
    numBanos VARCHAR(255),
    numCuartos VARCHAR(255),
    tamano INT,
    numPisos INT,
    accessories TEXT,
    precio FLOAT,
    tipoVi INT,
    FOREIGN KEY (tipoVi) REFERENCES TipoVivienda(codigo)
);
GO

CREATE TABLE Venta (
    codigo INT PRIMARY KEY,
    fechaCompra DATETIME,
    valor FLOAT,
    cliente INT,
    agencia INT,
    vivienda INT,
    FOREIGN KEY (cliente) REFERENCES Cliente(codigo),
    FOREIGN KEY (agencia) REFERENCES Agencia(codigo),
    FOREIGN KEY (vivienda) REFERENCES Vivienda(codigo)
);
GO

INSERT INTO Agencia (codigo,nombre,sede) VALUES (1,'Ventas de viviendas ITM','Medellin');

INSERT INTO Cliente (codigo, nombre, apellido, telefono, correo) VALUES (1,'Yeison','Sanchez','3105316232', 'yeisonSanchez@gmail.com'),
(2,'Johan','Arias','3207871336','johanarias111@gmail.com'),(3,'Ivan','Morales','3145679897','ivan@gmail.com');

INSERT INTO TipoVivienda (codigo,nombre,activo) VALUES (1,'Casa',1),(2,'Apartamento',1),(3,'Finca',1);

INSERT INTO Vivienda (codigo,numBanos,numCuartos,tamano,numPisos,accessories,precio,tipoVi) VALUES
(1,3,4,300,3,'2 patios',500000000,1),(2,2,3,400,1,'jardin, piscina',600000000,2),(3,1,2,240,1,'piscina',200000000,1);


INSERT INTO Venta (codigo, fechaCompra, valor, cliente,agencia,vivienda) VALUES
(1,'2025-01-12',500000000,1,1,1),(2,'2025-01-24',600000000,2,1,2),(3,'2025-02-14',200000000,3,1,3);

