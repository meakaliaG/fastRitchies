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

        public Checkout(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            // TO-DO: obtain user's order info; write to user's .txt file



            //.ToString() may be replaced with another method to orient orders
            //into a comma separated list following the format:
            //Name,Category,Price,Description
            //Burger,FastFood,5.99,Delicious beef burger
            //Pizza, FastFood,8.99,Cheesy pizza

            //string filePath = $"{username}.txt";
            //File.WriteAllText(filepath, orderWindow.ToString());

        }
    }
}
