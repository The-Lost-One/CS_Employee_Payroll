using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CS_Employee_Payroll
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
        DataTable sqlDt = new DataTable();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();
        String server = "localhost";
        String username = "root";
        String password = "root";
        String database = "employeedb";

        private void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from employeedb";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void Refreshdb()
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;
                sqlCmd.Connection = sqlConn;
                MySqlDataAdapter sqlDtA = new MySqlDataAdapter("select * from employeedb", sqlConn);
                DataTable sqlDt = new DataTable();
                sqlDtA.Fill(sqlDt);
                dataGridView1.DataSource = sqlDt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Form1()
        {
            InitializeComponent();
            uploadData();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                double GrossPay, Deductions, NetPay, Period;
                double InnerCity, BasicPay, OverTime, OtherPayment, Tax, Pension, StudentLoan, NIPayment;

                InnerCity = Double.Parse(txtWeight.Text);
                BasicPay = Double.Parse(txtBasicSalary.Text);
                OverTime = Double.Parse(txtOverTime.Text);
                OtherPayment = Double.Parse(txtOtherPayment.Text);
                GrossPay = InnerCity + BasicPay + OverTime + OtherPayment;
                txtGrossPay.Text = String.Format("{0:C2}", GrossPay);

                Tax = (GrossPay * 9) / 100;
                Pension = (GrossPay * 12) / 100;
                StudentLoan = (GrossPay * 5) / 100;
                NIPayment = (GrossPay * 3) / 100;
                txtTax.Text = String.Format("{0:C2}", Tax);
                txtPension.Text = String.Format("{0:C2}", Pension);
                txtStudentLoan.Text = String.Format("{0:C2}", StudentLoan);
                txtNIPayment.Text = String.Format("{0:C2}", NIPayment);

                Deductions = Tax + Pension + StudentLoan + NIPayment;
                txtDeductions.Text = String.Format("{0:C2}", Deductions);

                NetPay = GrossPay - Deductions;
                txtNetPay.Text = String.Format("{0:C2}", NetPay);

                Period = Double.Parse(txtTaxPeriod.Text);
                txtTaxablePay.Text = String.Format("{0:C2}", Period * NetPay);

                txtPensionablePay.Text = String.Format("{0:C2}", Period * Pension);

                //======================//

                try
                {
                    string date = Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd");

                    sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;
                    sqlConn.Open();
                    sqlCmd.Connection = sqlConn;
                    sqlCmd.CommandText = "insert into employeedb (ID, Firstname, Surname, Address, Gender, Mobile, Weight, Salary, OverTime, OtherPay, Tax, Pension, StudLoan, NIPay, PayDate, TaxPeriod, TaxCode, NINumber, NICode, Taxable, Pensionable, NetPay, GrossPay, Deductions)" +
                        "values('" + txtRef.Text + "','" + txtFirstname.Text + "','" +
                        txtSurname.Text + "','" + txtAddress.Text + "','" + cobGender.Text + "','" +
                        txtMobile.Text + "','" + txtWeight.Text + "','" + txtBasicSalary.Text + "','" +
                        txtOverTime.Text + "','" + txtOtherPayment.Text + "','" + txtTax.Text + "','" +
                        txtPension.Text + "','" + txtStudentLoan.Text + "','" + txtNIPayment.Text + "','" +
                        date + "','" + txtTaxPeriod.Text + "','" + txtTaxCode.Text + "','" +
                        txtNINumber.Text + "','" + txtNICode.Text + "','" + txtTaxablePay.Text + "','" +
                        txtPensionablePay.Text + "','" + txtNetPay.Text + "','" + txtGrossPay.Text + "','" + txtDeductions.Text + "')";
                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();
                    Refreshdb();
                }
                catch (Exception ex)
                {
                    sqlConn.Close();
                    MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                //=======================//


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOtherPayment_MouseClick(object sender, MouseEventArgs e)
        {
            txtOtherPayment.Text = "";
            txtOtherPayment.Focus();
        }

        private void txtOtherPayment_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtRef.Text = "";
                txtFirstname.Text = "";
                txtSurname.Text = "";
                txtBasicSalary.Text = "";
                txtOverTime.Text = "";
                txtWeight.Text = "";
                txtNICode.Text = "";
                txtNINumber.Text = "";
                //cobGender.Text = "";
                txtMobile.Text = "";
                txtOtherPayment.Text = "0.0";

                txtTaxCode.Text = "";
                txtTaxPeriod.Text = "0";
                txtAddress.Text = "";
                dateTimePicker1.ResetText();
                txtSearch.Text = "";
                rtPaySlip.Text = "";

                txtDeductions.Text = "";
                txtGrossPay.Text = "";
                txtNetPay.Text = "";
                txtNIPayment.Text = "";
                txtPension.Text = "";
                txtPensionablePay.Text = "";
                txtStudentLoan.Text = "";
                txtTax.Text = "";
                txtTaxablePay.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        { 
            try
            {
                System.Drawing.Font fntString = new System.Drawing.Font("Arial",18,FontStyle.Regular);
                e.Graphics.DrawString(rtPaySlip.Text, fntString, Brushes.Black, 120, 120);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refreshdb();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                String ID = txtRef.Text;
                sqlCmd.CommandText = "delete from employeedb where ID =" + ID + "";
                sqlRd = sqlCmd.ExecuteReader();
                MessageBox.Show("Record Deleted", "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConn.Close();
                Refreshdb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;
                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                String ID = txtRef.Text;
                String Firstname = txtFirstname.Text;
                String Surname = txtSurname.Text;
                String Address = txtAddress.Text;
                String Gender = cobGender.Text;
                String Mobile = txtMobile.Text;
                String Weight = txtWeight.Text;
                String Salary = txtBasicSalary.Text;
                String OverTime = txtOverTime.Text;
                String OtherPay = txtOtherPayment.Text;
                String Tax = txtTax.Text;
                String Pension = txtPension.Text;
                String StudLoan = txtStudentLoan.Text;
                String NIPay = txtNIPayment.Text;
                String PayDate = Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd");
                String TaxPeriod = txtTaxPeriod.Text;
                String TaxCode = txtTaxCode.Text;
                String NINumber = txtNINumber.Text;
                String NICode = txtNICode.Text;
                String Taxable = txtTaxablePay.Text;
                String Pensionable = txtPensionablePay.Text;
                String NetPay = txtNetPay.Text;
                String GrossPay = txtGrossPay.Text;
                String Deductions = txtDeductions.Text;

                sqlCmd.CommandText = "update employeedb set ID = '" + ID + "', Firstname = '" + Firstname + "', Surname = '" + Surname +
                    "', Address = '" + Address + "', Gender = '" + Gender + "', Mobile = '" + Mobile + "', Weight = '" + Weight + "', " +
                    "Salary = '" + Salary + "', OverTime = '" + OverTime + "', OtherPay = '" + OtherPay + "', Tax = '" + Tax + "', Pension = '" +
                    Pension + "', StudLoan = '" + StudLoan + "', NIPay = '" + NIPay + "', PayDate = '" + PayDate + "', TaxPeriod = '" +
                    TaxPeriod + "', TaxCode = '" + TaxCode + "', NINumber = '" + NINumber + "', NICode = '" + NICode + "', Taxable = '" +
                    Taxable + "', Pensionable = '" + Pensionable + "', NetPay = '" + NetPay + "', GrossPay = '" +
                    GrossPay + "', Deductions = '" + Deductions + "' where ID =" + ID + "";

                sqlRd = sqlCmd.ExecuteReader();
                MessageBox.Show("Record Updated", "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConn.Close();
                Refreshdb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (Char) 13)
                {
                    DataView dv = sqlDt.DefaultView;
                    dv.RowFilter = string.Format("Firstname like '%{0}%'", txtSearch.Text);
                    dataGridView1.DataSource = dv.ToTable();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("Firstname like '%{0}%'", txtSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtOtherPayment_MouseLeave(object sender, EventArgs e)
        {
            if (txtOtherPayment.Text == "")
            {
                txtOtherPayment.Text = "0.0";
            }
        }

        private void btnPaySlip_Click(object sender, EventArgs e)
        {
            rtPaySlip.Clear();
            rtPaySlip.AppendText("\t\t" + "Pay Slip" + "\t\t" + "\n");
            rtPaySlip.AppendText("\t\t" + "---------------" + "\t\t" + "\n");
            rtPaySlip.AppendText("EmployeeID" + "\t\t" + txtRef.Text + "\n");
            rtPaySlip.AppendText("Firstname" + "\t\t\t" + txtFirstname.Text + "\n");
            rtPaySlip.AppendText("Surname" + "\t\t\t" + txtSurname.Text + "\n");
            rtPaySlip.AppendText("Address" + "\t\t\t" + txtAddress.Text + "\n");
            rtPaySlip.AppendText("Gender" + "\t\t\t" + cobGender.Text + "\n");
            rtPaySlip.AppendText("Mobile" + "\t\t\t" + txtMobile.Text + "\n");
            rtPaySlip.AppendText("Weight" + "\t\t\t" + txtWeight.Text + "\n");
            rtPaySlip.AppendText("Salary" + "\t\t\t" + txtBasicSalary.Text + "\n");
            rtPaySlip.AppendText("Over Time" + "\t\t" + txtOverTime.Text + "\n");
            rtPaySlip.AppendText("Other Payment" + "\t\t" + txtOtherPayment.Text + "\n");
            rtPaySlip.AppendText("Tax" + "\t\t\t" + txtTax.Text + "\n");
            rtPaySlip.AppendText("Pension" + "\t\t\t" + txtPension.Text + "\n");

            rtPaySlip.AppendText("Student Loan" + "\t\t" + txtStudentLoan.Text + "\n");
            rtPaySlip.AppendText("NI Payment" + "\t\t" + txtNIPayment.Text + "\n");
            rtPaySlip.AppendText("PayDate" + "\t\t\t" + dateTimePicker1.Text + "\n");
            rtPaySlip.AppendText("TaxPeriod" + "\t\t" + txtTaxPeriod.Text + "\n");

            rtPaySlip.AppendText("TaxCode" + "\t\t\t" + txtTaxCode.Text + "\n");
            rtPaySlip.AppendText("NI Number" + "\t\t" + txtNINumber.Text + "\n");
            rtPaySlip.AppendText("NI Code" + "\t\t\t" + txtNICode.Text + "\n");
            rtPaySlip.AppendText("Taxable" + "\t\t\t" + txtTaxablePay.Text + "\n");
            rtPaySlip.AppendText("Pensionable" + "\t\t" + txtPensionablePay.Text + "\n");
            rtPaySlip.AppendText("NetPay" + "\t\t\t" + txtNetPay.Text + "\n");
            rtPaySlip.AppendText("GrossPay" + "\t\t\t" + txtGrossPay.Text + "\n");
            rtPaySlip.AppendText("Deductions" + "\t\t" + txtDeductions.Text + "\n");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRef.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cobGender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtMobile.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtWeight.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtBasicSalary.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtOverTime.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtOtherPayment.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                txtTax.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtPension.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                txtStudentLoan.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                txtNIPayment.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                txtTaxPeriod.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                txtTaxCode.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                txtNINumber.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
                txtNICode.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
                txtTaxablePay.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
                txtPensionablePay.Text = dataGridView1.SelectedRows[0].Cells[20].Value.ToString();
                txtNetPay.Text = dataGridView1.SelectedRows[0].Cells[21].Value.ToString();
                txtGrossPay.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
                txtDeductions.Text = dataGridView1.SelectedRows[0].Cells[23].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
