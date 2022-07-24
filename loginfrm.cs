using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace Shubhamcreation
{
    public partial class loginfrm : MetroFramework.Forms.MetroForm
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            if (Properties.Settings.Default.RememberMe)
            {
                user_tx.Text = Properties.Settings.Default.UserName;
                pwd_tx.Text = Properties.Settings.Default.Password;
                ckb.Checked = true;
            }

        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(user_tx.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    user_tx.Focus();
                    return;
                }
                try
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            User obj = db.Query<User>($"Select * from [user] where username ='{user_tx.Text.ToUpper()}' AND password = '{pwd_tx.Text}'", commandType: CommandType .Text).SingleOrDefault();
                            if (obj != null)
                            {
                                using (dashboardfrm frm = new dashboardfrm())
                                {
                                    
                                    frm.ShowDialog();
                                    frm.login_lb.Text = user_tx.Text.ToUpper();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "your username and password don't match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                user_tx.Clear();
                                pwd_tx.Clear();
                                user_tx.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (ckb.Checked)
                {
                    Properties.Settings.Default.UserName = user_tx.Text;
                    Properties.Settings.Default.Password = pwd_tx.Text;

                }
                else
                {
                    Properties.Settings.Default.UserName = null;
                    Properties.Settings.Default.Password = null;
                }
                Properties.Settings.Default.RememberMe = ckb.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
}
