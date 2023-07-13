using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpressLoan.Forms;
using System.Windows.Forms;

namespace XpressLoan.Classes
{
    internal class LoanDetails
    {
        SqlDataAdapter da = new SqlDataAdapter();
        FormMessage formMessage;
        public int loanID { get; set; } =0;

        public int customerID { get; set; } = 0;
        public double amount { get; set; } = 0;

        public string purpose { get; set; } = "";

        public string terms { get; set; } = "";
        public double rate { get; set; } = 0;

        public string applicationDate { get; set; } = "";
        public string cashoutDate { get; set; } = "";
        public int duration { get; set; } = 0;

        public string firstRepaymentDate { get; set; } = "";
        public string guarantor { get; set; } = "";

        public string status { get; set; } = "";
        public double processingFees { get; set; } = 0 ;

        public double interest { get; set; } = 0;
        public LoanDetails(int loanid) 
        {
            processLoanDetails(loanid);
        }
        public void processLoanDetails(int mloanID)
        {
            int repID = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                //Get RegionID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;
                da.SelectCommand = new SqlCommand("SELECT * FROM tblLoans WHERE LoanID=@LoanID", conn);
                da.SelectCommand.Parameters.AddWithValue("@LoanID", mloanID);
                SqlDataReader dr;
                try
                {
                    dr = da.SelectCommand.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        formMessage = new FormMessage("No items found");
                        formMessage.ShowDialog();
                    }
                    else
                    {
                        dr.Read();
                        loanID = mloanID;
                        customerID = Convert.ToInt32(dr["CustomerId"]);
                        amount = Convert.ToDouble(dr["Amount"]);
                        purpose = dr["Purpose"].ToString();
                        terms = dr["Terms"].ToString();
                        rate = Convert.ToDouble(dr["Rate"]);
                        applicationDate = dr["ApplicationDate"].ToString();
                        cashoutDate = dr["CashoutDate"].ToString();
                        duration = Convert.ToInt32(dr["Duration"]);
                        firstRepaymentDate = dr["FirstRepDate"].ToString();
                        guarantor = dr["Guarantor"].ToString();
                        status = dr["Status"].ToString();
                        processingFees = Convert.ToDouble(dr["Processing"]);
                        interest = Convert.ToDouble(dr["Interest"]);


                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception exception)
                {
                    formMessage = new FormMessage("Error generating mRepaymentID " + exception.ToString());
                    formMessage.ShowDialog();
                }
            }
        }
        public double getTotalRepaymentsMadeForThisLoan(int loanID)
        {//paid amount
            double paidAmount = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string query = "SELECT * FROM tblRepayment WHERE LoanID=@LoanID";
                da.SelectCommand = new SqlCommand(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@LoanID", loanID);
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
        public double principalPaid()
        {
            double pPaid = 0;
            pPaid = (100 - rate) * getTotalRepaymentsMadeForThisLoan(loanID);
            return pPaid;
        }
        public double principalLeft()
        {
            double pBalance = 0;
            pBalance = amount - principalPaid();
            return pBalance;
        }
        public double balance()
        {
            double bal = 0;
            bal = (amount + interest) - getTotalRepaymentsMadeForThisLoan(loanID);
            return bal;
        }

    }
}
