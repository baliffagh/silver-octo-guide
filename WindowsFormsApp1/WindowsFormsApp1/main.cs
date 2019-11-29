using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using Presentation;

namespace View

{
    public partial class main : Form //, IMain
    {

       // private readonly ApplicationContext _context;
        public main(/*ApplicationContext context*/)
        {
            //_context = context;
            InitializeComponent();
        }

        public event Action AddFuel;
        public event Action ChooseNeedFuel;
        public event Action Ready;



        private void ReadyBtn_Click(object sender, EventArgs e)
        {
            doroga form = new doroga();
            form.Show();
            this.Hide();

            /*Ready?.Invoke();*/

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            /*
                AddFuel?.Invoke(txb_name_fuel.Text);
             */

            string strName = txb_name_fuel.Text;
            listBox1.Items.Add(strName);
            Fuel fuel = new Fuel();
            fuel.read_name_of_fuel(strName);
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            ListBox item = new ListBox();
            item = this.listBox1;
            listBox1.Items.Add("Бензин");
            listBox1.Items.Add("Дизельное топливо");
            listBox1.Items.Add("Электричество");
            listBox1.Items.Add("Газ");
            listBox1.Items.Add("Яблоко");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                item.SelectedIndex = i;
                fuel.read_name_of_fuel ( item.SelectedItem.ToString());
            }
        }

        private void ArrowBtn_Click(object sender, EventArgs e)
        {
            /*
             ChooseNeedFuel?.Invoke(выбранный класс или что-то типо того);
             */

            ListBox item = new ListBox();
            item = this.listBox1;
            if (!(listBox2.Items.Contains(item.SelectedItem.ToString())))
            {
                listBox2.Items.Add(item.SelectedItem.ToString());
            }

        }
    }
}
