using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.View
{
    public partial class LoginDialog : Form
    {
        
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;

            bool loggatoConSuccesso = Controller.GetInstance().login(username, password);

            if (!loggatoConSuccesso)
            {
                this.Refresh();
                MessageBox.Show("Username o password errati");
            }
            else
            {
                Controller.GetInstance().SetView();
                this.Hide();
            }

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
