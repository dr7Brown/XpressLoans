using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpressLoan.Classes;

namespace XpressLoan.Forms
{
    public partial class FormRestructureLoan : MetroFramework.Forms.MetroForm
    {
        FormMessage formMessage;
        //Form Fields
        int mCustomerID = 0;
        string mCustomerName = "";
        int mLoanID = 0;
        int mRepaymentID = 0;

        int mAmount = 0;
        string mPurpose = "";
        string mTerms = "";
        double mRate;
        string mAppDate = "";
        string mTransInfo = "";
        string mCashoutDate = "";
        int mDuration;
        string mFirstRepaymentDate = "";
        string mGuarantor = "";
        string mStatus = "";
        double mProcessing = 0.0;
        double mTakeHome = 0.0;

        double myInterestPlusPrincipal = 0;
        double myInterest = 0;
        //double interestMinusPrincipal = 0;
        double myRepayments = 0.0;
        int myNumOfTimesRepay = 0;
        int prevLoanID = 0;

        //DB fields
        SqlDataAdapter da = new SqlDataAdapter();
        public FormRestructureLoan(int customerID, string customerName, int prevLoanId)
        {
            InitializeComponent();
            mCustomerID = customerID;
            mCustomerName = customerName;
            prevLoanID = prevLoanId;
            setPrevDetails();

            /*constr = ConnString.ConnectionString;
            conn = new SqlConnection(constr);*/
            //from form load 
            generateLoanID();
            generateRepaymentID();
            NameTextBox.Text = customerName;
            loanIDTextBox.Text = mLoanID + "";
            guarantorTextBox.Text = "Administrator";
            cbxProcessing.SelectedItem = cbxProcessing.Items[0];
            txtProcessing.Text = "0.00";

            

        }
        void setPrevDetails()
        {
            LoanDetails mLD = new LoanDetails(prevLoanID);
            lbLoanID.Text = mLD.loanID + "";
            lbAmount.Text = mLD.amount + "";
            lbDuration.Text = mLD.duration + "";
            lbInterest.Text = mLD.interest + "";
            lbPaid.Text = mLD.getTotalRepaymentsMadeForThisLoan(prevLoanID) + "";
            lbPBalance.Text = mLD.principalLeft() + "";
            lbTerms.Text = mLD.terms + "";
            lbRate.Text = mLD.rate + "";
            lbTBalance.Text = mLD.balance() + "";
            lbProcessing.Text = mLD.processingFees + "";
        }
        bool validateFields()
        {
            if (amountTextBox.Text.Length > 0
                   && purposeTextBox.Text.Length > 0
                   && termsComboBox.Text.Length > 0
                   && rateTextBox.Text.Length > 0
                   && durationTextBox.Text.Length > 0
                   && guarantorTextBox.Text.Length > 0
                   && txtStatus.Text.Length > 0
                   )

            {

                return true;
            }
            else
            { return false; }
        }
        private void applyLoan()
        {


            if (validateFields())
            {

                //set at runtime  //inside constructor
                //mCustomerID = 0;
                //mCustomerName = "";
                //mLoanID = 0;  
                mAmount = Convert.ToInt32(amountTextBox.Text);
                mPurpose = purposeTextBox.Text;
                mTerms = termsComboBox.SelectedItem.ToString();
                mRate = Convert.ToDouble(rateTextBox.Text);
                mAppDate = applicationDateDateTimePicker.Text;
                mCashoutDate = cashoutDateDateTimePicker.Text;
                mDuration = Convert.ToInt32(durationTextBox.Text);
                mFirstRepaymentDate = firstRepDateDateTimePicker.Text;
                mGuarantor = guarantorTextBox.Text;
                mStatus = txtStatus.Text;
                if (txtProcessing.Text.Length == 0)
                {
                    mProcessing = 0;
                }
                else
                {
                    mProcessing = Convert.ToDouble(txtProcessing.Text);
                }


                int years = 0;
                //Interest is billed yearly
                if (mDuration <= 12)
                {
                    years = 1;
                }
                else if (mDuration <= 24)
                {
                    years = 2;
                }
                else if (mDuration <= 36)
                {
                    years = 3;
                }
                else if (mDuration <= 48)
                {
                    years = 4;
                }
                else if (mDuration <= 60)
                {
                    years = 5;
                }
                else if (mDuration <= 72)
                {
                    years = 6;
                }
                else { years = 0; }//Limited to 6 years.

                myInterest = (mAmount * mDuration * mRate) / 100;
                myInterestPlusPrincipal = myInterest + mAmount;


                List<string> repaymentDates = new List<string>();

                switch (mTerms)
                {
                    case "WEEKLY":
                        //Number of weeks in months entered
                        myNumOfTimesRepay = mDuration * 4;
                        //Amount to pay weekly.
                        myRepayments = myInterestPlusPrincipal / myNumOfTimesRepay;
                        //Clean list
                        repaymentDates.Clear();
                        //Console.WriteLine(" number of weeks: " + myNumOfTimesRepay);
                        //Get the repayment dates
                        for (int i = 0; i < myNumOfTimesRepay; i++)
                        {
                            var nextrepdate = nextRepaymentDate(mFirstRepaymentDate, 7 * i, 0);
                            repaymentDates.Add(nextrepdate);
                            Console.WriteLine(repaymentDates[i]);
                        }
                        insertRecordIntoDB(repaymentDates);
                        break;
                    case "BI-WEEKLY":
                        //Number of weeks in months entered
                        myNumOfTimesRepay = mDuration * 2;
                        //Amount to pay Bi Weekly.
                        myRepayments = myInterestPlusPrincipal / myNumOfTimesRepay;
                        //Clean existing list
                        repaymentDates.Clear();
                        //Console.WriteLine(" number of Bi-weeks: " + myNumOfTimesRepay);
                        //Get the repayment dates
                        for (int i = 0; i < myNumOfTimesRepay; i++)
                        {
                            var nextrepdate =
                                nextRepaymentDate(mFirstRepaymentDate, 14 * i, 0);
                            repaymentDates.Add(nextrepdate);
                            //Console.WriteLine(repaymentDates[i]);
                        }
                        insertRecordIntoDB(repaymentDates);
                        break;
                    case "MONTHLY":
                        //Number of weeks in months entered
                        myNumOfTimesRepay = mDuration * 1;
                        //Amount to pay Bi monthly.
                        myRepayments = myInterestPlusPrincipal / myNumOfTimesRepay;
                        //Clean existing list
                        repaymentDates.Clear();
                        //Console.WriteLine(" number of Months: " + myNumOfTimesRepay);
                        //Get the repayment dates

                        for (int i = 0; i < mDuration; i++)
                        {
                            var nextrepdate = nextRepaymentDate(mFirstRepaymentDate, 0, i);
                            repaymentDates.Add(nextrepdate);
                            //Console.WriteLine(repaymentDates[i]);
                        }
                        insertRecordIntoDB(repaymentDates);
                        break;
                }
            }
            else
            {
                Console.Write("All fields are required: 2");
            }
        }
        void insertRecordIntoDB(List<string> repaymentDates)
        {
            if (validateFields())
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        string query = "INSERT INTO tblLoans VALUES(@LoanID, @CustomerID, @Amount, @Purpose, @Terms, @Rate, @ApplicationDate, @CashoutDate, @Duration, @FirstRepDate, @Guarantor, @Status, @Processing, @Interest)";
                        da.InsertCommand = new SqlCommand(query, conn, transaction);
                        da.InsertCommand.Parameters.AddWithValue("@LoanID", mLoanID);
                        da.InsertCommand.Parameters.AddWithValue("@CustomerID", mCustomerID);
                        da.InsertCommand.Parameters.AddWithValue("@Amount", mAmount);
                        da.InsertCommand.Parameters.AddWithValue("@Purpose", mPurpose);
                        da.InsertCommand.Parameters.AddWithValue("@Terms", mTerms);
                        da.InsertCommand.Parameters.AddWithValue("@Rate", mRate);
                        da.InsertCommand.Parameters.AddWithValue("@ApplicationDate", mAppDate);
                        da.InsertCommand.Parameters.AddWithValue("@CashoutDate", mCashoutDate);
                        da.InsertCommand.Parameters.AddWithValue("@Duration", mDuration);
                        da.InsertCommand.Parameters.AddWithValue("@FirstRepDate", mFirstRepaymentDate);
                        da.InsertCommand.Parameters.AddWithValue("@Guarantor", mGuarantor);
                        da.InsertCommand.Parameters.AddWithValue("@Status", mStatus);
                        da.InsertCommand.Parameters.AddWithValue("@Processing", mProcessing);
                        da.InsertCommand.Parameters.AddWithValue("@Interest", myInterest);
                        da.InsertCommand.ExecuteNonQuery();

                        //reschedule table
                        string query1 = "INSERT INTO tblRestructuredLoans VALUES(@CustomerID, @PrevLoanID, @NewLoanID, @Date)";
                        da.InsertCommand = new SqlCommand(query1, conn, transaction);
                        da.InsertCommand.Parameters.AddWithValue("@CustomerID", mCustomerID);
                        da.InsertCommand.Parameters.AddWithValue("@PrevLoanID", prevLoanID);
                        da.InsertCommand.Parameters.AddWithValue("@NewLoanID", mLoanID);
                        da.InsertCommand.Parameters.AddWithValue("@Date", mAppDate);
                        da.InsertCommand.ExecuteNonQuery();

                        /* mTransInfo = "Loan"+mLoanID;
                         string query2 = "INSERT INTO tblTransactions VALUES(@AppDate,@Info, @Credit, @Debit, @LoanID, @Balance)";
                         da.InsertCommand = new SqlCommand(query2, conn, transaction);
                         da.InsertCommand.Parameters.AddWithValue("@AppDate", mAppDate);
                         da.InsertCommand.Parameters.AddWithValue("@Info", mTransInfo);
                         da.InsertCommand.Parameters.AddWithValue("@Credit", 0);
                         da.InsertCommand.Parameters.AddWithValue("@Debit", mAmount);
                         da.InsertCommand.Parameters.AddWithValue("@LoanID", mLoanID);
                         da.InsertCommand.Parameters.AddWithValue("@Balance", (mAmount * -1));
                         da.InsertCommand.ExecuteNonQuery();

                         mTransInfo = "Loan" +mLoanID + " interest";
                         string query3 = "INSERT INTO tblTransactions VALUES(@AppDate,@Info, @Credit, @Debit, @LoanID, @Balance)";
                         da.InsertCommand = new SqlCommand(query3, conn, transaction);
                         da.InsertCommand.Parameters.AddWithValue("@AppDate", mAppDate);
                         da.InsertCommand.Parameters.AddWithValue("@Info", mTransInfo);
                         da.InsertCommand.Parameters.AddWithValue("@Credit", 0);
                         da.InsertCommand.Parameters.AddWithValue("@Debit", mAmount);
                         da.InsertCommand.Parameters.AddWithValue("@LoanID", mLoanID);
                         da.InsertCommand.Parameters.AddWithValue("@Balance", (mAmount * -1));
                         da.InsertCommand.ExecuteNonQuery();*/

                        transaction.Commit();

                        /* string query2 = "INSERT INTO tblRepayment VALUES(@RepaymentID, @LoanID, @RepaymentDate, @Amount, @Status, @PaidDate, @Comments)";         
                         // iterate over all RoleID's and execute the INSERT statement for each of them
                         foreach (string date in repaymentDates)
                         {

                             da.InsertCommand = new SqlCommand(query2, conn, transaction);
                             da.InsertCommand.Parameters.AddWithValue("@RepaymentID", mRepaymentID);
                             da.InsertCommand.Parameters.AddWithValue("@LoanID", mLoanID);
                             da.InsertCommand.Parameters.AddWithValue("@RepaymentDate", date);
                             da.InsertCommand.Parameters.AddWithValue("@Amount", myRepayments);
                             da.InsertCommand.Parameters.AddWithValue("@Status", "UNPAID");

                             da.InsertCommand.Parameters.AddWithValue("@PaidDate", "");
                             da.InsertCommand.Parameters.AddWithValue("@Comments", "");
                             da.InsertCommand.ExecuteNonQuery();
                             //next repayment ID
                             mRepaymentID += 1;
                         }

                         // Commit the transaction
                         transaction.Commit();*/
                        conn.Close();

                        formMessage = new FormMessage("Success");
                        formMessage.ShowDialog(this);

                        Thread.Sleep(300);
                    }
                    catch (Exception ex)
                    {
                        // Roll back the transaction if an error occurred
                        // transaction.Rollback();
                        formMessage = new FormMessage("Error occured! " + ex.Message);
                        formMessage.ShowDialog(this);
                        //Console.WriteLine("Error: " + ex.Message);
                    }

                }

            }
        }

        string nextRepaymentDate(string date_yyyy_MM_dd, int days, int months)
        {

            //convert from string
            DateTime pickedDate = Convert.ToDateTime(date_yyyy_MM_dd);
            pickedDate = pickedDate.AddDays(days);
            pickedDate = pickedDate.AddMonths(months);
            string formattedDate = pickedDate.ToString("yyyy'-'MM'-'dd");

            return formattedDate;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            applyLoan();
            //this.Dispose();
            this.Close();
        }
        public int generateRepaymentID()
        {

            
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    //Get RegionID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblRepayment WHERE RepaymentID=(SELECT max(RepaymentID) FROM tblRepayment);", conn);
                    SqlDataReader dr;

                    dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        mRepaymentID = 1000;
                    }
                    else
                    {
                        dr.Read();
                        mRepaymentID = Convert.ToInt32(dr["RepaymentID"]) + 1;
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating mRepaymentID " + exception.ToString());
                formMessage.ShowDialog(this);
            }
            return mRepaymentID;

        }


        public int generateLoanID()
        {        
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    //Get RegionID for the last Customer  SELECT TOP 1 * FROM table ORDER    BY Id DESC;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblLoans WHERE LoanID=(SELECT max(LoanID) FROM tblLoans);", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        mLoanID = 2100;
                    }
                    else
                    {
                        dr.Read();
                        mLoanID = Convert.ToInt32(dr["LoanID"]) + 1;
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating LoanID " + exception.ToString());
                formMessage.ShowDialog(this);
            }
            return mLoanID;

        }

        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (durationTextBox.Text.Length > 0)
            {
                if (Convert.ToInt32(durationTextBox.Text) > 72)
                {
                    txtNotice.Visible = true;
                    durationTextBox.Text = durationTextBox.Text.Substring(1);
                }
                else
                {
                    txtNotice.Visible = false;
                }
            }
        }

        private void termsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mTerms = termsComboBox.SelectedItem.ToString();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FormCalculator formCalculator = new FormCalculator();
            formCalculator.ShowDialog(this);
        }
        double calProcessingFees()
        {
            return Convert.ToInt32(amountTextBox.Text) * cbxProcessing.SelectedIndex / 100;
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (amountTextBox.Text.Length > 0)
                {
                    txtProcessing.Text = calProcessingFees() + "";
                    txtTakeHome.Text = (Convert.ToInt32(amountTextBox.Text) - calProcessingFees()) + "";
                    if (Convert.ToInt32(amountTextBox.Text) > 100000)
                    {
                        amountTextBox.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxProcessing_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (amountTextBox.Text.Length > 0)
                {
                    txtProcessing.Text = calProcessingFees() + "";
                    txtTakeHome.Text = (Convert.ToInt32(amountTextBox.Text) - calProcessingFees()) + "";
                    if (Convert.ToInt32(amountTextBox.Text) > 100000)
                    {
                        amountTextBox.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("First Enter loan Amount");
            }
        }

        private void txtProcessing_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProcessing.Text.Length > 0)
                {
                    //txtProcessing.Text = calProcessingFees() + "";
                    txtTakeHome.Text = ((Convert.ToInt32(amountTextBox.Text)) - (Convert.ToInt32(txtProcessing.Text))) + "";
                    if (Convert.ToInt32(amountTextBox.Text) > 100000)
                    {
                        amountTextBox.Text = "";
                    }

                }
            }
            catch (Exception ex)
            { }
        }
    }
}
