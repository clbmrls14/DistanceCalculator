using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTravelTime_Click(object sender, EventArgs e)
        {
            txtTravelTime.Text = Calculations.Calculator.SolveForTime(double.Parse(txtDistance.Text), int.Parse(txtSpeed.Text)).ToString();
            txtTravelTimeString.Text = Calculations.Calculator.TimeToString(double.Parse(txtTravelTime.Text)).ToString();
        }

        private void btnTravelRate_Click(object sender, EventArgs e)
        {
            if (comboSpeedType.Text == "MPH")
            {
                txtTravelRate.Text = Calculations.Calculator.SolveForSpeed(double.Parse(txtDistance.Text), double.Parse(txtTime.Text)).ToString() + " MPH";
            }
            else if (comboSpeedType.Text == "KPH")
            {
                txtTravelRate.Text = Calculations.Calculator.SolveForSpeed(double.Parse(txtDistance.Text), double.Parse(txtTime.Text)).ToString() + " KPH";
            }
        }

        private void btnTravelDistance_Click(object sender, EventArgs e)
        {
            txtTravelDistance.Text = Calculations.Calculator.SolveForDistance(double.Parse(txtSpeed.Text), double.Parse(txtTime.Text)).ToString();
        }

        private void btnConvertDistance_Click(object sender, EventArgs e)
        {
            if(comboDistanceType.Text == "Miles")
            {
                txtConversionResult.Text = Calculations.Calculator.MilesToKilometers(double.Parse(txtDistance.Text)).ToString() + " Kilometers";
            }
            else if (comboDistanceType.Text == "Kilometers")
            {
                txtConversionResult.Text = Calculations.Calculator.KilometersToMiles(double.Parse(txtDistance.Text)).ToString() + " Miles";
            }
        }

        private void btnCalculateAll_Click(object sender, EventArgs e)
        {
            // TRAVEL TIME
            txtTravelTime.Text = Calculations.Calculator.SolveForTime(double.Parse(txtDistance.Text), int.Parse(txtSpeed.Text)).ToString();
            txtTravelTimeString.Text = Calculations.Calculator.TimeToString(double.Parse(txtTravelTime.Text)).ToString();

            // TRAVEL RATE
            if (comboSpeedType.Text == "MPH")
            {
                txtTravelRate.Text = Calculations.Calculator.SolveForSpeed(double.Parse(txtDistance.Text), double.Parse(txtTime.Text)).ToString() + " MPH";
            }
            else if (comboSpeedType.Text == "KPH")
            {
                txtTravelRate.Text = Calculations.Calculator.SolveForSpeed(double.Parse(txtDistance.Text), double.Parse(txtTime.Text)).ToString() + " KPH";
            }

            // CONVERT DISTANCE
            if (comboDistanceType.Text == "Miles")
            {
                txtConversionResult.Text = Calculations.Calculator.MilesToKilometers(double.Parse(txtDistance.Text)).ToString() + " Kilometers";
            }
            else if (comboDistanceType.Text == "Kilometers")
            {
                txtConversionResult.Text = Calculations.Calculator.KilometersToMiles(double.Parse(txtDistance.Text)).ToString() + " Miles";
            }

            // TRAVEL DISTANCE
            txtTravelDistance.Text = Calculations.Calculator.SolveForDistance(double.Parse(txtSpeed.Text), double.Parse(txtTime.Text)).ToString() + " " + comboDistanceType.Text;

            calculationHistory.Rows.Add(DateTime.Now, (txtDistance.Text + " " + comboDistanceType.Text), (txtSpeed.Text + " " + comboSpeedType.Text), txtTime.Text, txtTravelTime.Text,
                txtTravelTimeString.Text, txtTravelRate.Text, txtTravelDistance.Text, txtConversionResult.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabDistanceCalculator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculationHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //calculationHistory.ColumnCount = 9;
            //calculationHistory.ColumnHeadersVisible = true;
            //calculationHistory.Columns[0].Name = "Time";
            //calculationHistory.Columns[1].Name = "Distance";
            //calculationHistory.Columns[2].Name = "Speed";
            //calculationHistory.Columns[3].Name = "Time";
            //calculationHistory.Columns[4].Name = "Travel Time (Minutes)";
            //calculationHistory.Columns[5].Name = "Travel Time (Text)";
            //calculationHistory.Columns[6].Name = "Travel Rate";
            //calculationHistory.Columns[7].Name = "Distance Traveled";
            //calculationHistory.Columns[8].Name = "Distance Converted";
        }
    }
}
