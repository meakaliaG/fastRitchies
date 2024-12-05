using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
