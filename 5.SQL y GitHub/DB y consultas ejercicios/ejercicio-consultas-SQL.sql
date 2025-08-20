--Consultas SQL

--LEER
--where(Es como una condicion)
--Select * from TIPOSEDICION
--Select * from DISCOS
--Select Titulo, CantidadCanciones from DISCOS, ESTILOS
--select * From ESTILOS
--where idestilo = 2 AND CantidadCanciones = 12
--Select D.Titulo, D.CantidadCanciones, E.Descripcion from DISCOS D, ESTILOS E
--where D.Id = E.Id


--ESCRIBIR / INSERTAR
--insert into DISCOS (Titulo, CantidadCanciones) values ('El titulo...', 10)
--insert into DISCOS values ('el titulo...', getdate(), 10, '',1, 2)


--MODIFICAR
--importante poner el where al actualizar un solo elemento
--update ESTILOS set Descripcion = 'Country' where id = 1

--ELIMINAR 
--importante poner el where para no eliminar todo
--delete from DISCOS where id = 7

--EJERCICIO
--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, 
--Estilo (no el id, sino la descripción). L
--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. L 
--3. Insertar al menos dos discos nuevos cargando correctamente su información. L
--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where. L
--5. Borrar un disco a elección. L
--6. Traer todos los estilos que estén asociados a algún disco. L
--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto). L
--8. Traer todos los discos que contengan en su nombre la sílaba "ho". L

--(1)----------------------------------
--Select D.Titulo, D.FechaLanzamiento, E.Descripcion From DISCOS D, ESTILOS E


--(2)----------------------------------
--select * from ESTILOS
--insert into ESTILOS values ('rock and roll')
--insert into ESTILOS values ('rockabilly')
--insert into ESTILOS values ('blues rock')
--select * from TIPOSEDICION
--insert into TIPOSEDICION values ('MP3')
--insert into TIPOSEDICION values ('WAV')
--insert into TIPOSEDICION values ('FLAC')
--insert into TIPOSEDICION values ('Streaming')


--(3)----------------------------------
--insert into DISCOS values ('Elvis Presley','1956/03/23 00:00:00', 12, 'https://upload.wikimedia.org/wikipedia/en/thumb/f/f5/Elvis_Presley_LPM-1254_Album_Cover.jpg/250px-Elvis_Presley_LPM-1254_Album_Cover.jpg', 5, 1)
--insert into DISCOS values ('Wheels of Fire','1968/06/14 00:00:00', 13, 'https://m.media-amazon.com/images/I/71eBU0HvXlL._UF1000,1000_QL80_.jpg', 7, 2)
--insert into DISCOS values ('The Sun Sessions','1976/03/21', 14, 'https://akamai.sscdn.co/uploadfile/letras/albuns/4/1/8/e/58371443638227.jpg', 6, 2)
--Select * from DISCOS


--(4)----------------------------------
--update DISCOS set CantidadCanciones = 23 where id = 12
--update DISCOS set FechaLanzamiento = '1999/01/01' where id = 11


--(5)----------------------------------
--delete from DISCOS where id = 10


--(6)----------------------------------
--select * from ESTILOS


--(7)----------------------------------
--select D.Titulo, E.Descripcion, T.Descripcion from DISCOS D, ESTILOS E, TIPOSEDICION T


--(8)----------------------------------
--select * From DISCOS
--where LOWER(Titulo) LIKE '%Ho%'