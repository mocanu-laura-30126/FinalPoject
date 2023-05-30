namespace FinalPoject.HomeUCI
{
    partial class HomeUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCurrency = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.TxtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnCurrency);
            this.panel1.Controls.Add(this.BtnSignIn);
            this.panel1.Controls.Add(this.TxtSearchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 62);
            this.panel1.TabIndex = 0;
            // 
            // BtnCurrency
            // 
            this.BtnCurrency.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnCurrency.BorderThickness = 1;
            this.BtnCurrency.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCurrency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCurrency.FillColor = System.Drawing.Color.White;
            this.BtnCurrency.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnCurrency.Location = new System.Drawing.Point(655, 13);
            this.BtnCurrency.Name = "BtnCurrency";
            this.BtnCurrency.Size = new System.Drawing.Size(97, 31);
            this.BtnCurrency.TabIndex = 6;
            this.BtnCurrency.Text = "USD";
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BorderRadius = 15;
            this.BtnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnSignIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.White;
            this.BtnSignIn.Location = new System.Drawing.Point(764, 13);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(89, 33);
            this.BtnSignIn.TabIndex = 1;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // TxtSearchBar
            // 
            this.TxtSearchBar.BorderRadius = 15;
            this.TxtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchBar.DefaultText = "";
            this.TxtSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchBar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchBar.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSearchBar.IconLeft")));
            this.TxtSearchBar.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.TxtSearchBar.Location = new System.Drawing.Point(23, 13);
            this.TxtSearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSearchBar.Name = "TxtSearchBar";
            this.TxtSearchBar.PasswordChar = '\0';
            this.TxtSearchBar.PlaceholderText = "Search...";
            this.TxtSearchBar.SelectedText = "";
            this.TxtSearchBar.Size = new System.Drawing.Size(308, 31);
            this.TxtSearchBar.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 546);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 3);
            this.panel3.TabIndex = 7;
            // 
            // HomeUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeUc";
            this.Size = new System.Drawing.Size(892, 608);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnSignIn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnCurrency;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchBar;
        private System.Windows.Forms.Panel panel3;
    }
}
