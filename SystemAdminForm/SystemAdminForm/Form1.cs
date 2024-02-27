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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome to the Eagle Fly System.\r\n Please click the OK button to load the system.", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usersListBox.Items.Add("einTheDeveloper" + " : " + "unknown");
        }



        private void loginButton_Click(object sender, EventArgs e)
        {

            int userPasswordInput = Convert.ToInt32(userPassword.Text);
            int userRepeatPasswordInput = Convert.ToInt32(userRepeatPassword.Text);

            if (userName.Text.Length <= 10 && userPasswordInput == userRepeatPasswordInput)
            {
                MessageBox.Show("Your Username and Password have been save successfully");

                string userData = userName.Text + " : " + userPasswordInput;
                usersListBox.Items.Add(userData);
            }
            else
            {
                MessageBox.Show("Your Username must be equal to ten Characters and Your Password must be consistent of only Numbers");
            }
        }

       
    }
}
