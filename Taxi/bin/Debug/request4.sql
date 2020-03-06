CREATE TABLE temp_table (
temp DateTIME,
CarNumber INT
);
  
	DECLARE @mov INT 
	DECLARE @count INT 
	DECLARE @dav DateTime
	SET @mov = (select count(DISTINCT Номер_маршрутки) FROM Маршрутки where id_маршрута = '7')
 
	while @mov > 0
	BEGIN
	
		SET @mov = @mov - 1
		
		SET @count = (select DISTINCT (Номер_маршрутки) from Маршрутки where id_маршрута = '7' ORDER BY Номер_маршрутки OFFSET @mov ROWS FETCH NEXT 1 ROWS ONLY)
		SET @dav = (SELECT Фактическое_время_прибытия from Фиксация_маршрутки WHERE Номер_маршрутки = @count and id_типа_маршрута = '1')
		insert into temp_table (temp, CarNumber) values ((select datediff(minute, (select MAX(@dav)), (select MIN(@dav)))), @count)

	END;
	
	SELECT Фамилия, Имя, Отчество FROM Водителя WHERE id_водителя = (SELECT id_водителя FROM Маршрутки WHERE Номер_маршрутки = (SELECT carNumber FROM temp_table WHERE temp = (SELECT max(temp) FROM temp_table)));

DROP TABLE temp_table;
