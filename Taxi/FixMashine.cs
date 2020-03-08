using System;
using System.Data;
using System.Data.SqlClient;
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

            try
            {
                db.NumberDrive = Convert.ToInt32(comboBox3.Text);
                db.TypeRouter = comboBox1.Text;
                db.NameStop = comboBox2.Text;
                db.timeDrive = Convert.ToDateTime(textBoxFixTime.Text);
                db.ManIn = Convert.ToInt32(textBoxNumberMan.Text);
                db.DateDrive = Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString().ToString());
            }
            catch
            {
                MessageBox.Show("Невозможно изменить данные");
            }

            if (db.SqlRequest9() == 1)
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

            Request(connectionString);

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

            Request(connectionString);

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

            Request(connectionString);

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
