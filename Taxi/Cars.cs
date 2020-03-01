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
    public partial class Cars : Form
    {
        DbType db;

        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        public void ReadData()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.CarsDriverRead(out commandText);
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
           
            if (db.SqlRequest1(textBoxFamily.Text, textBoxName.Text, textBoxSername.Text, Convert.ToDateTime(textBoxDate.Text)) == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Стаж водителя должен быть более 3х лет. Введеное значение не соответствует условию!");

            BoxDell();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            CarDell();
        }

        public void CarDell()
        {
            db = new DbType();

            if (db.SqlRequest2(textBoxFamilyDel.Text, textBoxNameDel.Text, textBoxSernameDel.Text) != -1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadData();
            }

            else
                MessageBox.Show("Невозможно удалить водителя");

            BoxDell();
        }


        public void BoxDell()
        {
            textBoxFamily.Clear();
            textBoxName.Clear();
            textBoxSername.Clear();
            textBoxDate.Clear();
            textBoxFamilyDel.Clear();
            textBoxNameDel.Clear();
            textBoxSernameDel.Clear();
        }


    }
}
