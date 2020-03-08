using System;
using System.Windows.Forms;

namespace Taxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOwners_Click(object sender, EventArgs e)
        {
            Owners owners = new Owners();
            owners.ShowDialog();
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.ShowDialog();
        }

        private void CarMashine_Click(object sender, EventArgs e)
        {
            CarMashine carMashine = new CarMashine();
            carMashine.ShowDialog();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stops stops = new Stops();
            stops.ShowDialog();
        }

        private void timetable_Click(object sender, EventArgs e)
        {
            Timetable table = new Timetable();
            table.ShowDialog();
        }

        private void buttonFixMashine_Click(object sender, EventArgs e)
        {
            FixMashine mash = new FixMashine();
            mash.ShowDialog();
        }

        private void buttonReaquest_Click(object sender, EventArgs e)
        {
            NeedReaquest need = new NeedReaquest();
            need.ShowDialog();
        }
        
    }
}
