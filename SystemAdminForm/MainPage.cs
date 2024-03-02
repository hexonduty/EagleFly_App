using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAdminForm
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void userCheck_Click(object sender, EventArgs e)
        {
           

            int usernameLineFound;
            int passwordLineFound;

            bool isUsernameCorrect = false;
            bool isPasswordCorrect = false;
            bool isFound = false;

            string username = checkUserName.Text;
            string password = checkPassword.Text;

            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (username == Form1.usernames[i] && password == Form1.passwords[i])
                {
                    richTextBox1.Text = "Username and Password found";
                    usernameLineFound = i;
                    passwordLineFound = i;
                    isUsernameCorrect = true;
                    isPasswordCorrect = true;
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                richTextBox1.Text = "Username or Password not found";
            }
        }

        private void userAddMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }
    }
}
