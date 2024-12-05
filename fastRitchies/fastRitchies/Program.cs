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
            //class testing - liv
            //Icon burgerIcon = new Icon("Assets/burger - solid.svg");
            //FoodCategory burger = new FoodCategory("Burger", burgerIcon);
            //FoodItem cheeseSupreme = new FoodItem("Cheeseburger Supreme", "burger", 15.6, "A cheesy, meaty meal.", burgerIcon);
            //Console.WriteLine("Burger: ", burger);
            //Console.WriteLine(cheeseSupreme);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static List<string> GetItems(string category)
        {
            List<string> items = new List<string>();
            switch (category.ToLower()) {
                case "mains":
                    items.Add("menu 1");
                    items.Add("menu 2");
                    items.Add("menu 3");
                    items.Add("menu 4");
                    break;
                case "sides":
                    items.Add("menu 1");
                    items.Add("menu 2");
                    items.Add("menu 3");
                    items.Add("menu 4");
                    break;
                case "drinks":
                    items.Add("menu 1");
                    items.Add("menu 2");
                    items.Add("menu 3");
                    items.Add("menu 4");
                    break;
                case "desserts":
                    items.Add("menu 1");
                    items.Add("menu 2");
                    items.Add("menu 3");
                    items.Add("menu 4");
                    break;
                default:
                    break;
            }
            return items;
        }
    }
}
