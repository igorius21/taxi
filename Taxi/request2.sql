CREATE TABLE temp_table (
temp DATETIME

)



DECLARE @starttime DATETIME 
DECLARE @endtime DATETIME 
DECLARE @router int
DECLARE @mov INT
SET @mov = (select count(DISTINCT id_маршрута) from Расписание where id_типа_маршрута = '1')

WHILE @mov > 0
	BEGIN
	
		SET @mov = @mov - 1
		
		SET @router = (select distinct (id_маршрута) from Расписание where id_типа_маршрута = '1' 
ORDER BY id_маршрута OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY)
		
		SET @starttime = (select max(Плановое_время_прибытия) from Расписание where id_маршрута = @router)
			
				
		SET @endtime = (select min(Плановое_время_прибытия) from Расписание where id_маршрута = @router)

				
		insert into temp_table (temp) VALUES ((select DATEDIFF(hour, @starttime, @endtime)))

	END;

SELECT min(temp) FROM temp_table;
SELECT max(temp) FROM temp_table;

DROP TABLE temp_table;