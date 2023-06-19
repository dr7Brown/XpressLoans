using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using XpressLoan.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace XpressLoan.Forms
{
    public partial class FormAddRepayment : MetroFramework.Forms.MetroForm
    {
        int mRepaymentID = 0;
        int mCustomerID = 0;
        string mName = "";
        int mLoanID = 0;
        double mDueAmount = 0;
        LoanDetails loanDetails;

        string mStatus = "";
        string mComments = "";
        string mPaidDate = "";
        double mDeposit = 0;
        double mRepBalance = 0;


        //DB fields
        SqlDataAdapter da = new SqlDataAdapter();
        String constr;
        SqlConnection conn;

   
             
        public FormAddRepayment(int repaymentID, int customerID, string name, int LoanID, double amount, string status)
        {
            InitializeComponent();
            mRepaymentID = repaymentID;
            mCustomerID = customerID;
            mName = name;
            mLoanID = LoanID;
            mDueAmount = amount;
            mStatus = status;
            //PayOrEdit();
            fillLogoFields();

            repaymentIDTextBox.Text = mRepaymentID+"";
            nameTextBox1.Text = mName ;
            loanIDTextBox.Text = mLoanID+"";
            mRepBalance = mDueAmount - getRepaymentsMadeForThisID();
            getRepaymentsMadeForThisID();
            txtBalance.Text = string.Format("{0:0.00}", mRepBalance);
            //txtAmount.Text = mRepBalance+"";

            constr = ConnString.ConnectionString;
            conn = new SqlConnection(constr);
        }
        public void fillLogoFields()
        {
            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //Get CustomerID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tblLogo WHERE ID=1", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    lblCoName.Text = Convert.ToString(dr["CoName"]);
                    lblContact1.Text = Convert.ToString(dr["Contact1"]);
                    lblContact2.Text = Convert.ToString(dr["Contact2"]);
                    lblEmail.Text = dr["Email"].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured" + exception.Message);
            }
        }
       
        public double getRepaymentsMadeForThisID()
        {
            double paidAmount = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "SELECT * FROM tblRepDeposits WHERE RepaymentID=@RepaymentID";
                da.SelectCommand = new SqlCommand(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@RepaymentID", mRepaymentID);

                SqlDataReader dr;
                try
                {
                    dr = da.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        paidAmount += Convert.ToDouble(dr["Amount"]);
                    }
                    Console.WriteLine(paidAmount + " Paid");
                    dr.Close();
                    conn.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            return paidAmount;
        }
        public double getLoanAmount()
        {
            double loan = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                //Get RegionID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;
                string query = "SELECT * FROM tblLoans WHERE LoanID=@LoanID";
                da.SelectCommand = new SqlCommand(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@LoanID", mLoanID);

                SqlDataReader dr;
                try
                {
                    dr = da.SelectCommand.ExecuteReader();
                    dr.Read();
                    loan = Convert.ToDouble(dr["Amount"]);
                    
                    dr.Close();
                    conn.Close();
                }
                catch (Exception exception)
                {
                }
            }
            return loan;
        }
        public double getTotalRepaymentsMadeForThisLoan()
        {
            double paidAmount = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string query = "SELECT * FROM tblRepayment WHERE LoanID=@LoanID";
                da.SelectCommand = new SqlCommand(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@LoanID", mLoanID);
                SqlDataReader dr;
                try
                {
                    dr = da.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        paidAmount += Convert.ToDouble(dr["Paid"]);
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception exception)
                {
                }
            }
            return paidAmount;
        }
       /* public void PayOrEdit()
        {
            if(mStatus == "PAID")
            {
                //do paid stuffs here.
                btnSubmit.BackColor = ThemeColor.ColorRed;
                btnSubmit.ForeColor = ThemeColor.ColorWhite;
                btnSubmit.Text = "UPDATE";
                rdPaid.Checked= true;
            }
            else
            {
                //do unpaid stuffs here.
                btnSubmit.BackColor = ThemeColor.ColorSeaBlue;
                btnSubmit.ForeColor = ThemeColor.ColorWhite;
                btnSubmit.Text = "SUBMIT";
                rdUnpaid.Checked= true;
            }
        }*/

        bool validateFields()
        {
            if(commentsTextBox.Text.Length>0)
               mComments = commentsTextBox.Text;

            mPaidDate = datePaidDatePicker.Text;
            if (txtAmount.Text.Length > 0)
            {
                mDeposit = Convert.ToDouble(txtAmount.Text);
                return true;
            }
            else {
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StoreRepayment();
            this.Close();
        }
       
        void submitRecord()
        {
            loanDetails = new LoanDetails(mLoanID);
            double paid = getTotalRepaymentsMadeForThisLoan() + mDeposit;
            //double balance = getLoanAmount() + paid;
            double balance = -(loanDetails.amount + loanDetails.interest) + paid;
            //double repBalance = 
            if (mRepBalance > mDeposit && mDeposit > 0)
            {
                mStatus = "PARTIAL";
            }
            else if (mRepBalance == mDeposit && mDeposit > 0)
            {
                mStatus = "PAID";
            }

            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {                   
                    
                    string query = "UPDATE tblRepayment SET Status=@Status, PaidDate=@PaidDate, Comments=@Comments, Paid=@Paid WHERE RepaymentID=@RepaymentID";
                    da.UpdateCommand = new SqlCommand(query, conn, transaction);
                    da.UpdateCommand.Parameters.AddWithValue("@RepaymentID", mRepaymentID);
                    da.UpdateCommand.Parameters.AddWithValue("@Status", mStatus);
                    da.UpdateCommand.Parameters.AddWithValue("@PaidDate", mPaidDate);
                    da.UpdateCommand.Parameters.AddWithValue("@Comments", mComments);
                    da.UpdateCommand.Parameters.AddWithValue("@Paid", getRepaymentsMadeForThisID() + mDeposit);
                    da.UpdateCommand.ExecuteNonQuery();                   

                    string query1 = "INSERT INTO tblRepDeposits VALUES(@PaidDate, @Amount, @RepaymentID)";
                    da.InsertCommand = new SqlCommand(query1, conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@PaidDate", mPaidDate);
                    da.InsertCommand.Parameters.AddWithValue("@Amount", mDeposit);
                    da.InsertCommand.Parameters.AddWithValue("@RepaymentID", mRepaymentID);
                    da.InsertCommand.ExecuteNonQuery();

                    string query2 = "INSERT INTO tblTransactions VALUES(@PaidDate,@Info, @Credit, @Debit, @LoanID, @Balance)";
                    da.InsertCommand = new SqlCommand(query2, conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@PaidDate", mPaidDate);
                    da.InsertCommand.Parameters.AddWithValue("@Info", mLoanID+"-REPAYMNT");
                    da.InsertCommand.Parameters.AddWithValue("@Credit", mDeposit);
                    da.InsertCommand.Parameters.AddWithValue("@Debit", 0);
                    da.InsertCommand.Parameters.AddWithValue("@LoanID", mLoanID);
                    da.InsertCommand.Parameters.AddWithValue("@Balance", balance);
                    da.InsertCommand.ExecuteNonQuery();


                    if(balance == 0)
                    {
                        string query5 = "UPDATE tblLoans SET Status=@status WHERE LoanID=@loanId";
                        da.UpdateCommand = new SqlCommand(query5, conn, transaction);
                        da.UpdateCommand.Parameters.AddWithValue("@status", "COMPLETED");
                        da.UpdateCommand.Parameters.AddWithValue("@loanId", mLoanID);
                        da.UpdateCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    conn.Close();
                }
                catch(Exception ex) { transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void repaymentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            mPaidDate = datePaidDatePicker.Text;
        }

        private void commentsTextBox_TextChanged(object sender, EventArgs e)
        {
            txtPurposeTextCount.Text = commentsTextBox.Text.Length.ToString() + "/20";
        }
        private void showProgressBar()
        {
            for (int i = 0; i < 1; i++) //increase i for the number of spins
            {
                for (int j = 0; j < 100; j++)
                {
                    Thread.Sleep(1);

                    progressBar1.Value = j;
                    progressBar1.Update();
                }

            }
        }
        private async Task StoreRepayment()
        {
            try
            {
                // Show the spinner
                progressBar1.Show();

                showProgressBar();
                if (validateFields())
                {
                    //insert Data
                    submitRecord();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                progressBar1.Hide();
                this.Dispose();
            }
        }

        private void txtAmount_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtAmount.Text);
                if (value > mRepBalance)
                {
                    //show error textbox
                    txtError.Visible = true;
                    //add error msg
                    txtError.Text = "Amount cannot be more than balance";
                    txtAmount.Text = txtAmount.Text.Substring(0,  txtAmount.TextLength -1);
                    //
                    double balance = mRepBalance;
                    double amountEntered = Convert.ToDouble(txtAmount.Text);
                    double currentBalance = balance - amountEntered;
                    txtBalance.Text = currentBalance.ToString();
                }
                else
                {
                    //hide error textbox
                    //
                    double balance = mRepBalance;
                    double amountEntered = Convert.ToDouble(txtAmount.Text);
                    double currentBalance = balance - amountEntered;
                    txtBalance.Text = currentBalance.ToString();
                }
            }
            catch(Exception ex) { }
           
        }
    }
}
