namespace FinalPoject.HomeUCI.Account
{
    partial class AccountInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInformation));
            this.PnlMyAccount = new System.Windows.Forms.Panel();
            this.PnlDetails = new System.Windows.Forms.Panel();
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.BtnSecurity = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPreferences = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPersonalDetails = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlMyAccount.SuspendLayout();
            this.PnlOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMyAccount
            // 
            this.PnlMyAccount.BackColor = System.Drawing.Color.White;
            this.PnlMyAccount.Controls.Add(this.PnlDetails);
            this.PnlMyAccount.Controls.Add(this.PnlOptions);
            this.PnlMyAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMyAccount.Location = new System.Drawing.Point(0, 0);
            this.PnlMyAccount.Name = "PnlMyAccount";
            this.PnlMyAccount.Size = new System.Drawing.Size(892, 546);
            this.PnlMyAccount.TabIndex = 2;
            this.PnlMyAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMyAccount_Paint);
            // 
            // PnlDetails
            // 
            this.PnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDetails.Location = new System.Drawing.Point(215, 0);
            this.PnlDetails.Name = "PnlDetails";
            this.PnlDetails.Size = new System.Drawing.Size(677, 546);
            this.PnlDetails.TabIndex = 3;
            // 
            // PnlOptions
            // 
            this.PnlOptions.Controls.Add(this.BtnSecurity);
            this.PnlOptions.Controls.Add(this.BtnPreferences);
            this.PnlOptions.Controls.Add(this.BtnPersonalDetails);
            this.PnlOptions.Controls.Add(this.panel1);
            this.PnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlOptions.Location = new System.Drawing.Point(0, 0);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(215, 546);
            this.PnlOptions.TabIndex = 2;
            // 
            // BtnSecurity
            // 
            this.BtnSecurity.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnSecurity.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnSecurity.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnSecurity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSecurity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSecurity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSecurity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSecurity.FillColor = System.Drawing.Color.White;
            this.BtnSecurity.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnSecurity.Image = ((System.Drawing.Image)(resources.GetObject("BtnSecurity.Image")));
            this.BtnSecurity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSecurity.Location = new System.Drawing.Point(0, 202);
            this.BtnSecurity.Name = "BtnSecurity";
            this.BtnSecurity.Size = new System.Drawing.Size(215, 52);
            this.BtnSecurity.TabIndex = 3;
            this.BtnSecurity.Text = "Security";
            this.BtnSecurity.CheckedChanged += new System.EventHandler(this.BtnSecurity_CheckChanged);
            this.BtnSecurity.Click += new System.EventHandler(this.BtnSecurity_Click);
            // 
            // BtnPreferences
            // 
            this.BtnPreferences.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnPreferences.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnPreferences.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnPreferences.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BtnPreferences.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPreferences.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPreferences.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPreferences.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPreferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPreferences.FillColor = System.Drawing.Color.White;
            this.BtnPreferences.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.BtnPreferences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnPreferences.Image = ((System.Drawing.Image)(resources.GetObject("BtnPreferences.Image")));
            this.BtnPreferences.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPreferences.Location = new System.Drawing.Point(0, 150);
            this.BtnPreferences.Name = "BtnPreferences";
            this.BtnPreferences.Size = new System.Drawing.Size(215, 52);
            this.BtnPreferences.TabIndex = 2;
            this.BtnPreferences.Text = "Preferences";
            this.BtnPreferences.CheckedChanged += new System.EventHandler(this.BtnPreferences_CheckChanged);
            this.BtnPreferences.Click += new System.EventHandler(this.BtnPreferences_Click);
            // 
            // BtnPersonalDetails
            // 
            this.BtnPersonalDetails.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonalDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnPersonalDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnPersonalDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnPersonalDetails.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BtnPersonalDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPersonalDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPersonalDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPersonalDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPersonalDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonalDetails.FillColor = System.Drawing.Color.White;
            this.BtnPersonalDetails.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.BtnPersonalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnPersonalDetails.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnPersonalDetails.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonalDetails.Image")));
            this.BtnPersonalDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPersonalDetails.Location = new System.Drawing.Point(0, 98);
            this.BtnPersonalDetails.Name = "BtnPersonalDetails";
            this.BtnPersonalDetails.Size = new System.Drawing.Size(215, 52);
            this.BtnPersonalDetails.TabIndex = 1;
            this.BtnPersonalDetails.Text = "Personal Details";
            this.BtnPersonalDetails.CheckedChanged += new System.EventHandler(this.BtnPersonalDetails_CheckedChanged);
            this.BtnPersonalDetails.Click += new System.EventHandler(this.BtnPersonalDetails_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 98);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 0;
            // 
            // AccountInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlMyAccount);
            this.Name = "AccountInformation";
            this.Size = new System.Drawing.Size(892, 546);
            this.PnlMyAccount.ResumeLayout(false);
            this.PnlOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlMyAccount;
        private System.Windows.Forms.Panel PnlOptions;
        private Guna.UI2.WinForms.Guna2Button BtnSecurity;
        private Guna.UI2.WinForms.Guna2Button BtnPreferences;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlDetails;
        private Guna.UI2.WinForms.Guna2Button BtnPersonalDetails;
        private System.Windows.Forms.Panel panel2;
    }
}
