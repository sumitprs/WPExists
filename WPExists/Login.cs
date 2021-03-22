using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPExists.Action;

namespace WPExists
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(SettingConfig.AUTOFILL_USERNAME)
            {
                txtUserName.Text = SettingConfig.USER;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="" || txtPassword.Text=="")
            {
                msg = "Invalid Credentials";
                return;
            }

            if(SettingConfig.USER==txtUserName.Text && SettingConfig.PASSWORD==txtPassword.Text)
            {
                SettingConfig.LOGGEDIN = true;
                WPExists wP = new WPExists();
                this.Hide();
                wP.Show();
            }
            else
            {
                msg = "Invalid Credentials";
                return;
            }
        }

        public string msg
        {
            set
            {
                MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
