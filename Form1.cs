namespace NetPay_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtHourlyRate.Text.Trim(), out double hourlyRate) &&
                  double.TryParse(txtHoursWorked.Text.Trim(), out double workedHours))
            {
                // Calculate deductions and net pay
                double grossPay = CalculateGrossPayTotal(hourlyRate, workedHours);
                double pensionDeduction = CalculatePensionDeduction(grossPay);
                double medicalAid = CalculateMedicalAid(grossPay);
                double uifDeduction = CalculateUIFDeduction(grossPay);
                double totalDeductions = pensionDeduction + uifDeduction + medicalAid;
                double netPay = grossPay - totalDeductions;

                // Display results with formatting
                lblGrossPay.Text = $"{grossPay:F2}";
                lblNetPay.Text = $"{netPay:F2}";
                lblTotalDeductions.Text = $"{totalDeductions:F2}";
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Hourly Rate and Hours Worked.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateUIFDeduction(double grossPay)
        {
            return grossPay * 0.04;
        }

        private double CalculateMedicalAid(double grossPay)
        {
            return grossPay * 0.06;
        }

        private double CalculatePensionDeduction(double grossPay)
        {
            return grossPay * 0.05;
        }

        private double CalculateGrossPayTotal(double hourlyRate, double workedHours)
        {
            return hourlyRate * workedHours;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear input textboxes
            txtHourlyRate.Text = string.Empty;
            txtHoursWorked.Text = string.Empty;

            // Clear result labels
            lblGrossPay.Text = string.Empty;
            lblNetPay.Text = string.Empty;
            lblTotalDeductions.Text = string.Empty;

        }
        }
}

   