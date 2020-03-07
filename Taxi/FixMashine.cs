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
    public partial class FixMashine : Form
    {
        public FixMashine()
        {
            InitializeComponent();
        }

        DbType db = new DbType();
        string connectionString;
        string commandText;
        SqlDataReader dataReader;
        SqlConnection conn;

        private void FixMashine_Load(object sender, EventArgs e)
        {
            
            ReadData();
            
            ReadComboBoxType();
            ReadComboBoxStop();
            ReadNumberCar();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void ReadData()
        {

            string commandText;
            string connectionString = db.ReadFixTime(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataAdd();
        }

        public void DataAdd()
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBoxFixTime.Text == "" || textBoxNumberMan.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }

            if (db.SqlRequest9(Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString().ToString()), Convert.ToInt32(comboBox3.Text),
                comboBox1.Text, comboBox2.Text, 
                Convert.ToDateTime(textBoxFixTime.Text), Convert.ToInt32(textBoxNumberMan.Text)) == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Невозможно зафиксировать время прибытия машины");
        }


        public void ReadComboBoxType()
        {
            connectionString = db.ReadComboBoxType(out commandText);

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand mycommannd = conn.CreateCommand();
            //mycommannd.CommandText = commandText;
            //conn.Open();
            //SqlDataReader dataReader;
            //dataReader = mycommannd.ExecuteReader();
            Request(connectionString);

            //db.Qwe(out dataReader, out conn, commandText, connectionString);

            while (dataReader.Read())
            {
                string type = dataReader.GetString(0);
                comboBox1.Items.Add(type);
            }

            dataReader.Close();
            conn.Close();
        }

        public void ReadComboBoxStop()
        {

            connectionString = db.ReadComboBoxStop(out commandText);

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand mycommannd = conn.CreateCommand();
            //mycommannd.CommandText = commandText;
            //conn.Open();
            //SqlDataReader dataReader;
            //dataReader = mycommannd.ExecuteReader();
            Request(connectionString);

            //db.Qwe(out dataReader, out conn, commandText, connectionString);

            while (dataReader.Read())
            {
                string stop = dataReader.GetString(0);
                comboBox2.Items.Add(stop);
            }

            dataReader.Close();
            conn.Close();
        }

        public void ReadNumberCar()
        {
            connectionString = db.ReadComboBoxNumberCar(out commandText);

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand mycommannd = conn.CreateCommand();
            //mycommannd.CommandText = commandText;
            //conn.Open();
            //SqlDataReader dataReader;
            //dataReader = mycommannd.ExecuteReader();

            Request(connectionString);

            //db.Qwe(out dataReader, out conn, commandText, connectionString);

            while (dataReader.Read())
            {
                int stop = dataReader.GetInt32(0);
                comboBox3.Items.Add(stop);
            }

            dataReader.Close();
            conn.Close();
        }

        public void Request(string connectionString)
        {
            db.Qwe(out dataReader, out conn, commandText, connectionString);
        }


    }
}
