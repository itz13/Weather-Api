namespace WeatherAPI
{
    partial class WeatherAPIForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnWeatherJSON = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWeatherXML = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtFeels = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a zip code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(35, 84);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(311, 20);
            this.txtCity.TabIndex = 2;
            // 
            // btnWeatherJSON
            // 
            this.btnWeatherJSON.BackColor = System.Drawing.Color.Navy;
            this.btnWeatherJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWeatherJSON.ForeColor = System.Drawing.Color.Blue;
            this.btnWeatherJSON.Location = new System.Drawing.Point(28, 279);
            this.btnWeatherJSON.Name = "btnWeatherJSON";
            this.btnWeatherJSON.Size = new System.Drawing.Size(168, 35);
            this.btnWeatherJSON.TabIndex = 3;
            this.btnWeatherJSON.Text = "Get Weather (JSON)";
            this.btnWeatherJSON.UseVisualStyleBackColor = false;
            this.btnWeatherJSON.Click += new System.EventHandler(this.btnWeatherJSON_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(199, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Longitude";
            // 
            // btnWeatherXML
            // 
            this.btnWeatherXML.BackColor = System.Drawing.Color.Navy;
            this.btnWeatherXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWeatherXML.ForeColor = System.Drawing.Color.Blue;
            this.btnWeatherXML.Location = new System.Drawing.Point(202, 279);
            this.btnWeatherXML.Name = "btnWeatherXML";
            this.btnWeatherXML.Size = new System.Drawing.Size(176, 35);
            this.btnWeatherXML.TabIndex = 6;
            this.btnWeatherXML.Text = "Get Weather (XML)";
            this.btnWeatherXML.UseVisualStyleBackColor = false;
            this.btnWeatherXML.Click += new System.EventHandler(this.btnWeatherXML_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(111, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(199, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "High";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(293, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Feels like";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(34, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Wind";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(199, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Clouds";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(35, 33);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(311, 20);
            this.txtZip.TabIndex = 13;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(35, 134);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(145, 20);
            this.txtLatitude.TabIndex = 14;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(202, 134);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(145, 20);
            this.txtLongitude.TabIndex = 15;
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Location = new System.Drawing.Point(36, 179);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(64, 20);
            this.txtTemp.TabIndex = 16;
            // 
            // txtLow
            // 
            this.txtLow.Enabled = false;
            this.txtLow.Location = new System.Drawing.Point(114, 179);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(52, 20);
            this.txtLow.TabIndex = 17;
            // 
            // txtHigh
            // 
            this.txtHigh.Enabled = false;
            this.txtHigh.Location = new System.Drawing.Point(202, 179);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(51, 20);
            this.txtHigh.TabIndex = 18;
            // 
            // txtFeels
            // 
            this.txtFeels.Enabled = false;
            this.txtFeels.Location = new System.Drawing.Point(274, 179);
            this.txtFeels.Name = "txtFeels";
            this.txtFeels.Size = new System.Drawing.Size(73, 20);
            this.txtFeels.TabIndex = 19;
            // 
            // txtWind
            // 
            this.txtWind.Enabled = false;
            this.txtWind.Location = new System.Drawing.Point(36, 223);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(130, 20);
            this.txtWind.TabIndex = 20;
            // 
            // txtClouds
            // 
            this.txtClouds.Enabled = false;
            this.txtClouds.Location = new System.Drawing.Point(202, 223);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.Size = new System.Drawing.Size(130, 20);
            this.txtClouds.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 4;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClose.Location = new System.Drawing.Point(162, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WeatherAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(403, 355);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtFeels);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWeatherXML);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWeatherJSON);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherAPIForm";
            this.Text = "g";
            this.Load += new System.EventHandler(this.WeatherAPIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnWeatherJSON;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWeatherXML;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtFeels;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtClouds;
        private System.Windows.Forms.Button btnClose;
    }
}