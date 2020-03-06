CREATE TABLE temp_table (
temp DATETIME,
router INT
)
DECLARE @starttime DATETIME 
DECLARE @endtime DATETIME 
DECLARE @router INT 
DECLARE @mov INT 
SET @mov = (select count(DISTINCT id_маршрута) from Расписание where id_типа_маршрута = '1')

WHILE @mov > 0
	BEGIN 
	
		SET @mov = @mov - 1
		
		SET @router = (select distinct (id_маршрута) from Расписание where id_типа_маршрута = '1' 
			ORDER BY id_маршрута OFFSET @mov ROWS FETCH NEXT 1 ROWS ONLY)
		
		SET @starttime = (select max(Плановое_время_прибытия) from Расписание where id_маршрута = @router)
			
				
		SET @endtime = (select min(Плановое_время_прибытия) from Расписание where id_маршрута = @router)

				
		insert into temp_table (temp, router) VALUES ((select DATEDIFF(minute, @starttime, @endtime)), @router)

	END;


CREATE TABLE temp_table2 (
router INT
)
insert into temp_table2 (router) VALUES ((SELECT router FROM temp_table WHERE temp = (SELECT min(temp) FROM temp_table)));
insert into temp_table2 (router) VALUES ((SELECT router FROM temp_table WHERE temp = (SELECT max(temp) FROM temp_table)));

SELECT * from temp_table2;

DROP TABLE temp_table;
DROP TABLE temp_table2;