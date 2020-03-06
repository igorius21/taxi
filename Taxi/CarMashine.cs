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
    public partial class CarMashine : Form
    {
        DbType db;

        public CarMashine()
        {
            InitializeComponent();
            comboBoxRoute.Enabled = false;
            comboBoxDriver.Enabled = false;
        }

        private void CarMashine_Load(object sender, EventArgs e)
        {
            ReadData();
            ReadComboDrivers();
            ReadComboRoute();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ClearSelection();
            
        }

        public void ReadData()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.CarsMashineRead(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridView.DataSource = table;
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CarAdd();
        }

        public void CarAdd()
        {

            db = new DbType();

            if (db.SqlRequest3(Convert.ToInt32(textBoxNumber.Text), textBoxMark.Text, textBoxManufacturer.Text, Convert.ToDateTime(textBoxDate.Text), textBoxOwner.Text) == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Невозможно добавить машину");
        }

        private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DbType();

            int a = db.SqlRequest4(comboBoxDriver.Text, dataGridView.CurrentRow.Cells[0].Value.ToString());

            if (a == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Невозможно внести изменения");
        }

        public void ReadComboDrivers()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.CarsMashineReadDrivers(out commandText);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand mycommannd = conn.CreateCommand();
            mycommannd.CommandText = commandText;
            conn.Open();
            SqlDataReader dataReader;
            dataReader = mycommannd.ExecuteReader();

            while (dataReader.Read())
            {
                string family = dataReader.GetString(0);
                comboBoxDriver.Items.Add(family);
            }

            dataReader.Close();
            conn.Close();
        }

        public void ReadComboRoute()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.CarsMashineReadRouters(out commandText);

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand mycommannd = conn.CreateCommand();
            mycommannd.CommandText = commandText;
            conn.Open();
            SqlDataReader dataReader;
            dataReader = mycommannd.ExecuteReader();

            while (dataReader.Read())
            {
                int route = dataReader.GetInt32(0);
                comboBoxRoute.Items.Add(route);
            }

            dataReader.Close();
            conn.Close();
        }

        private void comboBoxRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DbType();

            int a = db.SqlRequest5(Convert.ToInt32(comboBoxRoute.Text), dataGridView.CurrentCell.Value.ToString());

            if (a == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Невозможно добавить машину");
        }
    }
}
