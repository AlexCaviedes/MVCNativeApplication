USE sena
CREATE DATABASE sena

CREATE TABLE Aprendiz(
id INT IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(40) Not Null,
apellido VARCHAR(40) Not Null,
telefono VARCHAR(40) Not Null,
email VARCHAR(40) Not Null
)


CREATE PROCEDURE pa_cargar
AS
BEGIN
	SELECT*FROM Aprendiz
END
GO

CREATE PROCEDURE pa_insertar
@nombre VARCHAR(40),
@apellido VARCHAR(40),
@telefono VARCHAR(40),
@email VARCHAR(40)
AS
BEGIN
	INSERT INTO Aprendiz(nombre,apellido,telefono,email)VALUES(@nombre,@apellido,@telefono,@email);
END
GO

CREATE PROCEDURE pa_actualizar
@id INT,
@nombre VARCHAR(40),
@apellido VARCHAR(40),
@telefono VARCHAR(40),
@email VARCHAR(40)
AS
BEGIN
	UPDATE Aprendiz
	SET nombre=@nombre,apellido=@apellido,telefono=@telefono,email=@email
	WHERE id=@id;
END
GO

CREATE PROCEDURE pa_eliminar
@id int
AS
BEGIN
	DELETE Aprendiz WHERE id=@id
END
GO