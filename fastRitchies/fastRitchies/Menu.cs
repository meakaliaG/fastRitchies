using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastRitchies
{
    public partial class Menu : Form
    {
        string username = "";
        public Menu(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Menu_Load(object sender, EventArgs e)
        {


        }

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
            // Shows 
            // Dynamically add buttons for each menu item 
                List<Button> sides = new List<Button>();
                List<FoodItem> menu = Program.GetItems("sides");
                Point sidesLoc = new Point(0, 0);
                for (int i = 0; i < menu.Capacity; i++)
                {
                    sides.Add(new Button());
                    sides[i].Name = $"btn-sides-{i}";
                    sides[i].Text = menu[i].foodItemName;
                    sides[i].Size = new Size(112, 35);
                    sides[i].Location = new Point(sidesLoc.X, sidesLoc.Y + (i * 2));
                    // add icon

                    // Adds button to screen
                    tableLayoutPanel1.Controls.Add(sides[i], 1, i + 1);
                }
        }

        private void ShowMains(object sender, EventArgs e)
        {
            // Hides existing menu
            if(tableLayoutPanel1.Controls.Count > 4)
           { 
                while (tableLayoutPanel1.Controls.Count > 4)
                {
                    tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
                }
            }
            // Shows 
            // Dynamically add buttons for each menu item 
                List<Button> mains = new List<Button>();
                List<FoodItem> menu = Program.GetItems("mains");
                Point mainsLoc = new Point(0, 0);
                for (int i = 0; i < menu.Capacity; i++)
                {
                    mains.Add(new Button());
                    mains[i].Name = $"btn-mains-{i}";
                    mains[i].Text = menu[i].foodItemName;
                    mains[i].Size = new Size(112, 35);
                    mains[i].Location = new Point(mainsLoc.X, mainsLoc.Y + (i * 2));
                    // add icon

                    // Adds button to screen
                    tableLayoutPanel1.Controls.Add(mains[i], 0, i + 1);
                }
            
        }

        private void pastOrdersButton_Click(object sender, EventArgs e)
        {
            // TO-DO: add pop-up of past-orders
            //        make clickable to re-order if time
        }

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

            // Shows 
            // Dynamically add buttons for each menu item 
            List<Button> drinks = new List<Button>();
            List<FoodItem> menu = Program.GetItems("drinks");
            Point drinksLoc = new Point(0, 0);
            for (int i = 0; i < menu.Capacity; i++)
            {
                drinks.Add(new Button());
                drinks[i].Name = $"btn-drinks-{i}";
                drinks[i].Text = menu[i].foodItemName;
                drinks[i].Size = new Size(112, 35);
                drinks[i].Location = new Point(drinksLoc.X, drinksLoc.Y + (i * 2));
                // add icon

                // Adds button to screen
                tableLayoutPanel1.Controls.Add(drinks[i], 2, i + 1);
            }
        }

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

            // Shows 
            // Dynamically add buttons for each menu item 
            List<Button> desserts = new List<Button>();
            List<FoodItem> menu = Program.GetItems("desserts");
            Point dessertsLoc = new Point(0, 0);
            for (int i = 0; i < menu.Capacity; i++)
            {
                desserts.Add(new Button());
                desserts[i].Name = $"btn-drinks-{i}";
                desserts[i].Text = menu[i].foodItemName;
                desserts[i].Size = new Size(112, 35);
                desserts[i].Location = new Point(dessertsLoc.X, dessertsLoc.Y + (i * 2));
                // add icon

                // Adds button to screen
                tableLayoutPanel1.Controls.Add(desserts[i], 3, i + 1);
            }
        }
    }
}
