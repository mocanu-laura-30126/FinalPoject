namespace FinalPoject.HomeUCI.Account.Preferences
{
    partial class PreferencesUC
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
            this.components = new System.ComponentModel.Container();
            this.PnlPreferences = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlCurrency = new System.Windows.Forms.Panel();
            this.LblCurrency = new System.Windows.Forms.Label();
            this.CmbBoxCurrencyP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblUNAU = new System.Windows.Forms.Label();
            this.BtnEditCurrency = new Guna.UI2.WinForms.Guna2Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.BtnSaveCurrency = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PnlPreferences.SuspendLayout();
            this.PnlCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPreferences
            // 
            this.PnlPreferences.BackColor = System.Drawing.Color.White;
            this.PnlPreferences.Controls.Add(this.panel3);
            this.PnlPreferences.Controls.Add(this.panel2);
            this.PnlPreferences.Controls.Add(this.PnlCurrency);
            this.PnlPreferences.Controls.Add(this.label2);
            this.PnlPreferences.Controls.Add(this.label1);
            this.PnlPreferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPreferences.Location = new System.Drawing.Point(0, 0);
            this.PnlPreferences.Name = "PnlPreferences";
            this.PnlPreferences.Size = new System.Drawing.Size(677, 404);
            this.PnlPreferences.TabIndex = 0;
            this.PnlPreferences.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 403);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 1);
            this.panel2.TabIndex = 13;
            // 
            // PnlCurrency
            // 
            this.PnlCurrency.Controls.Add(this.LblCurrency);
            this.PnlCurrency.Controls.Add(this.CmbBoxCurrencyP);
            this.PnlCurrency.Controls.Add(this.LblUNAU);
            this.PnlCurrency.Controls.Add(this.BtnEditCurrency);
            this.PnlCurrency.Controls.Add(this.panel11);
            this.PnlCurrency.Controls.Add(this.panel12);
            this.PnlCurrency.Controls.Add(this.BtnSaveCurrency);
            this.PnlCurrency.Controls.Add(this.label6);
            this.PnlCurrency.Location = new System.Drawing.Point(26, 131);
            this.PnlCurrency.Name = "PnlCurrency";
            this.PnlCurrency.Size = new System.Drawing.Size(620, 70);
            this.PnlCurrency.TabIndex = 8;
            // 
            // LblCurrency
            // 
            this.LblCurrency.AutoSize = true;
            this.LblCurrency.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrency.Location = new System.Drawing.Point(134, 22);
            this.LblCurrency.Name = "LblCurrency";
            this.LblCurrency.Size = new System.Drawing.Size(92, 21);
            this.LblCurrency.TabIndex = 11;
            this.LblCurrency.Text = "Currency";
            this.LblCurrency.Click += new System.EventHandler(this.LblCurrency_Click);
            // 
            // CmbBoxCurrencyP
            // 
            this.CmbBoxCurrencyP.AutoRoundedCorners = true;
            this.CmbBoxCurrencyP.BackColor = System.Drawing.Color.Transparent;
            this.CmbBoxCurrencyP.BorderRadius = 17;
            this.CmbBoxCurrencyP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBoxCurrencyP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCurrencyP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBoxCurrencyP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBoxCurrencyP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbBoxCurrencyP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbBoxCurrencyP.ItemHeight = 30;
            this.CmbBoxCurrencyP.Location = new System.Drawing.Point(125, 56);
            this.CmbBoxCurrencyP.Name = "CmbBoxCurrencyP";
            this.CmbBoxCurrencyP.Size = new System.Drawing.Size(224, 36);
            this.CmbBoxCurrencyP.TabIndex = 9;
            this.CmbBoxCurrencyP.Visible = false;
            this.CmbBoxCurrencyP.SelectedIndexChanged += new System.EventHandler(this.CmbBoxCurrencyP_SelectedIndexChanged);
            // 
            // LblUNAU
            // 
            this.LblUNAU.AutoSize = true;
            this.LblUNAU.ForeColor = System.Drawing.Color.White;
            this.LblUNAU.Location = new System.Drawing.Point(135, 85);
            this.LblUNAU.Name = "LblUNAU";
            this.LblUNAU.Size = new System.Drawing.Size(160, 16);
            this.LblUNAU.TabIndex = 10;
            this.LblUNAU.Text = "Username already in use ";
            // 
            // BtnEditCurrency
            // 
            this.BtnEditCurrency.BorderRadius = 5;
            this.BtnEditCurrency.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditCurrency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEditCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEditCurrency.FillColor = System.Drawing.Color.White;
            this.BtnEditCurrency.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnEditCurrency.Location = new System.Drawing.Point(527, 17);
            this.BtnEditCurrency.Name = "BtnEditCurrency";
            this.BtnEditCurrency.Size = new System.Drawing.Size(75, 45);
            this.BtnEditCurrency.TabIndex = 9;
            this.BtnEditCurrency.Text = "Edit";
            this.BtnEditCurrency.Click += new System.EventHandler(this.BtnEditCurrency_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(620, 2);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 68);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(620, 2);
            this.panel12.TabIndex = 7;
            // 
            // BtnSaveCurrency
            // 
            this.BtnSaveCurrency.BorderRadius = 4;
            this.BtnSaveCurrency.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSaveCurrency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSaveCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSaveCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSaveCurrency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnSaveCurrency.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCurrency.ForeColor = System.Drawing.Color.White;
            this.BtnSaveCurrency.Location = new System.Drawing.Point(527, 77);
            this.BtnSaveCurrency.Name = "BtnSaveCurrency";
            this.BtnSaveCurrency.Size = new System.Drawing.Size(75, 45);
            this.BtnSaveCurrency.TabIndex = 7;
            this.BtnSaveCurrency.Text = "Save";
            this.BtnSaveCurrency.Visible = false;
            this.BtnSaveCurrency.Click += new System.EventHandler(this.BtnSaveCurrency_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update your currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preferences";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            // 
            // PreferencesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlPreferences);
            this.Name = "PreferencesUC";
            this.Size = new System.Drawing.Size(677, 404);
            this.PnlPreferences.ResumeLayout(false);
            this.PnlPreferences.PerformLayout();
            this.PnlCurrency.ResumeLayout(false);
            this.PnlCurrency.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPreferences;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlCurrency;
        private System.Windows.Forms.Label LblUNAU;
        private Guna.UI2.WinForms.Guna2Button BtnEditCurrency;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private Guna.UI2.WinForms.Guna2Button BtnSaveCurrency;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBoxCurrencyP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblCurrency;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
