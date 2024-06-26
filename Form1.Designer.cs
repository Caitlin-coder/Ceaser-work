namespace NetPay_Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtHoursWorked = new Label();
            textBox1 = new TextBox();
            txtHourlyRate = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCalculate = new Button();
            lblGrossPay = new Label();
            button2 = new Button();
            lblTotalDeductions = new Label();
            lblNetPay = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 36);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 0;
            label1.Text = "NetPay Calculator";
            label1.Click += label1_Click;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.AutoSize = true;
            txtHoursWorked.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHoursWorked.Location = new Point(54, 140);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(140, 25);
            txtHoursWorked.TabIndex = 1;
            txtHoursWorked.Text = "Hours Worked:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(250, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.AutoSize = true;
            txtHourlyRate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHourlyRate.Location = new Point(54, 219);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(119, 25);
            txtHourlyRate.TabIndex = 3;
            txtHourlyRate.Text = "Hourly Rate:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(250, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(727, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(573, 97);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 6;
            label5.Text = "Deductions:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(574, 154);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 7;
            label6.Text = "UIF 4%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(573, 193);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 8;
            label7.Text = "Medical Aid 6%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(574, 234);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 9;
            label8.Text = "Pension 5%";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(54, 296);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(129, 29);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrossPay.Location = new Point(54, 369);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(183, 25);
            lblGrossPay.TabIndex = 11;
            lblGrossPay.Text = "Your Gross Salary is:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(250, 296);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblTotalDeductions
            // 
            lblTotalDeductions.AutoSize = true;
            lblTotalDeductions.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDeductions.Location = new Point(54, 425);
            lblTotalDeductions.Name = "lblTotalDeductions";
            lblTotalDeductions.Size = new Size(235, 25);
            lblTotalDeductions.TabIndex = 13;
            lblTotalDeductions.Text = "Your Total Deductions are:";
            // 
            // lblNetPay
            // 
            lblNetPay.AutoSize = true;
            lblNetPay.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPay.Location = new Point(54, 483);
            lblNetPay.Name = "lblNetPay";
            lblNetPay.Size = new Size(167, 25);
            lblNetPay.TabIndex = 14;
            lblNetPay.Text = "Your Net Salary is:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 538);
            Controls.Add(lblNetPay);
            Controls.Add(lblTotalDeductions);
            Controls.Add(button2);
            Controls.Add(lblGrossPay);
            Controls.Add(btnCalculate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(txtHourlyRate);
            Controls.Add(textBox1);
            Controls.Add(txtHoursWorked);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtHoursWorked;
        private TextBox textBox1;
        private Label txtHourlyRate;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCalculate;
        private Label lblGrossPay;
        private Button button2;
        private Label lblTotalDeductions;
        private Label lblNetPay;
    }
}
