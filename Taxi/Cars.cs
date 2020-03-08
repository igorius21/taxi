using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Taxi
{
    public partial class Cars : Form
    {
        DbType db = new DbType();

        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            ReadData();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void ReadData()
        {
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
            if (textBoxFamily.Text == "" || textBoxName.Text == "" || textBoxSername.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }
            db.Family = textBoxFamily.Text;
            db.Name = textBoxName.Text;
            db.Sername = textBoxSername.Text;
            db.Date = Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString().ToString());

            if (db.SqlRequest1() == 1)
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
            if (textBoxFamilyDel.Text == "" || textBoxNameDel.Text == "" || textBoxSernameDel.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }
            db.Family = textBoxFamilyDel.Text;
            db.Name = textBoxNameDel.Text;
            db.Sername = textBoxSernameDel.Text;

            db.SqlRequest2();
            ReadData();

            BoxDell();
        }

        public void BoxDell()
        {
            textBoxFamily.Clear();
            textBoxName.Clear();
            textBoxSername.Clear();
            
            textBoxFamilyDel.Clear();
            textBoxNameDel.Clear();
            textBoxSernameDel.Clear();
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxFamilyDel.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxNameDel.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            textBoxSernameDel.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
