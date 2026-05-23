using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Task_3_for_DA
{
    class ProductManager
    {
        //This Product variable will hold the list of all the products in the inventory, and it will be loaded from the csv file at the start up of the app, and will be updated during the app usage when we add, update or delete a product.
        public static List<Product> Products = null;

        //I have kep this file in the bin folder of the project, so that it can be easily accessed by the app
        static string filePath = "shop-product-catalog.csv";


        public static void Init()
        {
            Products = LoadProducts(); //Loaded all the inventory details in the start up
        }

        //Gets called in the start up to load the products from the csv file
        public static List<Product> LoadProducts()
        {
            //Create an empty list to hold the products
            List<Product> products = new List<Product>();

            if (File.Exists(filePath) == false)
            {
                return products;//If the file path is not found, return empty list
            }

            string[] lines = File.ReadAllLines(filePath);

            // Skip header
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                //Assuming the CSV format is: ProductID,ProductName,ProductBrand,Price,Quantity
                Product product = new Product();

                product.ProductID = int.Parse(data[0]);
                product.ProductName = data[1];
                product.ProductBrand = data[2];
                product.Price = double.Parse(data[3]);
                product.Quantity = int.Parse(data[4]);

                //Add the product to the list
                products.Add(product);
            }

            //Return the list of products...
            return products;
        }

        //This funcion will be called at the exit (when user leaves the app)
        //This will recreate the csv file with the updated inventory details
        public static void SaveProducts()
        {
            List<string> lines = new List<string>();

            lines.Add("ProductID,ProductName,ProductBrand,Price,Quantity");

            for (int i = 0; i < Products.Count; i++)
            {
                Product product = Products[i];

                string line =
                    product.ProductID + "," +
                    product.ProductName + "," +
                    product.ProductBrand + "," +
                    product.Price + "," +
                    product.Quantity;

                lines.Add(line);
            }

            //Finally write all the lines to the file
            File.WriteAllLines(filePath, lines);
        }

        //My add producct, updateproduct and deleteproduct functions do not immediately
        //update the csv, only update the in-memory list of products.
        //The csv will be updated only when the user exits the app, so that we do not have to write
        //to the file multiple times during the app usage.

        // ADD PRODUCT
        public static void AddProduct(Product product)
        {
            //the product object can contain the auto gerenated product id, or it can be generated here before adding to the list
            Products.Add(product);

           // SaveProducts(); //We will call only in the exit time
        }


        // UPDATE PRODUCT
        public static bool UpdateProduct(Product updatedProduct)
        {
            //loop through the list of products to find the product with the same id as the updated product
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == updatedProduct.ProductID)
                {
                    //If found, I update the details of the product in the list
                    Products[i].ProductName = updatedProduct.ProductName;
                    Products[i].ProductBrand = updatedProduct.ProductBrand;
                    Products[i].Price = updatedProduct.Price;
                    Products[i].Quantity = updatedProduct.Quantity;

                    //SaveProducts();

                    return true;//on successful update, return true
                }
            }

            return false;//If the product with the given id is not found, return false
        }

        // DELETE pRODUCT
        public static bool DeleteProduct(int productId)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productId)
                {
                    Products.RemoveAt(i);

                    //SaveProducts();

                    return true;//on successful deletion, return true
                }
            }

            return false;//If the product with the given id is not found, return false
        }

        // GET PRODUCT BY ID
        //This function will be used in the order manager to get the product details by id when searching for the product in the inventory
        public static Product GetProductById(int productId)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productId)
                {
                    return Products[i];
                }
            }

            return null;
        }
    }
}
