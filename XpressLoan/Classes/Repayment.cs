using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpressLoan.Classes
{
    internal class Repayment
    {
        SqlDataAdapter da = new SqlDataAdapter();
        Forms.FormMessage formMessage;

        public int RepaymentID { get; set; } = 0;
        public int loanID { get; set; } = 0;
        public string repaymentDate { get; set; } = "";
        public double amount { get; set; } = 0;
        public string status { get; set; } = "";
        public string paidDate { get; set; } = "";
        public string comment { get; set; } = "";
        public double paid { get; set; } = 0;
        public Repayment()
        {

        }
        public Repayment(int repaymentID)
        {
            this.RepaymentID = repaymentID;
            //assign field values
            assignValues();
        }
        private void assignValues()
        {          
            double paidAmount = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string query = "SELECT * FROM tblRepayment WHERE RepaymentID=@RepaymentID";
                da.SelectCommand = new SqlCommand(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@RepaymentID", RepaymentID);
                SqlDataReader dr;
                try
                {
                    dr = da.SelectCommand.ExecuteReader();

                    if (dr.Read())
                    {
                        loanID = Convert.ToInt32(dr["LoanID"]);
                        repaymentDate = Convert.ToString(dr["RepaymentDate"]);
                        amount = Convert.ToDouble(dr["Amount"]);
                        status = Convert.ToString(dr["Status"]);
                        paidDate = Convert.ToString(dr["PaidDate"]);
                        comment = Convert.ToString(dr["Comments"]);
                        paid = Convert.ToDouble(dr["Paid"]);
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception exception)
                {
                    
                }
            }
        }
    }

    class DepositAgainstRepayment : Repayment
    {
        public int ID { get; set; } = 0;
        public string date { get; set; } = "";
        public double amount { get; set; } = 0;
        public int repaymentID { get; set; } = 0;

    }
}
