using System;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Taxi
{
    class DbType
    {
        static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\taxi6.mdf;Integrated Security=True;Connect Timeout=30";

        static int count;

        static SqlConnection conn = new SqlConnection(connectionString);
        public static SqlCommand command = conn.CreateCommand();

        public string Family { get; set; }
        public string Name { get; set; }
        public string Sername { get; set; }
        public DateTime Date { get; set; }
        public int NumberCar { get; set; }
        public string Mark { get; set; }
        public string Manufacture { get; set; }
        public int NumberRouter { get; set; }
        public int Cena { get; set; }
        public int NumberStop { get; set; }
        public string NumberName { get; set; }
        public int NumberDrive { get; set; }
        public string TypeRouter { get; set; }
        public string NameStop { get; set; }
        public DateTime timeDrive { get; set; }
        public int ManIn { get; set; }
        public DateTime DateDrive { get; set; }

        public int SqlRequest1()
        {
            command.CommandText = "IF '" + Date + "' < dateadd(yy,-3, GETDATE()) INSERT INTO Водителя (Фамилия, Имя, Отчество, Дата_получения_прав) VALUES ('" + Family + "', '" + Name + "', '" + Sername + "', '" + Date + "')";
            return connOpen();

        }

        public int SqlRequest2()
        {
            command.CommandText = "DELETE FROM Водителя WHERE Фамилия = '" + Family + "' AND Имя = '" + Name + "' AND Отчество = '" + Sername + "'";
            return connOpen();
        }

        public int SqlRequest3()
        {
            command.CommandText = "IF '" + Date + "' > dateadd(yy,-10, GETDATE()) INSERT INTO Маршрутки (Номер_маршрутки, id_владельца, Марка, Производитель, Дата_производства) VALUES (" + NumberCar + ", (select id_владельца from владельцы where Фамилия = '" + Family + "'), '" + Mark + "', '" + Manufacture + "', '" + Date + "')";
            return connOpen();
        }

        public int SqlRequest4(string value1, string value2)
        {

            command.CommandText = "Update Маршрутки SET id_водителя = (select id_водителя from водителя where Фамилия = '" + value1 + "') WHERE Номер_маршрутки = " + Convert.ToInt32(value2);
            return connOpen();
        }

        public int SqlRequest5(int value1, string value2)
        {
            command.CommandText = "Update Маршрутки SET id_маршрута = (select id_маршрута from маршруты where id_маршрута = '" + value1 + "') WHERE Номер_маршрутки = " + Convert.ToInt32(value2);
            return connOpen();
        }

        public int SqlRequest6()
        {
            command.CommandText = "INSERT INTO Маршруты (id_маршрута, Стоимость_маршрута) VALUES (" + NumberRouter +", " + Cena + ")";
            return connOpen();
        }

        public int SqlRequest7()
        {
            command.CommandText = "INSERT INTO Остановки (id_остановки, Название_остановки) VALUES (" + NumberStop + ", '" + NumberName + "')";
            return connOpen();
        }

        public int SqlRequest7(int values1, int values2, int values3, DateTime values4)
        {
            command.CommandText = "INSERT INTO Расписание (id_маршрута, id_типа_маршрута, id_остановки, Плановое_время_прибытия) VALUES (" + values1 + ", " + values2 + ", " + values3 + ", " + values4 + ")";
            return connOpen();
        }

        public int SqlRequest8()
        {
            command.CommandText = "INSERT INTO Владельцы (Фамилия, Имя, Отчество) VALUES ('" + Family + "', '" + Name + "', '" + Sername + "')";
            return connOpen();
        }

        public int SqlRequest9()
        {
            command.CommandText = "INSERT INTO Фиксация_маршрутки (Дата, Номер_маршрутки, id_типа_маршрута, id_остановки, Фактическое_время_прибытия, Количество_вошедших_пассажиров) VALUES ('" + DateDrive + "', " + NumberDrive + ", (select id_типа_маршрута from Тип_маршрута where Тип_маршрута = '" + TypeRouter + "'), (select id_остановки from остановки where Название_остановки = '" + NameStop + "'), '" + timeDrive + "', " + ManIn + ")";
            return connOpen();
        }

        public int connOpen()
        {

                conn.Open();
                try
                {
                    count = command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Невозможно изменить данные", "Ошибка!");
                }
                
                conn.Close();

            return count;
        }

        public string CarsDriverRead(out string commandText)
        {
            commandText = "SELECT * FROM Водителя";
            return connectionString;

        }

        public string CarsOwnerRead(out string commandText)
        {
            commandText = "SELECT * FROM Владельцы";
            return connectionString;

        }

        public string CarsMashineRead(out string commandText)
        {
            commandText = "SELECT * FROM Маршрутки";
            return connectionString;

        }

        public string CarsMashineReadDrivers(out string commandText)
        {
            commandText = "SELECT Фамилия FROM Водителя";
            return connectionString;

        }

        public string CarsMashineReadRouters(out string commandText)
        {
            commandText = "SELECT id_маршрута FROM Маршруты";
            return connectionString;

        }

        public string ReadStops(out string commandText)
        {
            commandText = "SELECT * FROM Остановки";
            return connectionString;

        }

        public string ReadRouters(out string commandText)
        {
            commandText = "SELECT * FROM Маршруты";
            return connectionString;

        }

        public string ReadTimeTable(out string commandText)
        {
            commandText = "SELECT * FROM Расписание";
            return connectionString;

        }

        public string ReadFixTime(out string commandText)
        {
            commandText = "SELECT * FROM Фиксация_маршрутки";
            return connectionString;

        }

        public string ReadComboBoxType(out string commandText)
        {
            commandText = "SELECT Тип_маршрута FROM Тип_маршрута";
            return connectionString;
        }

        public string ReadComboBoxStop(out string commandText)
        {
            commandText = "SELECT Название_остановки FROM Остановки";
            return connectionString;
        }

        public string ReadComboBoxNumberCar(out string commandText)
        {
            commandText = "SELECT Номер_маршрутки FROM Маршрутки";
            return connectionString;
        }

        public string ReadFamily(out string commandText)
        {
            commandText = "SELECT Фамилия FROM Владельцы";
            return connectionString;
        }

        public string SearchCars(out string commandText)
        {
            commandText = "select * from маршрутки where Дата_производства <= (select dateadd(yy,-9, GETDATE()))";
            return connectionString;
        }

        public string SearchRouters(out string commandText)
        {
            var count = (File.ReadAllText(@"request2.sql", Encoding.GetEncoding(65001))).Replace("\n", "");
            commandText = (count.Replace("\r", "")).Replace("\t", "");
            return connectionString;
        }

        public int SearchMoney(DateTime a, DateTime b, int c)
        {
            var number = 0;
            command.CommandText = @"CREATE TABLE temp_table (
                                    CarNumber INT
                                    );
  
	                                DECLARE @mov INT 
	                                DECLARE @count INT 
	                                DECLARE @dav int
	                                SET @mov = (select count(DISTINCT Номер_маршрутки) FROM Маршрутки where id_маршрута = '"+ c + @"')

	                                    while @mov > 0
		                                    BEGIN
	
			                                    SET @mov = @mov - 1
			                                    SET @count = (select DISTINCT (Номер_маршрутки) from Маршрутки where id_маршрута = '"+ c + @"' ORDER BY Номер_маршрутки OFFSET @mov ROWS FETCH NEXT 1 ROWS ONLY)
			                                    SET @dav = (select SUM(Количество_вошедших_пассажиров) from Фиксация_маршрутки where Номер_маршрутки = @count AND Фактическое_время_прибытия >= CONVERT(DATETIME,'"+ a + @"',104) AND Фактическое_время_прибытия <= CONVERT(DATETIME,'"+ b + @"',104))

                                                insert into temp_table (CarNumber) values (@dav)

		                                    END;

		                                    select ((select sum(CarNumber) from temp_table) * (select Стоимость_маршрута FROM Маршруты where id_маршрута = '"+ c + @"') / (select datediff(day, '"+ a + @"', '"+ b + @"') + 1))

		                                    drop table temp_table";
            
                conn.Open();
                try
                {
                    number = Convert.ToInt32(command.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("Необходимо корректно выбрать даты и правильный маршрут");
                }

                conn.Close();
            return number;
        }

        public string SearchCarDrive(out string commandText, int a)
        {
            commandText = @"CREATE TABLE temp_table (
                            temp DateTIME,
                            CarNumber INT
                            );
  
	                        DECLARE @mov INT 
	                        DECLARE @count INT 
	                        DECLARE @timeMax DateTime
                            DECLARE @timeMin DateTime
	                        SET @mov = (select count(DISTINCT Номер_маршрутки) FROM Маршрутки where id_маршрута = '" + a +@"')
 
	                        while @mov > 0
	                            BEGIN
	
		                            SET @mov = @mov - 1
		
		                            SET @count = (select DISTINCT (Номер_маршрутки) from Маршрутки where id_маршрута = '"+ a + @"' ORDER BY Номер_маршрутки OFFSET @mov ROWS FETCH NEXT 1 ROWS ONLY)
		                            SET @timeMax = (SELECT max(Фактическое_время_прибытия) from Фиксация_маршрутки WHERE Номер_маршрутки = @count and id_типа_маршрута = '1')
		                            SET @timeMin = (SELECT min(Фактическое_время_прибытия) from Фиксация_маршрутки WHERE Номер_маршрутки = @count and id_типа_маршрута = '1')
		                            insert into temp_table (temp, CarNumber) values ((select datediff(minute, (select @timeMax), (select @timeMin))), @count)

	                            END;
	
	                            SELECT Фамилия, Имя, Отчество FROM Водителя WHERE id_водителя = (SELECT id_водителя FROM Маршрутки WHERE Номер_маршрутки = (SELECT carNumber FROM temp_table WHERE temp = (SELECT max(temp) FROM temp_table)));

                            DROP TABLE temp_table;";
            return connectionString;
        }

        public string ReadComboBoxRouter(out string commandText)
        {
            commandText = "SELECT id_маршрута FROM Маршруты";
            return connectionString;
        }

        public void Qwe(out SqlDataReader dataReader, out SqlConnection conn, string commandText, string connectionString)
        {
            conn = new SqlConnection(connectionString);
            SqlCommand mycommannd = conn.CreateCommand();
            mycommannd.CommandText = commandText;
            conn.Open();

            dataReader = mycommannd.ExecuteReader();
        }
    }
}