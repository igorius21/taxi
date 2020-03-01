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
    public partial class NeedReaquest : Form
    {
        public NeedReaquest()
        {
            InitializeComponent();
        }

        DbType db;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FindCars();
        }

        public void FindCars()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.SearchCars(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            textBoxCars.Text = table.ToString();
        }

        private void buttonRouter_Click(object sender, EventArgs e)
        {
            SearchRouter();
        }

        public void SearchRouter()
        {
            db = new DbType();

            string commandText;
            string connectionString = db.SearchCars(out commandText);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
            adapter.Fill(table);
            textBoxCars.Text = table.ToString();
        }
    }
}
