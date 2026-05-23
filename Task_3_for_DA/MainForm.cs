using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_for_DA
{
    public partial class MainForm : Form
    {
        //constructor, gets called once the form getting  creted
        public MainForm()
        {
            InitializeComponent();

            panel1.Controls.Clear();//clears all existing controls

            InventoryDesign inv = new InventoryDesign();
            panel1.Controls.Add(inv);
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();//clears all existing controls

            InventoryDesign inv = new InventoryDesign();
            panel1.Controls.Add(inv);
        }

        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();//clears all existing controls

            OrderProcessing ord = new OrderProcessing();
            panel1.Controls.Add(ord);
        }

        //This event is called once the user decides to close the form and the app has to be stopped
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductManager.SaveProducts(); //Save the in memory product changes before exit!
        }
    }
}
