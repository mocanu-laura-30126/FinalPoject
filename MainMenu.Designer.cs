namespace FinalPoject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnDestinations = new Guna.UI2.WinForms.Guna2Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnCars = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnTrains = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFlights = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHotels = new Guna.UI2.WinForms.Guna2Button();
            this.ImgSlider = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.BtnDestinations);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.BtnCars);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.BtnTrains);
            this.Panel1.Controls.Add(this.BtnFlights);
            this.Panel1.Controls.Add(this.BtnHome);
            this.Panel1.Controls.Add(this.BtnHotels);
            this.Panel1.Controls.Add(this.ImgSlider);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(180, 608);
            this.Panel1.TabIndex = 1;
            // 
            // BtnDestinations
            // 
            this.BtnDestinations.BackColor = System.Drawing.Color.Transparent;
            this.BtnDestinations.BorderRadius = 22;
            this.BtnDestinations.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnDestinations.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnDestinations.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnDestinations.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnDestinations.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDestinations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDestinations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDestinations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDestinations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnDestinations.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDestinations.ForeColor = System.Drawing.Color.White;
            this.BtnDestinations.Image = ((System.Drawing.Image)(resources.GetObject("BtnDestinations.Image")));
            this.BtnDestinations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDestinations.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnDestinations.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnDestinations.Location = new System.Drawing.Point(25, 469);
            this.BtnDestinations.Name = "BtnDestinations";
            this.BtnDestinations.Size = new System.Drawing.Size(155, 43);
            this.BtnDestinations.TabIndex = 13;
            this.BtnDestinations.Text = "Destinations";
            this.BtnDestinations.TextOffset = new System.Drawing.Point(15, 0);
            this.BtnDestinations.UseTransparentBackground = true;
            this.BtnDestinations.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            this.BtnDestinations.Click += new System.EventHandler(this.BtnDestinations_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(64, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 27);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "TripWise";
            // 
            // BtnCars
            // 
            this.BtnCars.BackColor = System.Drawing.Color.Transparent;
            this.BtnCars.BorderRadius = 22;
            this.BtnCars.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCars.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnCars.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnCars.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BtnCars.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCars.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCars.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCars.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCars.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnCars.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCars.ForeColor = System.Drawing.Color.White;
            this.BtnCars.Image = ((System.Drawing.Image)(resources.GetObject("BtnCars.Image")));
            this.BtnCars.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCars.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnCars.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnCars.Location = new System.Drawing.Point(25, 401);
            this.BtnCars.Name = "BtnCars";
            this.BtnCars.Size = new System.Drawing.Size(155, 43);
            this.BtnCars.TabIndex = 12;
            this.BtnCars.Text = "Cars";
            this.BtnCars.UseTransparentBackground = true;
            this.BtnCars.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            this.BtnCars.Click += new System.EventHandler(this.BtnCars_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(46, 57);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // BtnTrains
            // 
            this.BtnTrains.BackColor = System.Drawing.Color.Transparent;
            this.BtnTrains.BorderRadius = 22;
            this.BtnTrains.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnTrains.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnTrains.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnTrains.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BtnTrains.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTrains.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTrains.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTrains.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTrains.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnTrains.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrains.ForeColor = System.Drawing.Color.White;
            this.BtnTrains.Image = ((System.Drawing.Image)(resources.GetObject("BtnTrains.Image")));
            this.BtnTrains.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTrains.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnTrains.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnTrains.Location = new System.Drawing.Point(25, 333);
            this.BtnTrains.Name = "BtnTrains";
            this.BtnTrains.Size = new System.Drawing.Size(155, 43);
            this.BtnTrains.TabIndex = 11;
            this.BtnTrains.Text = "Trains";
            this.BtnTrains.UseTransparentBackground = true;
            this.BtnTrains.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            this.BtnTrains.Click += new System.EventHandler(this.BtnTrains_Click);
            // 
            // BtnFlights
            // 
            this.BtnFlights.BackColor = System.Drawing.Color.Transparent;
            this.BtnFlights.BorderRadius = 22;
            this.BtnFlights.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnFlights.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnFlights.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnFlights.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.BtnFlights.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFlights.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFlights.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFlights.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFlights.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnFlights.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFlights.ForeColor = System.Drawing.Color.White;
            this.BtnFlights.Image = ((System.Drawing.Image)(resources.GetObject("BtnFlights.Image")));
            this.BtnFlights.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFlights.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnFlights.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnFlights.Location = new System.Drawing.Point(25, 265);
            this.BtnFlights.Name = "BtnFlights";
            this.BtnFlights.Size = new System.Drawing.Size(155, 43);
            this.BtnFlights.TabIndex = 10;
            this.BtnFlights.Text = "Flights";
            this.BtnFlights.UseTransparentBackground = true;
            this.BtnFlights.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            this.BtnFlights.Click += new System.EventHandler(this.BtnFlights_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.BorderRadius = 22;
            this.BtnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnHome.Checked = true;
            this.BtnHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnHome.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnHome.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.BtnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnHome.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnHome.Location = new System.Drawing.Point(25, 129);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(155, 43);
            this.BtnHome.TabIndex = 8;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseTransparentBackground = true;
            this.BtnHome.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnHotels
            // 
            this.BtnHotels.BackColor = System.Drawing.Color.Transparent;
            this.BtnHotels.BorderRadius = 22;
            this.BtnHotels.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnHotels.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnHotels.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnHotels.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.BtnHotels.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHotels.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHotels.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHotels.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHotels.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnHotels.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHotels.ForeColor = System.Drawing.Color.White;
            this.BtnHotels.Image = ((System.Drawing.Image)(resources.GetObject("BtnHotels.Image")));
            this.BtnHotels.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnHotels.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnHotels.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnHotels.Location = new System.Drawing.Point(25, 197);
            this.BtnHotels.Name = "BtnHotels";
            this.BtnHotels.Size = new System.Drawing.Size(155, 43);
            this.BtnHotels.TabIndex = 9;
            this.BtnHotels.Text = "Hotels";
            this.BtnHotels.UseTransparentBackground = true;
            this.BtnHotels.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            this.BtnHotels.Click += new System.EventHandler(this.BtnAccomodations_Click);
            // 
            // ImgSlider
            // 
            this.ImgSlider.Image = ((System.Drawing.Image)(resources.GetObject("ImgSlider.Image")));
            this.ImgSlider.Location = new System.Drawing.Point(141, 101);
            this.ImgSlider.Name = "ImgSlider";
            this.ImgSlider.Size = new System.Drawing.Size(39, 95);
            this.ImgSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgSlider.TabIndex = 1;
            this.ImgSlider.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(180, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(0, 5, 6, 5);
            this.MainPanel.Size = new System.Drawing.Size(892, 608);
            this.MainPanel.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox ImgSlider;
        internal Guna.UI2.WinForms.Guna2Button BtnDestinations;
        internal Guna.UI2.WinForms.Guna2Button BtnCars;
        internal Guna.UI2.WinForms.Guna2Button BtnTrains;
        internal Guna.UI2.WinForms.Guna2Button BtnFlights;
        internal Guna.UI2.WinForms.Guna2Button BtnHome;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button BtnHotels;
        private System.Windows.Forms.Panel MainPanel;
    }
}

