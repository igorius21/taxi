using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Taxi
{
    public partial class Owners : Form
    {
        public Owners()
        {
            InitializeComponent();
        }

        DbType db = new DbType();
        SqlDataReader dataReader;
        SqlConnection conn;

        private void Owners_Load(object sender, EventArgs e)
        {
            ReadData();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void ReadData()
        {
            dataGridView.Rows.Clear();

            string commandText;
            string connectionString = db.CarsOwnerRead(out commandText);

            db.Qwe(out dataReader, out conn, commandText, connectionString);

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string family = dataReader.GetString(1);
                string name = dataReader.GetString(2);
                string surname = dataReader.GetString(3);

                dataGridView.Rows.Add(id, family, name, surname); 
            }

            dataReader.Close();
            conn.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddOwner();
        }

        public void AddOwner()
        {
            if (textBoxFamily.Text == "" || textBoxName.Text == "" || textBoxSername.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }
            db.Family = textBoxFamily.Text;
            db.Name = textBoxName.Text;
            db.Sername = textBoxSername.Text;


            if (db.SqlRequest8() == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                
            }

            else
                MessageBox.Show("Не удалось внести изменения!");

            ReadData();
            textBoxFamily.Clear();
            textBoxName.Clear();
            textBoxSername.Clear();

        }

    }
}
