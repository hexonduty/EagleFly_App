namespace SystemAdminForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginPageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.usersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemAdminForm.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameLabel.Location = new System.Drawing.Point(12, 22);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(59, 18);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userName.Location = new System.Drawing.Point(12, 43);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(159, 27);
            this.userName.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.Location = new System.Drawing.Point(12, 136);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(159, 47);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Add User";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Controls.Add(this.dataGridView1);
            this.usersGroupBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usersGroupBox.Location = new System.Drawing.Point(201, 68);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Size = new System.Drawing.Size(571, 346);
            this.usersGroupBox.TabIndex = 8;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = "Your Accounts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KullaniciAdi,
            this.parola,
            this.dateTime});
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.HeaderText = "UserName";
            this.KullaniciAdi.Name = "KullaniciAdi";
            // 
            // parola
            // 
            this.parola.HeaderText = "Password";
            this.parola.Name = "parola";
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date";
            this.dateTime.Name = "dateTime";
            this.dateTime.Width = 300;
            // 
            // loginPageButton
            // 
            this.loginPageButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginPageButton.Location = new System.Drawing.Point(15, 221);
            this.loginPageButton.Name = "loginPageButton";
            this.loginPageButton.Size = new System.Drawing.Size(156, 45);
            this.loginPageButton.TabIndex = 1;
            this.loginPageButton.Text = "Check User Menu";
            this.loginPageButton.UseVisualStyleBackColor = true;
            this.loginPageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "İf you want to check just users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userPassword.Location = new System.Drawing.Point(12, 103);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(156, 27);
            this.userPassword.TabIndex = 12;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 479);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginPageButton);
            this.Controls.Add(this.usersGroupBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.usersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.Button loginPageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn parola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

