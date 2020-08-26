namespace CalculatorForm
{
    partial class CalcForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDistanceType = new System.Windows.Forms.ComboBox();
            this.comboSpeedType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTravelTime = new System.Windows.Forms.Button();
            this.btnTravelRate = new System.Windows.Forms.Button();
            this.btnTravelDistance = new System.Windows.Forms.Button();
            this.txtTravelTimeString = new System.Windows.Forms.TextBox();
            this.txtTravelTime = new System.Windows.Forms.TextBox();
            this.txtTravelRate = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTravelDistance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConvertedDistance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboDistanceType
            // 
            this.comboDistanceType.AllowDrop = true;
            this.comboDistanceType.FormattingEnabled = true;
            this.comboDistanceType.Items.AddRange(new object[] {
            "Miles",
            "Kilometers"});
            this.comboDistanceType.Location = new System.Drawing.Point(217, 71);
            this.comboDistanceType.Margin = new System.Windows.Forms.Padding(4);
            this.comboDistanceType.Name = "comboDistanceType";
            this.comboDistanceType.Size = new System.Drawing.Size(108, 29);
            this.comboDistanceType.TabIndex = 4;
            this.comboDistanceType.Text = "...";
            // 
            // comboSpeedType
            // 
            this.comboSpeedType.FormattingEnabled = true;
            this.comboSpeedType.Items.AddRange(new object[] {
            "MPH",
            "KPH"});
            this.comboSpeedType.Location = new System.Drawing.Point(217, 122);
            this.comboSpeedType.Margin = new System.Windows.Forms.Padding(4);
            this.comboSpeedType.Name = "comboSpeedType";
            this.comboSpeedType.Size = new System.Drawing.Size(108, 29);
            this.comboSpeedType.TabIndex = 4;
            this.comboSpeedType.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Distance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(355, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rate of Travel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(594, 267);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Distance Traveled:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 344);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 21);
            this.label12.TabIndex = 0;
            // 
            // btnTravelTime
            // 
            this.btnTravelTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTravelTime.Location = new System.Drawing.Point(117, 393);
            this.btnTravelTime.Name = "btnTravelTime";
            this.btnTravelTime.Size = new System.Drawing.Size(165, 35);
            this.btnTravelTime.TabIndex = 8;
            this.btnTravelTime.Text = "Calculate Travel Time";
            this.btnTravelTime.UseVisualStyleBackColor = false;
            this.btnTravelTime.Click += new System.EventHandler(this.btnTravelTime_Click);
            // 
            // btnTravelRate
            // 
            this.btnTravelRate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTravelRate.Location = new System.Drawing.Point(355, 393);
            this.btnTravelRate.Name = "btnTravelRate";
            this.btnTravelRate.Size = new System.Drawing.Size(180, 35);
            this.btnTravelRate.TabIndex = 8;
            this.btnTravelRate.Text = "Calculate Rate of Travel";
            this.btnTravelRate.UseVisualStyleBackColor = false;
            this.btnTravelRate.Click += new System.EventHandler(this.btnTravelRate_Click);
            // 
            // btnTravelDistance
            // 
            this.btnTravelDistance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTravelDistance.Location = new System.Drawing.Point(594, 393);
            this.btnTravelDistance.Name = "btnTravelDistance";
            this.btnTravelDistance.Size = new System.Drawing.Size(207, 35);
            this.btnTravelDistance.TabIndex = 8;
            this.btnTravelDistance.Text = "Calculate Distance Traveled";
            this.btnTravelDistance.UseVisualStyleBackColor = false;
            this.btnTravelDistance.Click += new System.EventHandler(this.btnTravelDistance_Click);
            // 
            // txtTravelTimeString
            // 
            this.txtTravelTimeString.Location = new System.Drawing.Point(117, 344);
            this.txtTravelTimeString.Name = "txtTravelTimeString";
            this.txtTravelTimeString.ReadOnly = true;
            this.txtTravelTimeString.Size = new System.Drawing.Size(165, 29);
            this.txtTravelTimeString.TabIndex = 9;
            // 
            // txtTravelTime
            // 
            this.txtTravelTime.Location = new System.Drawing.Point(117, 299);
            this.txtTravelTime.Name = "txtTravelTime";
            this.txtTravelTime.ReadOnly = true;
            this.txtTravelTime.Size = new System.Drawing.Size(165, 29);
            this.txtTravelTime.TabIndex = 9;
            // 
            // txtTravelRate
            // 
            this.txtTravelRate.Location = new System.Drawing.Point(355, 299);
            this.txtTravelRate.Name = "txtTravelRate";
            this.txtTravelRate.ReadOnly = true;
            this.txtTravelRate.Size = new System.Drawing.Size(165, 29);
            this.txtTravelRate.TabIndex = 9;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(110, 71);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 29);
            this.txtDistance.TabIndex = 10;
            this.txtDistance.Text = "0";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(110, 124);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 29);
            this.txtSpeed.TabIndex = 10;
            this.txtSpeed.Text = "0";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(110, 172);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 29);
            this.txtTime.TabIndex = 10;
            this.txtTime.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "(In Minutes)";
            // 
            // txtTravelDistance
            // 
            this.txtTravelDistance.Location = new System.Drawing.Point(594, 299);
            this.txtTravelDistance.Name = "txtTravelDistance";
            this.txtTravelDistance.ReadOnly = true;
            this.txtTravelDistance.Size = new System.Drawing.Size(165, 29);
            this.txtTravelDistance.TabIndex = 9;
            this.txtTravelDistance.Click += new System.EventHandler(this.btnTravelDistance_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConvertDistance_Click);
            // 
            // txtConvertedDistance
            // 
            this.txtConvertedDistance.Location = new System.Drawing.Point(413, 70);
            this.txtConvertedDistance.Name = "txtConvertedDistance";
            this.txtConvertedDistance.ReadOnly = true;
            this.txtConvertedDistance.Size = new System.Drawing.Size(100, 29);
            this.txtConvertedDistance.TabIndex = 10;
            this.txtConvertedDistance.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConvertedDistance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTravelDistance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtTravelRate);
            this.Controls.Add(this.txtTravelTime);
            this.Controls.Add(this.txtTravelTimeString);
            this.Controls.Add(this.btnTravelDistance);
            this.Controls.Add(this.btnTravelRate);
            this.Controls.Add(this.btnTravelTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboSpeedType);
            this.Controls.Add(this.comboDistanceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalcForm";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDistanceType;
        private System.Windows.Forms.ComboBox comboSpeedType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTravelTime;
        private System.Windows.Forms.Button btnTravelRate;
        private System.Windows.Forms.Button btnTravelDistance;
        private System.Windows.Forms.TextBox txtTravelTimeString;
        private System.Windows.Forms.TextBox txtTravelTime;
        private System.Windows.Forms.TextBox txtTravelRate;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTravelDistance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConvertedDistance;
        private System.Windows.Forms.Label label3;
    }
}

