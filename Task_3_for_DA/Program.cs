using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_for_DA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ProductManager productManager = new ProductManager();
            //ProductManager.Products = productManager.LoadProducts();

            //Out product manager has all the static methods, so we dont have to create an object of it

            ProductManager.Init(); //Initialize the products records: read inventory data from external file format our shop-product-catalog.csv  upon startup


            Application.Run(new MainForm());
        }
    }
}
