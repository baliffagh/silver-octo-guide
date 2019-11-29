using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace View
{
    public partial class doroga : Form //, IDoroga
    {
        // private readonly ApplicationContext _context;
        public doroga(/*ApplicationContext context*/)
        {
            //_context = context;
            InitializeComponent();
        }

        event Action AddVehicle;
        event Action StartIm;
        event Action StopIm;
        event Action GoBack;

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            main form = new main();
            form.Show();
            this.Hide();
            //тут обращение к Presenter
        }


        private void AddVehicleB_Click(object sender, EventArgs e)
        {
            add_transport form = new add_transport();
            form.Show();
            //тут обращение к Presenter
        }

        private void AddVehicleB2_Click(object sender, EventArgs e)
        {
            add_transport form = new add_transport();
            form.Show();
            //тут обращение к Presenter
        }

        private void AddVehicleB3_Click(object sender, EventArgs e)
        {
            add_transport form = new add_transport();
            form.Show();
            //тут обращение к Presenter
        }

        private void AddVehicleB4_Click(object sender, EventArgs e)
        {
            add_transport form = new add_transport();
            form.Show();
            //тут обращение к Presenter
        }
        private void AddVehicleB5_Click(object sender, EventArgs e)
        {
            add_transport form = new add_transport();
            form.Show();
            //тут обращение к Presenter
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //тут обращение к Presenter
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //тут обращение к Presenter
        }
    }
}
