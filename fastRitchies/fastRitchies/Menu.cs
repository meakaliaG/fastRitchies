using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fastRitchies
{
    public partial class Menu : Form
    {
        string username = "";
        string imagePath = "";
        List<FoodItem> cart = new List<FoodItem>();
        public Menu(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        //SIDE MENU OPTIONS
        private void ShowSides(object sender, EventArgs e)
        {
            // Hides existing menu
            if (tableLayoutPanel1.Controls.Count > 4)
            {
                while (tableLayoutPanel1.Controls.Count > 4)
                {
                    tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
                }
            }

            // Dynamically add buttons for each menu item 
            List<Button> sides = new List<Button>();
            List<FoodItem> menu = Program.GetItems("sides");
            Point sidesLoc = new Point(0, 0);
            for (int i = 0; i < menu.Count; i++)
            {
                sides.Add(new Button());
                sides[i].Name = $"btn-sides-{i}";
                sides[i].Text = menu[i].foodItemName + "\n" + "$" + menu[i].foodPrice + "\n\n" + menu[i].foodDescription;
                sides[i].Size = new Size(217, 110);

                //image for each menu item
                imagePath = $"Assets/{menu[i].foodItemName}.png";
                sides[i].Image = Image.FromFile(imagePath);
                sides[i].TextImageRelation = TextImageRelation.TextBeforeImage;
                sides[i].ImageAlign = ContentAlignment.MiddleRight;
                sides[i].TextAlign = ContentAlignment.MiddleLeft;

                sides[i].Click += (obj, eventArgs) => { AddToCart(obj, eventArgs, Program.GetItems((sender as Button).Text)[int.Parse((obj as Button).Name[10].ToString())]); };

                sides[i].Location = new Point(sidesLoc.X, sidesLoc.Y + (i * 2));

                // Adds button to screen
                tableLayoutPanel1.Controls.Add(sides[i], 1, i + 1);
            }

        }

        //MAIN MENU OPTIONS
        private void ShowMains(object sender, EventArgs e)
        {
            // Hides existing menu
            if (tableLayoutPanel1.Controls.Count > 4)
            {
                while (tableLayoutPanel1.Controls.Count > 4)
                {
                    tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
                }
            }

            // Dynamically add buttons for each menu item 
            List<Button> mains = new List<Button>();
            List<FoodItem> menu = Program.GetItems("mains");
            Point mainsLoc = new Point(0, 0);
            for (int i = 0; i < menu.Count; i++)
            {
                mains.Add(new Button());
                mains[i].Name = $"btn-mains-{i}";
                mains[i].Text = menu[i].foodItemName + "\n" + "$" + menu[i].foodPrice + "\n\n" + menu[i].foodDescription;
                mains[i].Size = new Size(217, 110);

                //image for each of the menu items
                imagePath = $"Assets/{menu[i].foodItemName}.png";
                mains[i].Image = Image.FromFile(imagePath);
                mains[i].TextImageRelation = TextImageRelation.TextBeforeImage;
                mains[i].ImageAlign = ContentAlignment.MiddleRight;
                mains[i].TextAlign = ContentAlignment.MiddleLeft;

                mains[i].Click += (obj, eventArgs) => { AddToCart(obj, eventArgs, Program.GetItems((sender as Button).Text)[int.Parse((obj as Button).Name[10].ToString())]); };

                mains[i].Location = new Point(mainsLoc.X, mainsLoc.Y + (i * 2));

                // Adds button to screen
                tableLayoutPanel1.Controls.Add(mains[i], 0, i + 1);
            }

        }

        private void pastOrdersButton_Click(object sender, EventArgs e)
        {
        }

        //DRINKS MENU OPTIONS
        private void ShowDrinks(object sender, EventArgs e)
        {
            // Hides existing menu
            if (tableLayoutPanel1.Controls.Count > 4)
            {
                while (tableLayoutPanel1.Controls.Count > 4)
                {
                    tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
                }
            }

            // Dynamically add buttons for each menu item 
            List<Button> drinks = new List<Button>();
            List<FoodItem> menu = Program.GetItems("drinks");
            Point drinksLoc = new Point(0, 0);
            for (int i = 0; i < menu.Count; i++)
            {
                drinks.Add(new Button());
                drinks[i].Name = $"btn-drinks-{i}";
                drinks[i].Text = menu[i].foodItemName + "\n" + "$" + menu[i].foodPrice + "\n\n" + menu[i].foodDescription;
                drinks[i].Size = new Size(217, 110);

                //image for each of the menu items
                imagePath = $"Assets/{menu[i].foodItemName}.png";
                drinks[i].Image = Image.FromFile(imagePath);
                drinks[i].TextImageRelation = TextImageRelation.TextBeforeImage;
                drinks[i].ImageAlign = ContentAlignment.MiddleRight;
                drinks[i].TextAlign = ContentAlignment.MiddleLeft;

                drinks[i].Click += (obj, eventArgs) => { AddToCart(obj, eventArgs, Program.GetItems((sender as Button).Text)[int.Parse((obj as Button).Name[11].ToString())]); };
                drinks[i].Location = new Point(drinksLoc.X, drinksLoc.Y + (i * 2));

                // Adds button to screen
                tableLayoutPanel1.Controls.Add(drinks[i], 2, i + 1);
            }
        }

        //DESSERTS MENU OPTIONS
        private void ShowDesserts(object sender, EventArgs e)
        {
            // Hides existing menu
            if (tableLayoutPanel1.Controls.Count > 4)
            {
                while (tableLayoutPanel1.Controls.Count > 4)
                {
                    tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
                }
            }

            // Dynamically add buttons for each menu item 
            List<Button> desserts = new List<Button>();
            List<FoodItem> menu = Program.GetItems("desserts");
            Point dessertsLoc = new Point(0, 0);
            for (int i = 0; i < menu.Count; i++)
            {
                desserts.Add(new Button());
                desserts[i].Name = $"btn-desserts-{i}";
                desserts[i].Text = menu[i].foodItemName + "\n" + "$" + menu[i].foodPrice + "\n\n" + menu[i].foodDescription;
                desserts[i].Size = new Size(217, 110);

                //image for each menu item
                imagePath = $"Assets/{menu[i].foodItemName}.png";
                desserts[i].Image = Image.FromFile(imagePath);
                desserts[i].TextImageRelation = TextImageRelation.TextBeforeImage;
                desserts[i].ImageAlign = ContentAlignment.MiddleRight;
                desserts[i].TextAlign = ContentAlignment.MiddleLeft;

                desserts[i].Click += (obj, eventArgs) => { AddToCart(obj, eventArgs, Program.GetItems((sender as Button).Text)[int.Parse((obj as Button).Name[13].ToString())]); };
                desserts[i].Location = new Point(dessertsLoc.X, dessertsLoc.Y + (i * 2));

                // Adds button to screen
                tableLayoutPanel1.Controls.Add(desserts[i], 3, i + 1);
            }
        }

        int cartCount = 0;
        //add food items to your shopping cart
        private void AddToCart(object sender, EventArgs e, FoodItem foodItem)
        {
            cart.Add(foodItem);
            cartCount++;
            cartCountLabel.Text = "Items in cart: " + cartCount.ToString();
        }

        //show items that you place in your cart
        private void GoToCart(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(username, cart);
            checkout.Show();
        }

        private void cartCountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
