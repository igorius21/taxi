SET DATEFORMAT YMD
select 
	(select sum(Количество_вошедших_пассажиров) from Фиксация_маршрутки where Номер_маршрутки = 
		(select Номер_маршрутки from Маршрутки where id_маршрута = '7') 
			and Дата between '2019-09-21' and '2019-09-22') *
(select Стоимость_маршрута FROM Маршруты where id_маршрута = '7') * 
(select count(Номер_маршрутки) from Маршрутки where id_маршрута = '7') / 
(select datediff(day, '2019-09-22', '2019-09-21') + 1);