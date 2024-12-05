using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastRitchies
{
    public partial class LoginPage : Form

    {
        string username = "";
        string filepath = "";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            string username = Console.ReadLine();
            string filepath = $"{username}.txt";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
