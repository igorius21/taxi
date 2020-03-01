using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class DbType
    {
        static string connectionString = @"Data Source=IGORIUS-PK\SQLEXPRESS;Initial Catalog=taxi;Integrated Security=True";

        static int count;

        static SqlConnection conn = new SqlConnection(connectionString);
        public static SqlCommand command = conn.CreateCommand();

        public int SqlRequest1(string family, string name, string sername, DateTime date)
        {
            command.CommandText = "IF '" + date + "' < dateadd(yy,-3, GETDATE()) INSERT INTO Водителя (Фамилия, Имя, Отчество, Дата_получения_прав) VALUES ('" + family + "', '" + name + "', '" + sername + "', '" + date + "')";
            return connOpen();

        }

        public int SqlRequest2(string family, string name, string sername)
        {
            command.CommandText = "DELETE FROM Водителя WHERE Фамилия = '" + family + "' AND Имя = '" + name + "' AND Отчество = '" + sername + "'";
            return connOpen();
        }

        public int SqlRequest3(int number, string mark, string manufacturer, DateTime date, string owner)
        {
            command.CommandText = "IF '" + date + "' > dateadd(yy,-10, GETDATE()) INSERT INTO Маршрутки (Номер_маршрутки, id_владельца, Марка, Производитель, Дата_производства) VALUES (" + number + ", (select id_владельца from владельцы where Фамилия = '" + owner + "'), '" + mark + "', '" + manufacturer + "', '" + date + "')";
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

        public int SqlRequest6(int values1, int values2)
        {
            command.CommandText = "INSERT INTO Маршруты (id_маршрута, Стоимость_маршрута) VALUES (" + values1 +", " + values2 + ")";
            return connOpen();
        }

        public int SqlRequest7(int values1, string values2)
        {
            command.CommandText = "INSERT INTO Остановки (id_остановки, Название_остановки) VALUES (" + values1 + ", '" + values2 + "')";
            return connOpen();
        }

        public int SqlRequest7(int values1, int values2, int values3, DateTime values4)
        {
            command.CommandText = "INSERT INTO Расписание (id_маршрута, id_типа_маршрута, id_остановки, Плановое_время_прибытия) VALUES (" + values1 + ", " + values2 + ", " + values3 + ", '" + values4 + "')";
            return connOpen();
        }

        public int SqlRequest8(string family, string name, string sername)
        {
            command.CommandText = "INSERT INTO Владельцы (Фамилия, Имя, Отчество) VALUES ('" + family + "', '" + name + "', '" + sername + "')";
            return connOpen();
        }

        public int SqlRequest9(DateTime date, int numberCar, string idType, string idStop, DateTime time, int numberMan)
        {
            command.CommandText = "INSERT INTO Фиксация_маршрутки (Дата, Номер_маршрутки, id_типа_маршрута, id_остановки, Фактическое_время_прибытия, Количество_вошедших_пассажиров) VALUES ('" + date + "', " + numberCar + ", (select id_типа_маршрута from Тип_маршрута where Тип_маршрута = '" + idType + "'), (select id_остановки from остановки where Название_остановки = '" + idStop + "'), '" + time + "', " + numberMan + ")";
            return connOpen();
        }

        public int connOpen()
        {
            conn.Open();
            count = command.ExecuteNonQuery();
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

        public string SearchCars(out string commandText)
        {
            commandText = "select * from маршрутки where Дата_производства <= (select dateadd(yy,-10, GETDATE()))";
            return connectionString;
        }

        public string SearchRouters(out string commandText)
        {
            commandText = "select * from маршрутки where Дата_производства <= (select dateadd(yy,-10, GETDATE()))";
            return connectionString;
        }

    }
}