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
    public partial class Stops : Form
    {
        DbType db;

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
            db = new DbType();

            if (db.SqlRequest6(Convert.ToInt32(textBoxRoute.Text),Convert.ToInt32(textBoxCena.Text)) == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadRouters();
            }

            else
                MessageBox.Show("Невозможно добавить маршрут");
        }

        public void AddStop()
        {
            db = new DbType();

            if (db.SqlRequest7(Convert.ToInt32(textBoxStop.Text), textBoxNameStop.Text) == 1)
            {
                MessageBox.Show("Изменения успешно внесены!");
                ReadStops();
            }

            else
                MessageBox.Show("Невозможно добавить остановку");
        }

        private void Stops_Load(object sender, EventArgs e)
        {
            ReadStops();
            ReadRouters();
        }

        public void ReadRouters()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.ReadRouters(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridViewRoute.DataSource = table;
        }

        public void ReadStops()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.ReadStops(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            dataGridViewStops.DataSource = table;
        }
    }
}
