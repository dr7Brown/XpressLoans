using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpressLoan.Classes
{
    internal class RepaymentStatement
    {
        public string customerName { get; set; } = "";
        public int loanID { get; set; } = 0;
        public double loanAmount { get; set; } = 0;
        public string repaymentTerms { get; set; } = "";
        public string dateApplied { get; set; } = "";
        public int duration { get; set; } = 0;
        public SqlDataReader sqlDR { get; set; } = null;
        public RepaymentStatement(string customerName, int loanid, double loanAmount, string repaymentTerms, string dateApplied, int duration, SqlDataReader sqlDR ) {
            this.customerName= customerName;
            this.loanID=loanid;
            this.loanAmount=loanAmount; 
            this.duration= duration;
            this.repaymentTerms= repaymentTerms;
            this.dateApplied=dateApplied;
            this.sqlDR = sqlDR;            
        }
        
    }
}
