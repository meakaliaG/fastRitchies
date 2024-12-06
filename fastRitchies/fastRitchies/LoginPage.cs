using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastRitchies
{
    public partial class LoginPage : Form

    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void LoadOrders(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Order history file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Read file and parse orders
                var orders = ParseOrders(filePath);

                // Display orders in ListView
                foreach (var order in orders)
                {
                    var listViewItem = new ListViewItem(order.foodItemName);
                    //listViewItem.SubItems.Add(order.Category);
                    listViewItem.SubItems.Add(order.foodPrice.ToString("C"));
                    listViewItem.SubItems.Add(order.foodDescription);

                    pastOrdersWindow.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<FoodItem> ParseOrders(string filePath)
        {
            var orders = new List<FoodItem>();

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(',');
                if (parts.Length < 4) continue; // Skip invalid lines

                var name = parts[0].Trim();
                var category = parts[1].Trim();
                if (!double.TryParse(parts[2], out var price)) continue; // Skip invalid price
                var description = parts[3].Trim();

                // Assuming a default Icon for simplicity
                var defaultIcon = SystemIcons.Application;

                var foodItem = new FoodItem(name, category, price, description, defaultIcon);
                orders.Add(foodItem);
            }

            return orders;
        }



        private void Enter(object sender, KeyEventArgs e)
        {
           

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string filePath = $"{username}.txt";

            if (string.IsNullOrWhiteSpace(username))
            {
                loginLabel.Text = "Please enter a username.";
                loginLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (File.Exists(filePath))
            {
                //load user past orders
                LoadOrders(filePath);
            }
            else
            {
                loginLabel.Text = $"{username}'s account does not exist. Please click the new account button below.";
                loginLabel.ForeColor = System.Drawing.Color.Red;
            }
        }




        private void newAccountButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string filePath = $"{username}.txt";

            if (string.IsNullOrWhiteSpace(username))
            {
                loginLabel.Text = "Please enter a username.";
                loginLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }


            if (File.Exists(filePath))
            {
                loginLabel.Text = $"{username}'s account already exists. Please click the login button to the side.";
                loginLabel.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                File.WriteAllText(filePath, ""); // Create an empty file
                loginLabel.Text = $"File '{filePath}' created successfully.";
                loginLabel.ForeColor = System.Drawing.Color.Green;

            }
        }
       
    }
}
