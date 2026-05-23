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
    public partial class InventoryDesign : UserControl
    {
        public InventoryDesign()
        {
            InitializeComponent();

            dataGridView1.DataSource = ProductManager.Products;
        }

        private void InventoryDesign_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // string productId = tbProductId.Text;
            string prodName = tbProductName.Text;
            string brand = tbBrand.Text;
            string price = tbPrice.Text;
            string qty = tbQty.Text;


            //We need to validate our inputs here
            // Product ID Validation

            //if (productId == "")
            //{
            //    MessageBox.Show("Please enter Product ID");
            //    return;
            //}

            //int pid;

            //if (int.TryParse(productId, out pid) == false)
            //{
            //    MessageBox.Show("Product ID must be a number");
            //    return;
            //}

            //Let us Auto generate the product id

            //Reach to out last product, access it's id then add 1 to it to get the new Product Id
            int pid = ProductManager.Products[ProductManager.Products.Count - 1].ProductID + 1;


            // Product Name Validation

            if (prodName == "")
            {
                MessageBox.Show("Please enter Product Name");
                return;
            }

            for (int i = 0; i < prodName.Length; i++)
            {
                char ch = prodName[i];

                if ((char.IsLetterOrDigit(ch) == false) &&
                    ch != ' ')
                {
                    MessageBox.Show("Invalid Product Name");
                    return;
                }
            }


            // Brand Validation

            if (brand == "")
            {
                MessageBox.Show("Please enter Brand");
                return;
            }

            for (int i = 0; i < brand.Length; i++)
            {
                char ch = brand[i];

                if ((char.IsLetter(ch) == false) &&
                    ch != ' ')
                {
                    MessageBox.Show("Invalid Brand Name");
                    return;
                }
            }


            // Price Validation

            if (price == "")
            {
                MessageBox.Show("Please enter Price");
                return;
            }

            double pr;

            if (double.TryParse(price, out pr) == false)
            {
                MessageBox.Show("Price must be numeric");
                return;
            }

            if (pr <= 0)
            {
                MessageBox.Show("Price must be greater than 0");
                return;
            }


            // Quantity Validation

            if (qty == "")
            {
                MessageBox.Show("Please enter Quantity");
                return;
            }

            int quantity;

            if (int.TryParse(qty, out quantity) == false)
            {
                MessageBox.Show("Quantity must be numeric");
                return;
            }

            if (quantity < 0)
            {
                MessageBox.Show("Quantity cannot be negative");
                return;
            }


            //If the validation is passed, we then need to save!

            Product p = new Product();

            p.ProductID = pid;
            p.ProductName = prodName;
            p.ProductBrand = brand;
            p.Price = pr;
            p.Quantity = quantity;

            

            ProductManager.AddProduct(p);

            MessageBox.Show("Product Added Successfully");


            // Reload records
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductManager.Products;
            dataGridView1.Refresh();



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        

            string productId = tbProductId.Text;

            // Product ID Validation

            if (productId == "")
            {
                MessageBox.Show("Please enter Product ID");
                return;
            }

            int pid;

            if (int.TryParse(productId, out pid) == false)
            {
                MessageBox.Show("Product ID must be a number");
                return;
            }


            //Implement the search

          

            Product product = ProductManager.GetProductById(pid);

            if (product == null)
            {
                MessageBox.Show("Product Not Found");
                return;
            }


            // Display data in textboxes

            tbProductName.Text = product.ProductName;
            tbBrand.Text = product.ProductBrand;
            tbPrice.Text = product.Price.ToString();
            tbQty.Text = product.Quantity.ToString();

            MessageBox.Show("Product Found");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string productId = tbProductId.Text;
            string prodName = tbProductName.Text;
            string brand = tbBrand.Text;
            string price = tbPrice.Text;
            string qty = tbQty.Text;


            // Product ID Validation

            if (productId == "")
            {
                MessageBox.Show("Please enter Product ID");
                return;
            }

            int pid;

            if (int.TryParse(productId, out pid) == false)
            {
                MessageBox.Show("Product ID must be a number");
                return;
            }


            // Product Name Validation

            if (prodName == "")
            {
                MessageBox.Show("Please enter Product Name");
                return;
            }

            for (int i = 0; i < prodName.Length; i++)
            {
                char ch = prodName[i];

                if ((char.IsLetterOrDigit(ch) == false) &&
                    ch != ' ')
                {
                    MessageBox.Show("Invalid Product Name");
                    return;
                }
            }


            // Brand Validation

            if (brand == "")
            {
                MessageBox.Show("Please enter Brand");
                return;
            }

            for (int i = 0; i < brand.Length; i++)
            {
                char ch = brand[i];

                if ((char.IsLetter(ch) == false) &&
                    ch != ' ')
                {
                    MessageBox.Show("Invalid Brand Name");
                    return;
                }
            }


            // Price Validation

            if (price == "")
            {
                MessageBox.Show("Please enter Price");
                return;
            }

            double pr;

            if (double.TryParse(price, out pr) == false)
            {
                MessageBox.Show("Price must be numeric");
                return;
            }

            if (pr <= 0)
            {
                MessageBox.Show("Price must be greater than 0");
                return;
            }


            // Quantity Validation

            if (qty == "")
            {
                MessageBox.Show("Please enter Quantity");
                return;
            }

            int quantity;

            if (int.TryParse(qty, out quantity) == false)
            {
                MessageBox.Show("Quantity must be numeric");
                return;
            }

            if (quantity < 0)
            {
                MessageBox.Show("Quantity cannot be negative");
                return;
            }


            // Create Product Object

            Product p = new Product();

            p.ProductID = pid;
            p.ProductName = prodName;
            p.ProductBrand = brand;
            p.Price = pr;
            p.Quantity = quantity;


            // Update Product
 

            bool updated = ProductManager.UpdateProduct(p);

            if (updated == true)
            {
                MessageBox.Show("Product Updated Successfully");
                // Reload records
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductManager.Products;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Product Not Found");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string productId = tbProductId.Text;


            // Product ID Validation

            if (productId == "")
            {
                MessageBox.Show("Please enter Product ID");
                return;
            }

            int pid;

            if (int.TryParse(productId, out pid) == false)
            {
                MessageBox.Show("Product ID must be a number");
                return;
            }

            var res = MessageBox.Show("Are you sure to delete?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(res != DialogResult.Yes)
            {
                return;
            }

            // Delete Product           

            bool deleted = ProductManager.DeleteProduct(pid);

            if (deleted == true)
            {
                MessageBox.Show("Product Deleted Successfully");

                // Reload records
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductManager.Products;
                dataGridView1.Refresh();

                // Clear Textboxes

                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Product Not Found");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }


        void ClearTextBoxes()
        {
            tbProductId.Text = "";
            tbProductName.Text = "";
            tbBrand.Text = "";
            tbPrice.Text = "";
            tbQty.Text = "";
        }
    }
}
