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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            SetUserName();
        }
        private void SetUserName()
        {
            try
            {
                lblUserName.Text = SettingConfig.USER;
                chkShowUserOnLogin.Checked = SettingConfig.AUTOFILL_USERNAME;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUserName_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNewUserName.Text))
                {
                    SettingConfig.USER = txtNewUserName.Text;
                    MessageBox.Show("User Name Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewUserName.ResetText();
                }
                else
                {
                    MessageBox.Show("User Name can not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowUserOnLogin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SettingConfig.AUTOFILL_USERNAME = chkShowUserOnLogin.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOldPassword.Text))
                {
                    MessageBox.Show("Enter existing password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtNewPassword.Text)) { 
                    MessageBox.Show("Enter New password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtRePassword.Text != txtNewPassword.Text) { 
                    MessageBox.Show("New passwords does not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtOldPassword.Text != SettingConfig.PASSWORD)
                {
                    MessageBox.Show("Wrong Existing Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SettingConfig.PASSWORD = txtNewPassword.Text;
                MessageBox.Show("Password Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.ResetText();
                txtOldPassword.ResetText();
                txtRePassword.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
