using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Taxi
{
    public partial class Stops : Form
    {
        DbType db = new DbType();

        public Stops()
        {
            InitializeComponent();
        }

        private void buttonRouteAdd_Click(object sender, EventArgs e)
        {
            AddRoute();
        }

        private void buttonStopAdd_Click(object sender, EventArgs e)
        {
            AddStop();
        }

        public void AddRoute()
        {
            if (textBoxRoute.Text == "" || textBoxCena.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }

            try
            {
                db.NumberRouter = Convert.ToInt32(textBoxRoute.Text);
                db.Cena = Convert.ToInt32(textBoxCena.Text);
            }
            catch
            {
                MessageBox.Show("Данные введены в неправильном формате");
                BoxDell();
                return;
            }

            if (db.SqlRequest6() == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");

                ReadRouters();
            }

            else
                MessageBox.Show("Невозможно добавить маршрут");

            BoxDell();
        }

        public void AddStop()
        {
            if (textBoxStop.Text == "" || textBoxNameStop.Text == "")
            {
                MessageBox.Show("Ни все поля заполнены");
                return;
            }

            try
            {
                db.NumberStop = Convert.ToInt32(textBoxStop.Text);
                db.NumberName = textBoxNameStop.Text;
            }
            catch
            {
                MessageBox.Show("Данные введены в неправильном формате");
                BoxDell();
                return;
            }


            if (db.SqlRequest7() == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadStops();
            }

            else
                MessageBox.Show("Невозможно добавить остановку");

            BoxDell();
        }

        private void Stops_Load(object sender, EventArgs e)
        {
            ReadStops();
            ReadRouters();
            dataGridViewRoute.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStops.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public void ReadRouters()
        {

            string commandText;
            string connectionString = db.ReadRouters(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridViewRoute.DataSource = table;
        }

        public void ReadStops()
        {

            string commandText;
            string connectionString = db.ReadStops(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridViewStops.DataSource = table;
        }

        public void BoxDell()
        {
            textBoxRoute.Clear();
            textBoxCena.Clear();
            textBoxStop.Clear();

            textBoxNameStop.Clear();
        }
    }
}
