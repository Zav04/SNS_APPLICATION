using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Main_Menu;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void App_Inicialize_Load(object sender, EventArgs e)
        {

        //    String str;
        //    SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

        //    str = "CREATE DATABASE MyDatabase ON PRIMARY " +
        //     "(NAME = MyDatabase_Data, " +
        //     "FILENAME = 'C:\\MyDatabaseData.mdf', " +
        //     "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
        //     "LOG ON (NAME = MyDatabase_Log, " +
        //     "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
        //     "SIZE = 1MB, " +
        //     "MAXSIZE = 5MB, " +
        //     "FILEGROWTH = 10%)";

        //    SqlCommand myCommand = new SqlCommand(str, myConn);
        //    try
        //    {
        //        myConn.Open();
        //        myCommand.ExecuteNonQuery();
        //        MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    finally
        //    {
        //        if (myConn.State == ConnectionState.Open)
        //        {
        //            myConn.Close();
        //        }
        //    }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(password_Login.Text==""|| password_Login.Text == "Insert Password..." && userName_Login.Text == "" || userName_Login.Text== "Insert UserName...")
            {

                MessageBox.Show("Please Insert the Right Credentials ", "Credential Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if(password_Login.Text == "admin" && userName_Login.Text == "admin")
            {

                this.Hide();
                Main_Menu.Main_Menu main_Menu = new Main_Menu.Main_Menu();
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

    }

}