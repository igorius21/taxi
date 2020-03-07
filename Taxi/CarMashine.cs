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
        DbType db = new DbType();
        SqlDataReader dataReader;
        SqlConnection conn;
        string commandText;
        string connectionString;

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
            ReadComboFamily();
        }

        public void ReadComboFamily()
        {

            connectionString = db.ReadFamily(out commandText);

            db.Qwe(out dataReader, out conn, commandText, connectionString);

            while (dataReader.Read())
            {
                string family = dataReader.GetString(0);
                comboBoxFamily.Items.Add(family);
            }

            dataReader.Close();
            conn.Close();
        }

        public void ReadData()
        {
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
            if (textBoxNumber.Text == "" || textBoxMark.Text == "" || textBoxManufacturer.Text == "" || comboBoxFamily.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }
            try
            {
                db.NumberCar = Convert.ToInt32(textBoxNumber.Text);
                db.Mark = textBoxMark.Text;
                db.Manufacture = textBoxManufacturer.Text;

                db.Date = Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString().ToString());
                db.Family = comboBoxFamily.Text;
            }
            catch
            {
                MessageBox.Show("Данные введены в неправильном формате");
                return;
            }

            if (db.SqlRequest3() == 1)
            {
                MessageBox.Show("Изменения успешно внесены");
                BoxDell();
            }
                
            else
                MessageBox.Show("Автомобиль должен быть не старше 10 лет со дня производства");

            ReadData();
        }

        private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRoute.Enabled = true;

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

            string connectionString = db.CarsMashineReadDrivers(out commandText);

            db.Qwe(out dataReader, out conn, commandText, connectionString);

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

            string connectionString = db.CarsMashineReadRouters(out commandText);

            db.Qwe(out dataReader, out conn, commandText, connectionString);

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

            int a = db.SqlRequest5(Convert.ToInt32(comboBoxRoute.Text), dataGridView.CurrentCell.Value.ToString());

            if (a == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Невозможно добавить машину");
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxDriver.Enabled = true;
        }

        public void BoxDell()
        {
            textBoxNumber.Text = "";
            textBoxMark.Text = "";
            textBoxManufacturer.Text = "";
            comboBoxFamily.Text = "";

        }
    }
}
