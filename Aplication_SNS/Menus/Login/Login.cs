using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Menus.MainMenu;

namespace Menus.Log
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void App_Inicialize_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(password_Login.Text==""|| password_Login.Text == "Insert Password..." && userName_Login.Text == "" || userName_Login.Text== "Insert UserName..." || 
               password_Login.Text != "admin" || userName_Login.Text != "admin")
            {

                MessageBox.Show("Please Insert the Right Credentials \nTIP:\nUSER:admin\nPW:admin", "Credential Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if(password_Login.Text == "admin" && userName_Login.Text == "admin")
            {

                this.Close();
                Main_Menu main_Menu = new Main_Menu();
                main_Menu.Show();







            }

        }

        private void userName_Login_Click(object sender, EventArgs e)
        { 

            userName_Login.Clear();

        }


        private void password_Login_Click(object sender, EventArgs e)
        {

            password_Login.Clear();

        }

        private void password_Login_TextChanged(object sender, EventArgs e)
        {
            this.password_Login.UseSystemPasswordChar = true;
        }
    }

}