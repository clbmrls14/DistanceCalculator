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
            this.tabDistanceCalculator = new System.Windows.Forms.TabControl();
            this.tabCalculator = new System.Windows.Forms.TabPage();
            this.btnCalculateAll = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.NumericUpDown();
            this.txtSpeed = new System.Windows.Forms.NumericUpDown();
            this.txtDistance = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboDistanceType = new System.Windows.Forms.ComboBox();
            this.comboSpeedType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTravelTimeString = new System.Windows.Forms.TextBox();
            this.txtTravelTime = new System.Windows.Forms.TextBox();
            this.txtTravelRate = new System.Windows.Forms.TextBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.txtTravelDistance = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtConversionResult = new System.Windows.Forms.TextBox();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.calculationHistory = new System.Windows.Forms.DataGridView();
            this.colTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelTimeString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDistanceCalculator.SuspendLayout();
            this.tabCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistance)).BeginInit();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDistanceCalculator
            // 
            this.tabDistanceCalculator.Controls.Add(this.tabCalculator);
            this.tabDistanceCalculator.Controls.Add(this.tabHistory);
            this.tabDistanceCalculator.Location = new System.Drawing.Point(12, 12);
            this.tabDistanceCalculator.Name = "tabDistanceCalculator";
            this.tabDistanceCalculator.SelectedIndex = 0;
            this.tabDistanceCalculator.Size = new System.Drawing.Size(1005, 606);
            this.tabDistanceCalculator.TabIndex = 8;
            this.tabDistanceCalculator.SelectedIndexChanged += new System.EventHandler(this.tabDistanceCalculator_SelectedIndexChanged);
            // 
            // tabCalculator
            // 
            this.tabCalculator.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCalculator.Controls.Add(this.btnCalculateAll);
            this.tabCalculator.Controls.Add(this.txtTime);
            this.tabCalculator.Controls.Add(this.txtSpeed);
            this.tabCalculator.Controls.Add(this.txtDistance);
            this.tabCalculator.Controls.Add(this.label10);
            this.tabCalculator.Controls.Add(this.label9);
            this.tabCalculator.Controls.Add(this.comboDistanceType);
            this.tabCalculator.Controls.Add(this.comboSpeedType);
            this.tabCalculator.Controls.Add(this.label8);
            this.tabCalculator.Controls.Add(this.label7);
            this.tabCalculator.Controls.Add(this.label6);
            this.tabCalculator.Controls.Add(this.label5);
            this.tabCalculator.Controls.Add(this.label4);
            this.tabCalculator.Controls.Add(this.label3);
            this.tabCalculator.Controls.Add(this.txtTravelTimeString);
            this.tabCalculator.Controls.Add(this.txtTravelTime);
            this.tabCalculator.Controls.Add(this.txtTravelRate);
            this.tabCalculator.Controls.Add(this.labelMinutes);
            this.tabCalculator.Controls.Add(this.txtTravelDistance);
            this.tabCalculator.Controls.Add(this.btnConvert);
            this.tabCalculator.Controls.Add(this.txtConversionResult);
            this.tabCalculator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCalculator.Location = new System.Drawing.Point(4, 30);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(997, 572);
            this.tabCalculator.TabIndex = 0;
            this.tabCalculator.Text = "Calculator";
            // 
            // btnCalculateAll
            // 
            this.btnCalculateAll.BackColor = System.Drawing.Color.Tomato;
            this.btnCalculateAll.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateAll.Location = new System.Drawing.Point(117, 457);
            this.btnCalculateAll.Name = "btnCalculateAll";
            this.btnCalculateAll.Size = new System.Drawing.Size(228, 62);
            this.btnCalculateAll.TabIndex = 7;
            this.btnCalculateAll.Text = "Calculate All";
            this.btnCalculateAll.UseVisualStyleBackColor = false;
            this.btnCalculateAll.Click += new System.EventHandler(this.btnCalculateAll_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(195, 212);
            this.txtTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(93, 29);
            this.txtTime.TabIndex = 6;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(195, 162);
            this.txtSpeed.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(93, 29);
            this.txtSpeed.TabIndex = 4;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(195, 111);
            this.txtDistance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(93, 29);
            this.txtDistance.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(196, 306);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Travel Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 21);
            this.label9.TabIndex = 1;
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboDistanceType
            // 
            this.comboDistanceType.AllowDrop = true;
            this.comboDistanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDistanceType.Items.AddRange(new object[] {
            "Miles",
            "Kilometers"});
            this.comboDistanceType.Location = new System.Drawing.Point(296, 110);
            this.comboDistanceType.Margin = new System.Windows.Forms.Padding(4);
            this.comboDistanceType.Name = "comboDistanceType";
            this.comboDistanceType.Size = new System.Drawing.Size(108, 29);
            this.comboDistanceType.TabIndex = 2;
            // 
            // comboSpeedType
            // 
            this.comboSpeedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpeedType.FormattingEnabled = true;
            this.comboSpeedType.Items.AddRange(new object[] {
            "MPH",
            "KPH"});
            this.comboSpeedType.Location = new System.Drawing.Point(296, 161);
            this.comboSpeedType.Margin = new System.Windows.Forms.Padding(4);
            this.comboSpeedType.Name = "comboSpeedType";
            this.comboSpeedType.Size = new System.Drawing.Size(108, 29);
            this.comboSpeedType.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Distance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(434, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rate of Travel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(673, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Distance Traveled:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 0;
            // 
            // txtTravelTimeString
            // 
            this.txtTravelTimeString.Location = new System.Drawing.Point(196, 383);
            this.txtTravelTimeString.Name = "txtTravelTimeString";
            this.txtTravelTimeString.ReadOnly = true;
            this.txtTravelTimeString.Size = new System.Drawing.Size(165, 29);
            this.txtTravelTimeString.TabIndex = 9;
            this.txtTravelTimeString.TabStop = false;
            // 
            // txtTravelTime
            // 
            this.txtTravelTime.Location = new System.Drawing.Point(196, 338);
            this.txtTravelTime.Name = "txtTravelTime";
            this.txtTravelTime.ReadOnly = true;
            this.txtTravelTime.Size = new System.Drawing.Size(165, 29);
            this.txtTravelTime.TabIndex = 9;
            this.txtTravelTime.TabStop = false;
            // 
            // txtTravelRate
            // 
            this.txtTravelRate.Location = new System.Drawing.Point(434, 338);
            this.txtTravelRate.Name = "txtTravelRate";
            this.txtTravelRate.ReadOnly = true;
            this.txtTravelRate.Size = new System.Drawing.Size(181, 29);
            this.txtTravelRate.TabIndex = 9;
            this.txtTravelRate.TabStop = false;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(296, 214);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(93, 21);
            this.labelMinutes.TabIndex = 11;
            this.labelMinutes.Text = "(In Minutes)";
            // 
            // txtTravelDistance
            // 
            this.txtTravelDistance.Location = new System.Drawing.Point(673, 338);
            this.txtTravelDistance.Name = "txtTravelDistance";
            this.txtTravelDistance.ReadOnly = true;
            this.txtTravelDistance.Size = new System.Drawing.Size(207, 29);
            this.txtTravelDistance.TabIndex = 9;
            this.txtTravelDistance.Click += new System.EventHandler(this.btnTravelDistance_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(411, 105);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 36);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvertDistance_Click);
            // 
            // txtConversionResult
            // 
            this.txtConversionResult.Location = new System.Drawing.Point(492, 109);
            this.txtConversionResult.Name = "txtConversionResult";
            this.txtConversionResult.ReadOnly = true;
            this.txtConversionResult.Size = new System.Drawing.Size(144, 29);
            this.txtConversionResult.TabIndex = 10;
            this.txtConversionResult.TabStop = false;
            this.txtConversionResult.Text = "0";
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.Gainsboro;
            this.tabHistory.Controls.Add(this.calculationHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 30);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(997, 572);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "History";
            // 
            // calculationHistory
            // 
            this.calculationHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculationHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimeStamp,
            this.colDistance,
            this.colSpeed,
            this.colTime,
            this.colTravelTime,
            this.colTravelTimeString,
            this.colTravelRate,
            this.colTravelDistance,
            this.colConversion});
            this.calculationHistory.Location = new System.Drawing.Point(3, 3);
            this.calculationHistory.Name = "calculationHistory";
            this.calculationHistory.Size = new System.Drawing.Size(991, 566);
            this.calculationHistory.TabIndex = 0;
            this.calculationHistory.Text = "dataGridView1";
            this.calculationHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calculationHistory_CellContentClick);
            // 
            // colTimeStamp
            // 
            this.colTimeStamp.HeaderText = "TimeStamp";
            this.colTimeStamp.Name = "colTimeStamp";
            this.colTimeStamp.ReadOnly = true;
            this.colTimeStamp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDistance
            // 
            this.colDistance.HeaderText = "Distance";
            this.colDistance.Name = "colDistance";
            this.colDistance.ReadOnly = true;
            this.colDistance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSpeed
            // 
            this.colSpeed.HeaderText = "Speed";
            this.colSpeed.Name = "colSpeed";
            this.colSpeed.ReadOnly = true;
            this.colSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTravelTime
            // 
            this.colTravelTime.HeaderText = "Travel Time (Minutes)";
            this.colTravelTime.Name = "colTravelTime";
            this.colTravelTime.ReadOnly = true;
            this.colTravelTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTravelTimeString
            // 
            this.colTravelTimeString.HeaderText = "Travel Time (Text)";
            this.colTravelTimeString.Name = "colTravelTimeString";
            this.colTravelTimeString.ReadOnly = true;
            this.colTravelTimeString.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTravelRate
            // 
            this.colTravelRate.HeaderText = "Travel Rate";
            this.colTravelRate.Name = "colTravelRate";
            this.colTravelRate.ReadOnly = true;
            this.colTravelRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTravelDistance
            // 
            this.colTravelDistance.HeaderText = "Distance Traveled";
            this.colTravelDistance.Name = "colTravelDistance";
            this.colTravelDistance.ReadOnly = true;
            this.colTravelDistance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colConversion
            // 
            this.colConversion.HeaderText = "Converted Distance";
            this.colConversion.Name = "colConversion";
            this.colConversion.ReadOnly = true;
            this.colConversion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tabDistanceCalculator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalcForm";
            this.Text = "Distance Calculator";
            this.tabDistanceCalculator.ResumeLayout(false);
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistance)).EndInit();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculationHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDistanceCalculator;
        private System.Windows.Forms.TabPage tabCalculator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboDistanceType;
        private System.Windows.Forms.ComboBox comboSpeedType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTravelTimeString;
        private System.Windows.Forms.TextBox txtTravelTime;
        private System.Windows.Forms.TextBox txtTravelRate;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.TextBox txtTravelDistance;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtConversionResult;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.NumericUpDown txtTime;
        private System.Windows.Forms.NumericUpDown txtSpeed;
        private System.Windows.Forms.NumericUpDown txtDistance;
        private System.Windows.Forms.Button btnCalculateAll;
        private System.Windows.Forms.DataGridView calculationHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelTimeString;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversion;
    }
}

