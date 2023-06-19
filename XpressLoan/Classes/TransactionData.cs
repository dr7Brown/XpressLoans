using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpressLoan.Forms;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace XpressLoan.Classes
{
    internal class TransactionData
    {
        SqlDataAdapter da = new SqlDataAdapter();
        FormMessage formMessage;
        public List<TransactionData> TransList = new List<TransactionData>();

        public int id { get; set; } = 0;

        public string date { get; set; } = "";
        public string info { get; set; } = "";

        public double credit { get; set; } = 0;

        public double debit { get; set; } = 0;
        public int loanId { get; set; } = 0;

        public double balance { get; set; } = 0;
        public double totalCredit { get; set; } = 0;
        public double totalDebit { get; set; } = 0;
        public double totalBalance { get; set; } = 0;
        public TransactionData(int loanId)
        {
            getTransactionData(loanId);
        }
        public TransactionData(int id, string date, string info, double credit, double debit, int loanId, double balance)
        {
            this.id = id;
            this.date = date;
            this.info = info;
            this.credit = credit;
            this.debit = debit;
            this.loanId = loanId;
            this.balance = balance;
        }
        public List<TransactionData> getTransactionData(int loanId)
        {
            SqlDataReader dr = null;
            try
            {
                //Connection string is assigned to the instance of sql connection.
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand SelectCommand = new SqlCommand("SELECT * FROM tblTransactions WHERE LoanID=@LoanID", conn);
                    SelectCommand.Parameters.AddWithValue("@LoanID", loanId);
                    dr = SelectCommand.ExecuteReader();
                    TransList.Clear(); //reset 
                    while (dr.Read())
                    {                   
                        id = Convert.ToInt32(dr["ID"]); ;
                        date = dr["Date"].ToString();
                        info = dr["Info"].ToString();
                        credit = Convert.ToDouble(dr["Credit"]);
                        debit = Convert.ToDouble(dr["Debit"]);
                        loanId = Convert.ToInt32(dr["LoanID"]);
                        balance = Convert.ToDouble(dr["Balance"]);
                        totalCredit += credit;
                        totalDebit += debit;
                        TransList.Add(new TransactionData(id, date, info, credit, debit, loanId, balance));
                    }
                    totalBalance = balance;
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading data into array" + exception.ToString()); }
            return TransList;
        }
        
    }
}
