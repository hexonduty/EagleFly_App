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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      
        

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = "admin";
            string password = "admin";

            if(loginUserName.Text == username && loginPassword.Text == password)
            {
                MainPage form3 = new MainPage();

                form3.Show();

                this.Hide();
            }
        
        }
    }
}
