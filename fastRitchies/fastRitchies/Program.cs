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

            //class testing
            //FoodCategory burger = new FoodCategory("Burger");
            //FoodItem cheeseSupreme = new FoodItem("Cheeseburger Supreme");
        }
    }
}
