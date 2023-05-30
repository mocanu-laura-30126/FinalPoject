using System;

namespace FinalPoject.Cars
{
    partial class SearchCar
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
            this.Search = new Guna.UI2.WinForms.Guna2Button();
            this.RentACarLabel = new System.Windows.Forms.Label();
            this.FuelCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TransmissionCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GearboxCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BrandCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ClassCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FuelTipeCombo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DateDelivery = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTakeover = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateOfDelivery = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DateOfTakeover = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DeliveryLoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pickup = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeliveryLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PickupLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BorderRadius = 26;
            this.Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(592, 329);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(161, 36);
            this.Search.TabIndex = 65;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RentACarLabel
            // 
            this.RentACarLabel.AutoSize = true;
            this.RentACarLabel.BackColor = System.Drawing.Color.Transparent;
            this.RentACarLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RentACarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RentACarLabel.Location = new System.Drawing.Point(18, 13);
            this.RentACarLabel.Name = "RentACarLabel";
            this.RentACarLabel.Size = new System.Drawing.Size(186, 40);
            this.RentACarLabel.TabIndex = 64;
            this.RentACarLabel.Text = "Rent a car";
            // 
            // FuelCombo
            // 
            this.FuelCombo.BackColor = System.Drawing.Color.Transparent;
            this.FuelCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FuelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuelCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuelCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuelCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FuelCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FuelCombo.ItemHeight = 30;
            this.FuelCombo.Items.AddRange(new object[] {
            "Benzine",
            "Diesel",
            "Hybrid"});
            this.FuelCombo.Location = new System.Drawing.Point(154, 329);
            this.FuelCombo.Name = "FuelCombo";
            this.FuelCombo.Size = new System.Drawing.Size(140, 36);
            this.FuelCombo.TabIndex = 63;
            // 
            // TransmissionCombo
            // 
            this.TransmissionCombo.BackColor = System.Drawing.Color.Transparent;
            this.TransmissionCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TransmissionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransmissionCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TransmissionCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TransmissionCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TransmissionCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TransmissionCombo.ItemHeight = 30;
            this.TransmissionCombo.Items.AddRange(new object[] {
            "Face",
            "Back",
            "Integral (4x4)"});
            this.TransmissionCombo.Location = new System.Drawing.Point(154, 262);
            this.TransmissionCombo.Name = "TransmissionCombo";
            this.TransmissionCombo.Size = new System.Drawing.Size(140, 36);
            this.TransmissionCombo.TabIndex = 62;
            // 
            // GearboxCombo
            // 
            this.GearboxCombo.BackColor = System.Drawing.Color.Transparent;
            this.GearboxCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GearboxCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GearboxCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GearboxCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GearboxCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GearboxCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GearboxCombo.ItemHeight = 30;
            this.GearboxCombo.Items.AddRange(new object[] {
            "Manual",
            "Automatically"});
            this.GearboxCombo.Location = new System.Drawing.Point(154, 191);
            this.GearboxCombo.Name = "GearboxCombo";
            this.GearboxCombo.Size = new System.Drawing.Size(140, 36);
            this.GearboxCombo.TabIndex = 61;
            // 
            // BrandCombo
            // 
            this.BrandCombo.BackColor = System.Drawing.Color.Transparent;
            this.BrandCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BrandCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BrandCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BrandCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BrandCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.BrandCombo.ItemHeight = 30;
            this.BrandCombo.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Dacia",
            "Ford",
            "Mercedes-Benz",
            "Seat",
            "Skoda",
            "Volkswagen",
            "Cupra"});
            this.BrandCombo.Location = new System.Drawing.Point(154, 121);
            this.BrandCombo.Name = "BrandCombo";
            this.BrandCombo.Size = new System.Drawing.Size(140, 36);
            this.BrandCombo.TabIndex = 60;
            // 
            // ClassCombo
            // 
            this.ClassCombo.BackColor = System.Drawing.Color.Transparent;
            this.ClassCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClassCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ClassCombo.ItemHeight = 30;
            this.ClassCombo.Items.AddRange(new object[] {
            "Economy",
            "Business & Family",
            "Premium"});
            this.ClassCombo.Location = new System.Drawing.Point(154, 66);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(140, 36);
            this.ClassCombo.TabIndex = 59;
            this.ClassCombo.SelectedIndexChanged += new System.EventHandler(this.ClassCombo_SelectedIndexChanged);
            // 
            // FuelTipeCombo
            // 
            this.FuelTipeCombo.BackColor = System.Drawing.Color.Transparent;
            this.FuelTipeCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FuelTipeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.FuelTipeCombo.Location = new System.Drawing.Point(25, 340);
            this.FuelTipeCombo.Name = "FuelTipeCombo";
            this.FuelTipeCombo.Size = new System.Drawing.Size(87, 25);
            this.FuelTipeCombo.TabIndex = 58;
            this.FuelTipeCombo.Text = "Fuel Tipe";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(25, 273);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(117, 25);
            this.guna2HtmlLabel9.TabIndex = 57;
            this.guna2HtmlLabel9.Text = "Transmission";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(25, 204);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(90, 25);
            this.guna2HtmlLabel10.TabIndex = 56;
            this.guna2HtmlLabel10.Text = "Gearbox";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(25, 132);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(60, 25);
            this.guna2HtmlLabel11.TabIndex = 55;
            this.guna2HtmlLabel11.Text = "Brand";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(25, 66);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(54, 25);
            this.guna2HtmlLabel12.TabIndex = 54;
            this.guna2HtmlLabel12.Text = "Class";
            // 
            // DateDelivery
            // 
            this.DateDelivery.BorderRadius = 26;
            this.DateDelivery.Checked = true;
            this.DateDelivery.FillColor = System.Drawing.Color.White;
            this.DateDelivery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateDelivery.Location = new System.Drawing.Point(574, 262);
            this.DateDelivery.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateDelivery.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateDelivery.Name = "DateDelivery";
            this.DateDelivery.Size = new System.Drawing.Size(200, 36);
            this.DateDelivery.TabIndex = 53;
            this.DateDelivery.Value = new System.DateTime(2023, 5, 21, 14, 17, 50, 656);
            // 
            // DateTakeover
            // 
            this.DateTakeover.BorderRadius = 26;
            this.DateTakeover.Checked = true;
            this.DateTakeover.FillColor = System.Drawing.Color.White;
            this.DateTakeover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTakeover.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTakeover.Location = new System.Drawing.Point(574, 121);
            this.DateTakeover.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTakeover.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTakeover.Name = "DateTakeover";
            this.DateTakeover.Size = new System.Drawing.Size(200, 36);
            this.DateTakeover.TabIndex = 52;
            this.DateTakeover.Value = new System.DateTime(2023, 5, 21, 14, 17, 50, 656);
            // 
            // DateOfDelivery
            // 
            this.DateOfDelivery.BackColor = System.Drawing.Color.Transparent;
            this.DateOfDelivery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateOfDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.DateOfDelivery.Location = new System.Drawing.Point(382, 273);
            this.DateOfDelivery.Name = "DateOfDelivery";
            this.DateOfDelivery.Size = new System.Drawing.Size(161, 25);
            this.DateOfDelivery.TabIndex = 51;
            this.DateOfDelivery.Text = "Date of delivery";
            // 
            // DateOfTakeover
            // 
            this.DateOfTakeover.BackColor = System.Drawing.Color.Transparent;
            this.DateOfTakeover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateOfTakeover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.DateOfTakeover.Location = new System.Drawing.Point(382, 132);
            this.DateOfTakeover.Name = "DateOfTakeover";
            this.DateOfTakeover.Size = new System.Drawing.Size(172, 25);
            this.DateOfTakeover.TabIndex = 50;
            this.DateOfTakeover.Text = "Date of takeover";
            // 
            // DeliveryLoc
            // 
            this.DeliveryLoc.BorderRadius = 26;
            this.DeliveryLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeliveryLoc.DefaultText = "";
            this.DeliveryLoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeliveryLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeliveryLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeliveryLoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeliveryLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeliveryLoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryLoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeliveryLoc.Location = new System.Drawing.Point(574, 191);
            this.DeliveryLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeliveryLoc.Name = "DeliveryLoc";
            this.DeliveryLoc.PasswordChar = '\0';
            this.DeliveryLoc.PlaceholderText = "";
            this.DeliveryLoc.SelectedText = "";
            this.DeliveryLoc.Size = new System.Drawing.Size(200, 32);
            this.DeliveryLoc.TabIndex = 49;
            // 
            // Pickup
            // 
            this.Pickup.BorderRadius = 26;
            this.Pickup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pickup.DefaultText = "";
            this.Pickup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pickup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pickup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pickup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pickup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pickup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pickup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pickup.Location = new System.Drawing.Point(574, 66);
            this.Pickup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pickup.Name = "Pickup";
            this.Pickup.PasswordChar = '\0';
            this.Pickup.PlaceholderText = "";
            this.Pickup.SelectedText = "";
            this.Pickup.Size = new System.Drawing.Size(200, 32);
            this.Pickup.TabIndex = 48;
            // 
            // DeliveryLocation
            // 
            this.DeliveryLocation.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeliveryLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.DeliveryLocation.Location = new System.Drawing.Point(382, 204);
            this.DeliveryLocation.Name = "DeliveryLocation";
            this.DeliveryLocation.Size = new System.Drawing.Size(172, 25);
            this.DeliveryLocation.TabIndex = 47;
            this.DeliveryLocation.Text = "Delivery Location";
            // 
            // PickupLocation
            // 
            this.PickupLocation.BackColor = System.Drawing.Color.Transparent;
            this.PickupLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PickupLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.PickupLocation.Location = new System.Drawing.Point(382, 66);
            this.PickupLocation.Name = "PickupLocation";
            this.PickupLocation.Size = new System.Drawing.Size(157, 25);
            this.PickupLocation.TabIndex = 46;
            this.PickupLocation.Text = "Pickup Location";
            // 
            // SearchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Search);
            this.Controls.Add(this.RentACarLabel);
            this.Controls.Add(this.FuelCombo);
            this.Controls.Add(this.TransmissionCombo);
            this.Controls.Add(this.GearboxCombo);
            this.Controls.Add(this.BrandCombo);
            this.Controls.Add(this.ClassCombo);
            this.Controls.Add(this.FuelTipeCombo);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.DateDelivery);
            this.Controls.Add(this.DateTakeover);
            this.Controls.Add(this.DateOfDelivery);
            this.Controls.Add(this.DateOfTakeover);
            this.Controls.Add(this.DeliveryLoc);
            this.Controls.Add(this.Pickup);
            this.Controls.Add(this.DeliveryLocation);
            this.Controls.Add(this.PickupLocation);
            this.Name = "SearchCar";
            this.Size = new System.Drawing.Size(799, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private Guna.UI2.WinForms.Guna2Button Search;
        private System.Windows.Forms.Label RentACarLabel;
        private Guna.UI2.WinForms.Guna2ComboBox FuelCombo;
        private Guna.UI2.WinForms.Guna2ComboBox TransmissionCombo;
        private Guna.UI2.WinForms.Guna2ComboBox GearboxCombo;
        private Guna.UI2.WinForms.Guna2ComboBox BrandCombo;
        private Guna.UI2.WinForms.Guna2ComboBox ClassCombo;
        private Guna.UI2.WinForms.Guna2HtmlLabel FuelTipeCombo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateDelivery;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTakeover;
        private Guna.UI2.WinForms.Guna2HtmlLabel DateOfDelivery;
        private Guna.UI2.WinForms.Guna2HtmlLabel DateOfTakeover;
        private Guna.UI2.WinForms.Guna2TextBox DeliveryLoc;
        private Guna.UI2.WinForms.Guna2TextBox Pickup;
        private Guna.UI2.WinForms.Guna2HtmlLabel DeliveryLocation;
        private Guna.UI2.WinForms.Guna2HtmlLabel PickupLocation;
    }
}
