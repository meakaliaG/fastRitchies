using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fastRitchies
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

            LoginPage login = new LoginPage();

            Application.Run(login);
            // initiate username and filepath
            string username = login.usernameInput.Text;
            string filePath = $"{username}.txt";


            // next
            //Application.Run(new Menu(username));

            // finally
            //Checkout checkout = new Checkout(username);
        }

        public static List<FoodItem> GetItems(string category)
        {
            //DATA STRUCTURE #1
            List<FoodItem> items = new List<FoodItem>();
            switch (category.ToLower()) {
                case "mains":
                    items.Add(new FoodItem("RITchie's Burger", category, 5.00, "Our classic hamburger with lettuce, tomato, and Tiger Sauce.", SystemIcons.Information));
                    items.Add(new FoodItem("Tech Crew Tenders", category, 6.00, "3 piece chicken tenders, comes with a sauce of your choice.", SystemIcons.Information));
                    items.Add(new FoodItem("Springfest Sub", category, 8.00, "A toasted footlong turkey sub with provolone and lettuce.", SystemIcons.Information));
                    items.Add(new FoodItem("Co-op Chicken Nuggets", category, 15.00, "20 piece chicken nuggets, comes with 3 sauces.", SystemIcons.Information));
                    break;
                case "sides":
                    items.Add(new FoodItem("Freshman Fries", category, 2.50, "Side of small curly fries.", SystemIcons.Information));
                    items.Add(new FoodItem("Orientation Onion Rings", category, 2.50, "Side of small onion rings.", SystemIcons.Information));
                    items.Add(new FoodItem("Munson's Mac and Cheese", category, 3.00, "President Munson's favorite Mac and Cheese.", SystemIcons.Information));
                    items.Add(new FoodItem("SAU Strawberry Applesauce", category, 3.00, "Cup of strawberry applesauce.", SystemIcons.Information));
                    break;
                case "drinks":
                    items.Add(new FoodItem("CAB Chocolate Milkshake", category, 3.50, "Small chocolate milkshake, topped with whipped cream.", SystemIcons.Information));
                    items.Add(new FoodItem("Bottled Water", category, 2.00, "16oz bottle of water.", SystemIcons.Information));
                    items.Add(new FoodItem("Library Lemonade", category, 1.50, "Small cup of lemonade.", SystemIcons.Information));
                    items.Add(new FoodItem("Senior Soda", category, 1.50, "Small fountain drink of your choice.", SystemIcons.Information));
                    break;
                case "desserts":
                    items.Add(new FoodItem("CSH Cookies", category, 3.00, "1 double chocolate chip cookie.", SystemIcons.Information));
                    items.Add(new FoodItem("Brick City Brownies", category, 3.00, "1 chocolate chunk brownie.", SystemIcons.Information));
                    items.Add(new FoodItem("Alumni Apple Pie", category, 2.00, "Small curly fries.", SystemIcons.Information));
                    items.Add(new FoodItem("Tiger Tracks Ice Cream", category, 4.00, "RIT exclusive Perry's Ice Cream flavor: Tiger Tracks!", SystemIcons.Information));
                    break;
                default:
                    break;
            }
            return items;
        }
    }
}
