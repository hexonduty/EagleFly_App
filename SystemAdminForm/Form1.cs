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

        public static string[] usernames = new string[120];
        public static string[] passwords = new string[120];
        public static int userIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome to the Eagle Fly System.\r\n Please click the OK button to load the system.", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = userPassword.Text;

            dataGridView1.Rows.Add(username, password, DateTime.Now);

            usernames[userIndex] = username;
            passwords[userIndex] = password;
            userIndex++;

            MessageBox.Show($"Kullanici sisteme basariyla eklendi [Kullanici No: {userIndex.ToString()}]", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();

            mainPage.Show();

            this.Hide();
        }

      
    }
}
