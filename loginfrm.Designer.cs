namespace Shubhamcreation
{
    partial class loginfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginfrm));
            this.ckb = new MetroFramework.Controls.MetroCheckBox();
            this.login_bt = new MetroFramework.Controls.MetroButton();
            this.user_tx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pwd_tx = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.close_bt = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb
            // 
            this.ckb.AutoSize = true;
            this.ckb.Location = new System.Drawing.Point(99, 288);
            this.ckb.Name = "ckb";
            this.ckb.Size = new System.Drawing.Size(101, 15);
            this.ckb.TabIndex = 5;
            this.ckb.Text = "Remember Me";
            this.ckb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ckb.UseSelectable = true;
            this.ckb.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // login_bt
            // 
            this.login_bt.Location = new System.Drawing.Point(75, 331);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(75, 23);
            this.login_bt.TabIndex = 3;
            this.login_bt.Text = "&LogIn";
            this.login_bt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.login_bt.UseSelectable = true;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // user_tx
            // 
            // 
            // 
            // 
            this.user_tx.CustomButton.Image = null;
            this.user_tx.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.user_tx.CustomButton.Name = "";
            this.user_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_tx.CustomButton.TabIndex = 1;
            this.user_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_tx.CustomButton.UseSelectable = true;
            this.user_tx.CustomButton.Visible = false;
            this.user_tx.Lines = new string[0];
            this.user_tx.Location = new System.Drawing.Point(99, 230);
            this.user_tx.MaxLength = 32767;
            this.user_tx.Name = "user_tx";
            this.user_tx.PasswordChar = '\0';
            this.user_tx.PromptText = "Enter User Name";
            this.user_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_tx.SelectedText = "";
            this.user_tx.SelectionLength = 0;
            this.user_tx.SelectionStart = 0;
            this.user_tx.ShortcutsEnabled = true;
            this.user_tx.Size = new System.Drawing.Size(132, 23);
            this.user_tx.TabIndex = 0;
            this.user_tx.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.user_tx.UseSelectable = true;
            this.user_tx.WaterMark = "Enter User Name";
            this.user_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 231);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "User Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 264);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pwd_tx
            // 
            // 
            // 
            // 
            this.pwd_tx.CustomButton.Image = null;
            this.pwd_tx.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.pwd_tx.CustomButton.Name = "";
            this.pwd_tx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pwd_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwd_tx.CustomButton.TabIndex = 1;
            this.pwd_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pwd_tx.CustomButton.UseSelectable = true;
            this.pwd_tx.CustomButton.Visible = false;
            this.pwd_tx.Lines = new string[0];
            this.pwd_tx.Location = new System.Drawing.Point(99, 259);
            this.pwd_tx.MaxLength = 32767;
            this.pwd_tx.Name = "pwd_tx";
            this.pwd_tx.PasswordChar = '*';
            this.pwd_tx.PromptText = "Enter Password";
            this.pwd_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwd_tx.SelectedText = "";
            this.pwd_tx.SelectionLength = 0;
            this.pwd_tx.SelectionStart = 0;
            this.pwd_tx.ShortcutsEnabled = true;
            this.pwd_tx.Size = new System.Drawing.Size(132, 23);
            this.pwd_tx.TabIndex = 1;
            this.pwd_tx.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pwd_tx.UseSelectable = true;
            this.pwd_tx.WaterMark = "Enter Password";
            this.pwd_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pwd_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(156, 331);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(75, 23);
            this.close_bt.TabIndex = 4;
            this.close_bt.Text = "&Close";
            this.close_bt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.close_bt.UseSelectable = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shubhamcreation.Properties.Resources.administrator_icon;
            this.pictureBox1.Location = new System.Drawing.Point(75, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 139);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pwd_tx);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.user_tx);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.ckb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "loginfrm";
            this.Text = "&Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.loginfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox ckb;
        private MetroFramework.Controls.MetroButton login_bt;
        private MetroFramework.Controls.MetroTextBox user_tx;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox pwd_tx;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton close_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

