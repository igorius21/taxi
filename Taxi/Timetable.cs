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
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        DbType db = new DbType();

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
            db = new DbType();

            string commandText;
            string connectionString = db.ReadTimeTable(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridView.DataSource = table;

        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            ReadRouters();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
