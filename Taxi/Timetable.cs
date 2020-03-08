using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Taxi
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        DbType db = new DbType();
        string commandText;
        string connectionString;
        SqlDataReader dataReader;
        SqlConnection conn;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddRoute();
        }

        public void AddRoute()
        {
            if (textBoxIdRouter.Text == "" || textBoxIdTipeRouter.Text == "" || textBoxIdStop.Text == "" || textBoxTime.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }


            if (db.SqlRequest7(Convert.ToInt32(textBoxIdRouter.Text), Convert.ToInt32(textBoxIdTipeRouter.Text), 
                Convert.ToInt32(textBoxIdStop.Text), Convert.ToDateTime(textBoxTime.Text)) == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadRouters();
            }

            else
                MessageBox.Show("Невозможно добавить машину");
        }

        public void ReadRouters()
        {
            connectionString = db.ReadTimeTable(out commandText);

            db.Qwe(out dataReader, out conn, commandText, connectionString);

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                int type = dataReader.GetInt32(1);
                int stop = dataReader.GetInt32(2);
                DateTime time = dataReader.GetDateTime(3);

                dataGridView.Rows.Add(id, type, stop, time.ToShortTimeString());
            }

            dataReader.Close();
            conn.Close();

        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            ReadRouters();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
