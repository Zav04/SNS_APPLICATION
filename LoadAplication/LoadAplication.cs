using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;


namespace LoadAplication
{
    public partial class LoadAplication : Form
    {
        public LoadAplication()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            button1.Visible = false;
            button2.Visible=false;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Login.Login newFormLogin = new Login.Login();
                newFormLogin.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
