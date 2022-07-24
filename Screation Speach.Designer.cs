namespace Shubhamcreation
{
    partial class ttosp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ttosp));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.text_tx = new MetroFramework.Controls.MetroTextBox();
            this.calcle_bt = new MetroFramework.Controls.MetroButton();
            this.resume_bt = new MetroFramework.Controls.MetroButton();
            this.pause_bt = new MetroFramework.Controls.MetroButton();
            this.speach_bt = new MetroFramework.Controls.MetroButton();
            this.save_bt = new MetroFramework.Controls.MetroButton();
            this.metroComboBox2 = new System.Windows.Forms.ComboBox();
            this.metroComboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select Voice";
            this.metroLabel1.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            // 
            // text_tx
            // 
            // 
            // 
            // 
            this.text_tx.CustomButton.Image = null;
            this.text_tx.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.text_tx.CustomButton.Name = "";
            this.text_tx.CustomButton.Size = new System.Drawing.Size(305, 305);
            this.text_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_tx.CustomButton.TabIndex = 1;
            this.text_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_tx.CustomButton.UseSelectable = true;
            this.text_tx.CustomButton.Visible = false;
            this.text_tx.Lines = new string[0];
            this.text_tx.Location = new System.Drawing.Point(23, 58);
            this.text_tx.MaxLength = 32767;
            this.text_tx.Multiline = true;
            this.text_tx.Name = "text_tx";
            this.text_tx.PasswordChar = '\0';
            this.text_tx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_tx.SelectedText = "";
            this.text_tx.SelectionLength = 0;
            this.text_tx.SelectionStart = 0;
            this.text_tx.ShortcutsEnabled = true;
            this.text_tx.Size = new System.Drawing.Size(372, 307);
            this.text_tx.TabIndex = 2;
            this.text_tx.UseSelectable = true;
            this.text_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // calcle_bt
            // 
            this.calcle_bt.Location = new System.Drawing.Point(345, 381);
            this.calcle_bt.Name = "calcle_bt";
            this.calcle_bt.Size = new System.Drawing.Size(50, 23);
            this.calcle_bt.TabIndex = 3;
            this.calcle_bt.Text = "Cancle";
            this.calcle_bt.UseSelectable = true;
            this.calcle_bt.Click += new System.EventHandler(this.calcle_bt_Click);
            // 
            // resume_bt
            // 
            this.resume_bt.Location = new System.Drawing.Point(135, 381);
            this.resume_bt.Name = "resume_bt";
            this.resume_bt.Size = new System.Drawing.Size(50, 23);
            this.resume_bt.TabIndex = 4;
            this.resume_bt.Text = "Resume";
            this.resume_bt.UseSelectable = true;
            this.resume_bt.Click += new System.EventHandler(this.resume_bt_Click);
            // 
            // pause_bt
            // 
            this.pause_bt.Location = new System.Drawing.Point(79, 381);
            this.pause_bt.Name = "pause_bt";
            this.pause_bt.Size = new System.Drawing.Size(50, 23);
            this.pause_bt.TabIndex = 5;
            this.pause_bt.Text = "Pause";
            this.pause_bt.UseSelectable = true;
            this.pause_bt.Click += new System.EventHandler(this.pause_bt_Click);
            // 
            // speach_bt
            // 
            this.speach_bt.Location = new System.Drawing.Point(23, 381);
            this.speach_bt.Name = "speach_bt";
            this.speach_bt.Size = new System.Drawing.Size(50, 23);
            this.speach_bt.TabIndex = 6;
            this.speach_bt.Text = "Speak";
            this.speach_bt.UseSelectable = true;
            this.speach_bt.Click += new System.EventHandler(this.speach_bt_Click);
            // 
            // save_bt
            // 
            this.save_bt.Location = new System.Drawing.Point(289, 381);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(50, 23);
            this.save_bt.TabIndex = 7;
            this.save_bt.Text = "Save";
            this.save_bt.UseSelectable = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.metroComboBox2.Location = new System.Drawing.Point(303, 31);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(92, 21);
            this.metroComboBox2.TabIndex = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.Location = new System.Drawing.Point(203, 31);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(94, 21);
            this.metroComboBox1.TabIndex = 11;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // ttosp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 424);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.speach_bt);
            this.Controls.Add(this.pause_bt);
            this.Controls.Add(this.resume_bt);
            this.Controls.Add(this.calcle_bt);
            this.Controls.Add(this.text_tx);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ttosp";
            this.Resizable = false;
            this.Text = "Text to Speach";
            this.Load += new System.EventHandler(this.ttosp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        
        private System.Windows.Forms.BindingSource userBindingSource;
       
        private MetroFramework.Controls.MetroTextBox text_tx;
        private MetroFramework.Controls.MetroButton calcle_bt;
        private MetroFramework.Controls.MetroButton resume_bt;
        private MetroFramework.Controls.MetroButton pause_bt;
        private MetroFramework.Controls.MetroButton speach_bt;
        private MetroFramework.Controls.MetroButton save_bt;
        private System.Windows.Forms.ComboBox metroComboBox2;
        private System.Windows.Forms.ComboBox metroComboBox1;
    }
}