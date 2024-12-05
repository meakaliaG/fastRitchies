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
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainsButton_Click(object sender, EventArgs e)
        {
            // Dynamically add buttons for each menu item 
            List<Button> mains = new List<Button>();
            List<string> menu = Program.GetItems("mains");
            Point mainsLoc = new Point(0, 0);
            for (int i = 0; i < menu.Capacity; i++)
            {
                mains.Add(new Button());
                mains[i].Text = menu[i];
                mains[i].Size = new Size(112, 35);
                mains[i].Location = new Point(mainsLoc.X, mainsLoc.Y + (i * 2));
                tableLayoutPanel1.Controls.Add(mains[i], 0, i+1);
            }
        }
    }
}
