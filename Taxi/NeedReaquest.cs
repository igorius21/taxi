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
        }

        DbType db;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FindCars();
        }

        public void FindCars()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.SearchCars(out commandText);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand mycommannd = conn.CreateCommand();
            mycommannd.CommandText = commandText;
            conn.Open();
            SqlDataReader dataReader;
            dataReader = mycommannd.ExecuteReader();

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
            db = new DbType();

            string commandText;
            string connectionString = db.SearchRouters(out commandText);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand mycommannd = conn.CreateCommand();
            mycommannd.CommandText = commandText;
            conn.Open();
            SqlDataReader dataReader;
            dataReader = mycommannd.ExecuteReader();

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

            labelIn.Text = a.ToString();
            labelOut.Text = b.ToString();

            db = new DbType();

            labelMoney.Text = db.SearchMoney(a, b).ToString();
            

        }

        private void buttonSeachCar_Click(object sender, EventArgs e)
        {
            SearchCarDrive();
        }

        public void SearchCarDrive()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.SearchCarDrive(out commandText, Convert.ToInt32(comboBox1.Text));

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand mycommannd = conn.CreateCommand();
            mycommannd.CommandText = commandText;
            conn.Open();
            SqlDataReader dataReader;
            dataReader = mycommannd.ExecuteReader();

            string[] carsDriver = new string[3];


            while (dataReader.Read())
            {
                carsDriver[0] = dataReader.GetString(0);
                carsDriver[1] = dataReader.GetString(1);
                carsDriver[2] = dataReader.GetString(2);
            }

            labelFamily.Text = carsDriver[0].ToString();
            labelName.Text = carsDriver[1].ToString();
            labelSername.Text = carsDriver[2].ToString();



            dataReader.Close();
            conn.Close();
        }

        public void ReadComboBox()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.ReadComboBoxRouter(out commandText);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand mycommannd = conn.CreateCommand();
            mycommannd.CommandText = commandText;
            conn.Open();
            SqlDataReader dataReader;
            dataReader = mycommannd.ExecuteReader();

            while (dataReader.Read())
            {
                int type = dataReader.GetInt32(0);
                comboBox1.Items.Add(type);
            }

            dataReader.Close();
            conn.Close();
        }

    }
}
