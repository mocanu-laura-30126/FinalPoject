namespace FinalPoject.Hotels
{
    partial class SearchHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchHotel));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DTPCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CmBoxDestination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TextBoxNrRooms = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.RdBtn2Star = new Guna.UI2.WinForms.Guna2Button();
            this.RdBtn3Star = new Guna.UI2.WinForms.Guna2Button();
            this.RdBtn4Star = new Guna.UI2.WinForms.Guna2Button();
            this.RdBtn5Star = new Guna.UI2.WinForms.Guna2Button();
            this.RentACarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination";
            // 
            // DTPCheckIn
            // 
            this.DTPCheckIn.BackColor = System.Drawing.Color.White;
            this.DTPCheckIn.Checked = true;
            this.DTPCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.DTPCheckIn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPCheckIn.ForeColor = System.Drawing.Color.Black;
            this.DTPCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPCheckIn.Location = new System.Drawing.Point(230, 119);
            this.DTPCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPCheckIn.Name = "DTPCheckIn";
            this.DTPCheckIn.Size = new System.Drawing.Size(245, 39);
            this.DTPCheckIn.TabIndex = 4;
            this.DTPCheckIn.Value = new System.DateTime(2023, 5, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(226, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check-in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(226, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check-out";
            // 
            // DTPCheckOut
            // 
            this.DTPCheckOut.BackColor = System.Drawing.Color.White;
            this.DTPCheckOut.Checked = true;
            this.DTPCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.DTPCheckOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPCheckOut.ForeColor = System.Drawing.Color.Black;
            this.DTPCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPCheckOut.Location = new System.Drawing.Point(230, 220);
            this.DTPCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPCheckOut.Name = "DTPCheckOut";
            this.DTPCheckOut.Size = new System.Drawing.Size(245, 42);
            this.DTPCheckOut.TabIndex = 6;
            this.DTPCheckOut.Value = new System.DateTime(2023, 5, 24, 0, 0, 0, 0);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.DTPCheckIn;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.DTPCheckOut;
            // 
            // CmBoxDestination
            // 
            this.CmBoxDestination.BackColor = System.Drawing.Color.Transparent;
            this.CmBoxDestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBoxDestination.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmBoxDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmBoxDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmBoxDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmBoxDestination.ItemHeight = 30;
            this.CmBoxDestination.Location = new System.Drawing.Point(33, 119);
            this.CmBoxDestination.Name = "CmBoxDestination";
            this.CmBoxDestination.Size = new System.Drawing.Size(169, 36);
            this.CmBoxDestination.TabIndex = 8;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 26;
            // 
            // TextBoxNrRooms
            // 
            this.TextBoxNrRooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNrRooms.DefaultText = "";
            this.TextBoxNrRooms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNrRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNrRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNrRooms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNrRooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNrRooms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNrRooms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNrRooms.Location = new System.Drawing.Point(508, 119);
            this.TextBoxNrRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxNrRooms.Name = "TextBoxNrRooms";
            this.TextBoxNrRooms.PasswordChar = '\0';
            this.TextBoxNrRooms.PlaceholderText = "";
            this.TextBoxNrRooms.SelectedText = "";
            this.TextBoxNrRooms.Size = new System.Drawing.Size(109, 36);
            this.TextBoxNrRooms.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(504, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of Rooms";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BorderRadius = 5;
            this.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BtnSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(725, 119);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(129, 36);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // RdBtn2Star
            // 
            this.RdBtn2Star.BorderRadius = 15;
            this.RdBtn2Star.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RdBtn2Star.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn2Star.CheckedState.ForeColor = System.Drawing.Color.White;
            this.RdBtn2Star.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn2Star.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn2Star.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RdBtn2Star.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RdBtn2Star.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.RdBtn2Star.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn2Star.ForeColor = System.Drawing.Color.Black;
            this.RdBtn2Star.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn2Star.Image = ((System.Drawing.Image)(resources.GetObject("RdBtn2Star.Image")));
            this.RdBtn2Star.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RdBtn2Star.ImageOffset = new System.Drawing.Point(10, 0);
            this.RdBtn2Star.Location = new System.Drawing.Point(523, 220);
            this.RdBtn2Star.Name = "RdBtn2Star";
            this.RdBtn2Star.Size = new System.Drawing.Size(73, 45);
            this.RdBtn2Star.TabIndex = 14;
            this.RdBtn2Star.Text = "2";
            this.RdBtn2Star.TextOffset = new System.Drawing.Point(-10, 0);
            // 
            // RdBtn3Star
            // 
            this.RdBtn3Star.BorderRadius = 15;
            this.RdBtn3Star.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RdBtn3Star.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn3Star.CheckedState.ForeColor = System.Drawing.Color.White;
            this.RdBtn3Star.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn3Star.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn3Star.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RdBtn3Star.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RdBtn3Star.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.RdBtn3Star.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn3Star.ForeColor = System.Drawing.Color.Black;
            this.RdBtn3Star.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn3Star.Image = ((System.Drawing.Image)(resources.GetObject("RdBtn3Star.Image")));
            this.RdBtn3Star.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RdBtn3Star.ImageOffset = new System.Drawing.Point(10, 0);
            this.RdBtn3Star.Location = new System.Drawing.Point(609, 220);
            this.RdBtn3Star.Name = "RdBtn3Star";
            this.RdBtn3Star.Size = new System.Drawing.Size(73, 45);
            this.RdBtn3Star.TabIndex = 15;
            this.RdBtn3Star.Text = "3";
            this.RdBtn3Star.TextOffset = new System.Drawing.Point(-10, 0);
            // 
            // RdBtn4Star
            // 
            this.RdBtn4Star.BorderRadius = 15;
            this.RdBtn4Star.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RdBtn4Star.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn4Star.CheckedState.ForeColor = System.Drawing.Color.White;
            this.RdBtn4Star.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn4Star.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn4Star.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RdBtn4Star.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RdBtn4Star.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.RdBtn4Star.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn4Star.ForeColor = System.Drawing.Color.Black;
            this.RdBtn4Star.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn4Star.Image = ((System.Drawing.Image)(resources.GetObject("RdBtn4Star.Image")));
            this.RdBtn4Star.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RdBtn4Star.ImageOffset = new System.Drawing.Point(10, 0);
            this.RdBtn4Star.Location = new System.Drawing.Point(695, 220);
            this.RdBtn4Star.Name = "RdBtn4Star";
            this.RdBtn4Star.Size = new System.Drawing.Size(73, 45);
            this.RdBtn4Star.TabIndex = 16;
            this.RdBtn4Star.Text = "4";
            this.RdBtn4Star.TextOffset = new System.Drawing.Point(-10, 0);
            // 
            // RdBtn5Star
            // 
            this.RdBtn5Star.BorderRadius = 15;
            this.RdBtn5Star.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RdBtn5Star.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn5Star.CheckedState.ForeColor = System.Drawing.Color.White;
            this.RdBtn5Star.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn5Star.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RdBtn5Star.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RdBtn5Star.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RdBtn5Star.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.RdBtn5Star.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn5Star.ForeColor = System.Drawing.Color.Black;
            this.RdBtn5Star.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RdBtn5Star.Image = ((System.Drawing.Image)(resources.GetObject("RdBtn5Star.Image")));
            this.RdBtn5Star.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RdBtn5Star.ImageOffset = new System.Drawing.Point(10, 0);
            this.RdBtn5Star.Location = new System.Drawing.Point(781, 220);
            this.RdBtn5Star.Name = "RdBtn5Star";
            this.RdBtn5Star.Size = new System.Drawing.Size(73, 45);
            this.RdBtn5Star.TabIndex = 17;
            this.RdBtn5Star.Text = "5";
            this.RdBtn5Star.TextOffset = new System.Drawing.Point(-10, 0);
            // 
            // RentACarLabel
            // 
            this.RentACarLabel.AutoSize = true;
            this.RentACarLabel.BackColor = System.Drawing.Color.Transparent;
            this.RentACarLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RentACarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.RentACarLabel.Location = new System.Drawing.Point(18, 13);
            this.RentACarLabel.Name = "RentACarLabel";
            this.RentACarLabel.Size = new System.Drawing.Size(312, 40);
            this.RentACarLabel.TabIndex = 65;
            this.RentACarLabel.Text = "Search for a Hotel";
            // 
            // SearchHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RentACarLabel);
            this.Controls.Add(this.RdBtn5Star);
            this.Controls.Add(this.RdBtn4Star);
            this.Controls.Add(this.RdBtn3Star);
            this.Controls.Add(this.RdBtn2Star);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxNrRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPCheckIn);
            this.Controls.Add(this.CmBoxDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPCheckOut);
            this.Name = "SearchHotel";
            this.Size = new System.Drawing.Size(892, 405);
            this.Load += new System.EventHandler(this.SearchHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPCheckOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2ComboBox CmBoxDestination;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNrRooms;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2Button RdBtn2Star;
        private Guna.UI2.WinForms.Guna2Button RdBtn3Star;
        private Guna.UI2.WinForms.Guna2Button RdBtn4Star;
        private Guna.UI2.WinForms.Guna2Button RdBtn5Star;
        private System.Windows.Forms.Label RentACarLabel;
    }
}
