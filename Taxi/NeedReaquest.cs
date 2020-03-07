using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi
{
    public partial class NeedReaquest : Form
    {
        public NeedReaquest()
        {
            InitializeComponent();
            ReadComboBox();
            ReadComboRouter();
            comboBoxRouter.Text = "7";
        }

        DbType db = new DbType();
        SqlDataReader dataReader;
        SqlConnection conn;
        string connectionString;
        string commandText;

        public void ReadComboRouter()
        {

            connectionString = db.CarsMashineReadRouters(out commandText);

            Request(connectionString);

            //db.Qwe(out dataReader, out conn, commandText, connectionString);

            while (dataReader.Read())
            {
                int route = dataReader.GetInt32(0);
                comboBoxRouter.Items.Add(route);
            }

            dataReader.Close();
            conn.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FindCars();
        }

        public void FindCars()
        {

            connectionString = db.SearchCars(out commandText);

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand mycommannd = conn.CreateCommand();
            //mycommannd.CommandText = commandText;
            //conn.Open();
            //SqlDataReader dataReader;
            //dataReader = mycommannd.ExecuteReader();

            Request(connectionString);

            int car = 0;


            while (dataReader.Read())
            {
                car = dataReader.GetInt32(0);
            }

            if (car != 0)
            {
                labelCarOld.Text = car.ToString();
                label123.Text = "- маршрутку необходимо заменить в этом году";
            }
                
            else
                labelCarOld.Text = "Нет машин для замены";


            dataReader.Close();
            conn.Close();
        }

        private void buttonRouter_Click(object sender, EventArgs e)
        {
            SearchRouter();
        }

        public void SearchRouter()
        {
            connectionString = db.SearchRouters(out commandText);

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand mycommannd = conn.CreateCommand();
            //mycommannd.CommandText = commandText;
            //conn.Open();

            Request(connectionString);
            //db.Qwe(out dataReader, out conn, commandText, connectionString);
            //dataReader = mycommannd.ExecuteReader();

            List<int> routers = new List<int>();


            while (dataReader.Read())
            {
                routers.Add(dataReader.GetInt32(0));
            }

            labelLong.Text = routers[0].ToString();
            labelShort.Text = routers[1].ToString();


            dataReader.Close();
            conn.Close();
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            SearchMoney();
        }

        public void SearchMoney()
        {
            DateTime a = Convert.ToDateTime(monthCalendar1.SelectionStart.ToShortDateString().ToString());
            DateTime b = Convert.ToDateTime(monthCalendar2.SelectionStart.ToShortDateString().ToString());
            int c = Convert.ToInt32(comboBoxRouter.Text);

            labelIn.Text = a.ToShortDateString();
            labelOut.Text = b.ToShortDateString();

            db = new DbType();
            var number = db.SearchMoney(a, b, c);

            if (number != 0)
                labelMoney.Text = number.ToString() + "- рублей";
            else
            {
                labelMoney.Text = "";
                labelIn.Text = "";
                labelOut.Text = "";
            }
                
            
            

        }

        private void buttonSeachCar_Click(object sender, EventArgs e)
        {
            SearchCarDrive();
        }

        public void SearchCarDrive()
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }
            connectionString = db.SearchCarDrive(out commandText, Convert.ToInt32(comboBox1.Text));

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand mycommannd = conn.CreateCommand();
            //mycommannd.CommandText = commandText;
            //conn.Open();
            //SqlDataReader dataReader;
            //dataReader = mycommannd.ExecuteReader();

            Request(connectionString);

            string[] carsDriver = new string[3];


            while (dataReader.Read())
            {
                carsDriver[0] = dataReader.GetString(0);
                carsDriver[1] = dataReader.GetString(1);
                carsDriver[2] = dataReader.GetString(2);
            }

            try
            {
                labelFamily.Text = carsDriver[0].ToString();
                labelName.Text = carsDriver[1].ToString();
                labelSername.Text = carsDriver[2].ToString();
            }
            catch
            {
                MessageBox.Show("На данному маршруте никто не работает");
                labelFamily.Text = "";
                labelName.Text = "";
                labelSername.Text = "";
            }
            



            dataReader.Close();
            conn.Close();
        }

        public void ReadComboBox()
        {
            connectionString = db.ReadComboBoxRouter(out commandText);

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand mycommannd = conn.CreateCommand();
            //mycommannd.CommandText = commandText;
            //conn.Open();
            //SqlDataReader dataReader;
            //dataReader = mycommannd.ExecuteReader();

            Request(connectionString);

            while (dataReader.Read())
            {
                int type = dataReader.GetInt32(0);
                comboBox1.Items.Add(type);
            }

            dataReader.Close();
            conn.Close();
        }

        //public static void Qwe(out SqlDataReader dataReader, out SqlConnection conn, string commandText, string connectionString)
        //{
        //    conn = new SqlConnection(connectionString);
        //    SqlCommand mycommannd = conn.CreateCommand();
        //    mycommannd.CommandText = commandText;
        //    conn.Open();
            
        //    dataReader = mycommannd.ExecuteReader();
        //}

        public void Request(string connectionString)
        {
            db.Qwe(out dataReader, out conn, commandText, connectionString);
        }

    }
}
