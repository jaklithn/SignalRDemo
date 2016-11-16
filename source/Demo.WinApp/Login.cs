using System;
using System.Windows.Forms;
using Demo.WinApp.Extenders;
using Demo.WinApp.Properties;

namespace Demo.WinApp
{
    public partial class Login : Form
    {
        public static bool AllowAutologin
        {
            get { return Settings.Default.RememberMe; }
            set
            {
                Settings.Default.RememberMe = value;
                Settings.Default.Save();
            }
        }

        private void GetSettings()
        {
            txtUserName.Text = Settings.Default.UserName;
            txtPassword.Text = Settings.Default.Password;
            chkRememberMe.Checked = Settings.Default.RememberMe;
        }

        private void SaveSettings()
        {
            Settings.Default.UserName = txtUserName.Text.ToUpperFirst();
            Settings.Default.Password = txtPassword.Text;
            Settings.Default.RememberMe = chkRememberMe.Checked;
            Settings.Default.Save();
        }

        #region Event Handlers

        private void Login_Activated(object sender, EventArgs e)
        {
            GetSettings();
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}