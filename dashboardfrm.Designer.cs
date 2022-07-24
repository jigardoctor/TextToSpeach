namespace Shubhamcreation
{
    partial class dashboardfrm
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
            this.login_lb = new MetroFramework.Controls.MetroLabel();
            this.ttosp_bt = new MetroFramework.Controls.MetroButton();
            this.ratelist_bt = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // login_lb
            // 
            this.login_lb.AutoSize = true;
            this.login_lb.Location = new System.Drawing.Point(607, 60);
            this.login_lb.Name = "login_lb";
            this.login_lb.Size = new System.Drawing.Size(44, 19);
            this.login_lb.TabIndex = 0;
            this.login_lb.Text = "Login:";
            this.login_lb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ttosp_bt
            // 
            this.ttosp_bt.Location = new System.Drawing.Point(607, 404);
            this.ttosp_bt.Name = "ttosp_bt";
            this.ttosp_bt.Size = new System.Drawing.Size(107, 23);
            this.ttosp_bt.TabIndex = 1;
            this.ttosp_bt.Text = "Text to Speach";
            this.ttosp_bt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ttosp_bt.UseSelectable = true;
            this.ttosp_bt.Click += new System.EventHandler(this.ttosp_bt_Click);
            // 
            // ratelist_bt
            // 
            this.ratelist_bt.Location = new System.Drawing.Point(483, 404);
            this.ratelist_bt.Name = "ratelist_bt";
            this.ratelist_bt.Size = new System.Drawing.Size(107, 23);
            this.ratelist_bt.TabIndex = 2;
            this.ratelist_bt.Text = "Rate List";
            this.ratelist_bt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ratelist_bt.UseSelectable = true;
            this.ratelist_bt.Click += new System.EventHandler(this.ratelist_bt_Click);
            // 
            // dashboardfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratelist_bt);
            this.Controls.Add(this.ttosp_bt);
            this.Controls.Add(this.login_lb);
            this.Name = "dashboardfrm";
            this.Text = "Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.dashboardfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel login_lb;
        private MetroFramework.Controls.MetroButton ttosp_bt;
        private MetroFramework.Controls.MetroButton ratelist_bt;
    }
}