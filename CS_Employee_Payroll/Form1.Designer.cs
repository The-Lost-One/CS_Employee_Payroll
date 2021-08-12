namespace CS_Employee_Payroll
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.rtPaySlip = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPensionablePay = new System.Windows.Forms.TextBox();
            this.txtTaxablePay = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTaxPeriod = new System.Windows.Forms.ComboBox();
            this.txtNICode = new System.Windows.Forms.TextBox();
            this.txtNINumber = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNIPayment = new System.Windows.Forms.TextBox();
            this.txtStudentLoan = new System.Windows.Forms.TextBox();
            this.txtPension = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOverTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOtherPayment = new System.Windows.Forms.TextBox();
            this.txtOverTime = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cobGender = new System.Windows.Forms.ComboBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPaySlip = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.rtPaySlip);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 421);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(978, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 22);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1226, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(608, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Pay Date";
            // 
            // rtPaySlip
            // 
            this.rtPaySlip.Location = new System.Drawing.Point(978, 57);
            this.rtPaySlip.Name = "rtPaySlip";
            this.rtPaySlip.Size = new System.Drawing.Size(359, 362);
            this.rtPaySlip.TabIndex = 7;
            this.rtPaySlip.Text = "";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.txtDeductions);
            this.panel9.Controls.Add(this.txtGrossPay);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.label22);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.txtNetPay);
            this.panel9.Location = new System.Drawing.Point(611, 289);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(348, 124);
            this.panel9.TabIndex = 6;
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(195, 87);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(127, 22);
            this.txtDeductions.TabIndex = 3;
            this.txtDeductions.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(195, 51);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(127, 22);
            this.txtGrossPay.TabIndex = 3;
            this.txtGrossPay.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 17);
            this.label23.TabIndex = 1;
            this.label23.Text = "Deductions";
            this.label23.Click += new System.EventHandler(this.label15_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Gross Pay";
            this.label22.Click += new System.EventHandler(this.label15_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Net Pay";
            this.label21.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(195, 13);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(127, 22);
            this.txtNetPay.TabIndex = 3;
            this.txtNetPay.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.txtPensionablePay);
            this.panel8.Controls.Add(this.txtTaxablePay);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Location = new System.Drawing.Point(611, 197);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(348, 87);
            this.panel8.TabIndex = 6;
            // 
            // txtPensionablePay
            // 
            this.txtPensionablePay.Location = new System.Drawing.Point(195, 48);
            this.txtPensionablePay.Name = "txtPensionablePay";
            this.txtPensionablePay.Size = new System.Drawing.Size(127, 22);
            this.txtPensionablePay.TabIndex = 3;
            this.txtPensionablePay.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // txtTaxablePay
            // 
            this.txtTaxablePay.Location = new System.Drawing.Point(195, 13);
            this.txtTaxablePay.Name = "txtTaxablePay";
            this.txtTaxablePay.Size = new System.Drawing.Size(127, 22);
            this.txtTaxablePay.TabIndex = 3;
            this.txtTaxablePay.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Pensionable Pay";
            this.label20.Click += new System.EventHandler(this.label15_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Taxable Pay";
            this.label19.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.txtTaxPeriod);
            this.panel7.Controls.Add(this.txtNICode);
            this.panel7.Controls.Add(this.txtNINumber);
            this.panel7.Controls.Add(this.txtTaxCode);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(611, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(348, 134);
            this.panel7.TabIndex = 6;
            // 
            // txtTaxPeriod
            // 
            this.txtTaxPeriod.FormattingEnabled = true;
            this.txtTaxPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtTaxPeriod.Location = new System.Drawing.Point(195, 9);
            this.txtTaxPeriod.Name = "txtTaxPeriod";
            this.txtTaxPeriod.Size = new System.Drawing.Size(127, 24);
            this.txtTaxPeriod.TabIndex = 11;
            this.txtTaxPeriod.Text = "0";
            // 
            // txtNICode
            // 
            this.txtNICode.Location = new System.Drawing.Point(195, 96);
            this.txtNICode.Name = "txtNICode";
            this.txtNICode.Size = new System.Drawing.Size(127, 22);
            this.txtNICode.TabIndex = 3;
            this.txtNICode.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // txtNINumber
            // 
            this.txtNINumber.Location = new System.Drawing.Point(195, 68);
            this.txtNINumber.Name = "txtNINumber";
            this.txtNINumber.Size = new System.Drawing.Size(127, 22);
            this.txtNINumber.TabIndex = 3;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(195, 40);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(127, 22);
            this.txtTaxCode.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "EPF Number";
            this.label18.Click += new System.EventHandler(this.label15_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "PF Number";
            this.label17.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "PAN Number";
            this.label16.Click += new System.EventHandler(this.label15_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tax Period";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(759, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.txtNIPayment);
            this.panel6.Controls.Add(this.txtStudentLoan);
            this.panel6.Controls.Add(this.txtPension);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtTax);
            this.panel6.Location = new System.Drawing.Point(345, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 184);
            this.panel6.TabIndex = 3;
            // 
            // txtNIPayment
            // 
            this.txtNIPayment.Location = new System.Drawing.Point(95, 142);
            this.txtNIPayment.Name = "txtNIPayment";
            this.txtNIPayment.Size = new System.Drawing.Size(114, 22);
            this.txtNIPayment.TabIndex = 2;
            // 
            // txtStudentLoan
            // 
            this.txtStudentLoan.Location = new System.Drawing.Point(95, 98);
            this.txtStudentLoan.Name = "txtStudentLoan";
            this.txtStudentLoan.Size = new System.Drawing.Size(114, 22);
            this.txtStudentLoan.TabIndex = 2;
            // 
            // txtPension
            // 
            this.txtPension.Location = new System.Drawing.Point(95, 54);
            this.txtPension.Name = "txtPension";
            this.txtPension.Size = new System.Drawing.Size(114, 22);
            this.txtPension.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "EMI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tax";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(95, 13);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(114, 22);
            this.txtTax.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblOverTime);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtOtherPayment);
            this.panel5.Controls.Add(this.txtOverTime);
            this.panel5.Controls.Add(this.txtBasicSalary);
            this.panel5.Controls.Add(this.txtWeight);
            this.panel5.Location = new System.Drawing.Point(17, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 184);
            this.panel5.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Other Payment";
            // 
            // lblOverTime
            // 
            this.lblOverTime.AutoSize = true;
            this.lblOverTime.Location = new System.Drawing.Point(24, 101);
            this.lblOverTime.Name = "lblOverTime";
            this.lblOverTime.Size = new System.Drawing.Size(74, 17);
            this.lblOverTime.TabIndex = 3;
            this.lblOverTime.Text = "Over Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Basic Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pay Grade";
            // 
            // txtOtherPayment
            // 
            this.txtOtherPayment.Location = new System.Drawing.Point(176, 142);
            this.txtOtherPayment.Name = "txtOtherPayment";
            this.txtOtherPayment.Size = new System.Drawing.Size(127, 22);
            this.txtOtherPayment.TabIndex = 2;
            this.txtOtherPayment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOtherPayment_MouseClick);
            this.txtOtherPayment.MouseEnter += new System.EventHandler(this.txtOtherPayment_MouseEnter);
            this.txtOtherPayment.MouseLeave += new System.EventHandler(this.txtOtherPayment_MouseLeave);
            // 
            // txtOverTime
            // 
            this.txtOverTime.Location = new System.Drawing.Point(176, 98);
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.Size = new System.Drawing.Size(127, 22);
            this.txtOverTime.TabIndex = 2;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(176, 54);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(127, 22);
            this.txtBasicSalary.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(176, 13);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(127, 22);
            this.txtWeight.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cobGender);
            this.panel2.Controls.Add(this.txtMobile);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSurname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFirstname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtRef);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 204);
            this.panel2.TabIndex = 0;
            // 
            // cobGender
            // 
            this.cobGender.FormattingEnabled = true;
            this.cobGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cobGender.Location = new System.Drawing.Point(176, 172);
            this.cobGender.Name = "cobGender";
            this.cobGender.Size = new System.Drawing.Size(361, 24);
            this.cobGender.TabIndex = 2;
            this.cobGender.Text = "Male";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(176, 140);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(361, 22);
            this.txtMobile.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(176, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(361, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gender";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mobile";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(176, 75);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(361, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(176, 47);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(361, 22);
            this.txtFirstname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sur name";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(176, 17);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(361, 22);
            this.txtRef.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnPaySlip);
            this.panel3.Controls.Add(this.btnTotal);
            this.panel3.Location = new System.Drawing.Point(12, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1344, 62);
            this.panel3.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1184, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(866, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 52);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(504, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(136, 52);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1025, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 52);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(186, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 52);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(707, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 52);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPaySlip
            // 
            this.btnPaySlip.Location = new System.Drawing.Point(345, 3);
            this.btnPaySlip.Name = "btnPaySlip";
            this.btnPaySlip.Size = new System.Drawing.Size(136, 52);
            this.btnPaySlip.TabIndex = 0;
            this.btnPaySlip.Text = "Pay Slip";
            this.btnPaySlip.UseVisualStyleBackColor = true;
            this.btnPaySlip.Click += new System.EventHandler(this.btnPaySlip_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(27, 3);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(136, 52);
            this.btnTotal.TabIndex = 0;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(12, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1344, 179);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1334, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Payroll Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPaySlip;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtPaySlip;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNIPayment;
        private System.Windows.Forms.TextBox txtStudentLoan;
        private System.Windows.Forms.TextBox txtPension;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblOverTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOtherPayment;
        private System.Windows.Forms.TextBox txtOverTime;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNICode;
        private System.Windows.Forms.TextBox txtNINumber;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.TextBox txtPensionablePay;
        private System.Windows.Forms.TextBox txtTaxablePay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtTaxPeriod;
        private System.Windows.Forms.ComboBox cobGender;
        private System.Windows.Forms.Label label12;
    }
}

