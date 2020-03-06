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
    public partial class Owners : Form
    {
        public Owners()
        {
            InitializeComponent();
        }

        DbType db;

        private void Owners_Load(object sender, EventArgs e)
        {
            ReadData();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void ReadData()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.CarsOwnerRead(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridView.DataSource = table;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddOwner();
        }

        public void AddOwner()
        {
            db = new DbType();

            if (db.SqlRequest8(textBoxFamily.Text, textBoxName.Text, textBoxSername.Text) == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Не удалось внести изменения!");

            ReadData();
        }

    }
}
