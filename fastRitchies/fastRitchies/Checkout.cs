using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace fastRitchies
{
    public partial class Checkout : Form
    {

        string username = "";
        List<FoodItem> cart;

        public Checkout(string username, List<FoodItem> cart)
        {
            InitializeComponent();
            this.username = username;
            this.cart = cart;
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            // TO-DO: obtain user's order info; write to user's .txt file
            string filePath = $"{username}.txt";

            foreach (FoodItem item in cart)
            {

                string orderWindow = item.foodItemName + "," + item.categoryName + "," + item.foodPrice + "," + item.foodDescription + Environment.NewLine;
                File.AppendAllText(filePath, orderWindow);
                //File.WriteAllText(filePath, "hello");
            }


                //.ToString() may be replaced with another method to orient orders
                //into a comma separated list following the format:
                //Name,Category,Price,Description
                //Burger,FastFood,5.99,Delicious beef burger
                //Pizza, FastFood,8.99,Cheesy pizza

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            double totalPrice = 0.00;
            foreach(FoodItem item in cart)
            {
                cartItems.Items.Add(item.foodItemName);
                cartPrices.Items.Add(item.foodPrice.ToString("C2"));
                totalPrice += item.foodPrice;
            }

            totalPriceLabel.Text = totalPrice.ToString("C2");
        }
    }
}
