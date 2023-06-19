using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace XpressLoan.Classes
{
    static internal class ConnString
    {

        //static public string conString { get; set; } = "Data Source=DESKTOP-QMK7N8S;Initial Catalog=XpressLoanDB;Integrated Security=True";
        //static public string conString { get; set; } = "data source = (LocalDB)'\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|'\\XpressLoanDB.mdf;Database=XpressLoanDB;Integrated Security = True; Connect Timeout = 30; App=EntityFramework&quot;"; //providerName="System.Data.EntityClient";
        //public static string ConnectionString { get; set; } = "data source = .\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|'\\XpressLoanDB.mdf;Initial Catalog=|DataDirectory|'\\XpressLoanDB.mdf;Database=XpressLoanDB;Integrated Security = true;User Instance=False;Connect Timeout = 30; App=EntityFramework&quot"; //providerName=System.Data.EntityClient";
        //public static string ConnectionString { get; set; } = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog=|DataDirectory|\\XpressLoansLocalDB.mdf;Integrated Security = True";
        //public static string ConnectionString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\XpressDB.mdf;Integrated Security=True; Connect Timeout = 30;";
        public static string ConnectionString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\XpressDB.mdf;Integrated Security=True; Connect Timeout = 10;";

        //\AppData\TahlilGar.mdf
        //public static string ConnectionString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=c:\\LoanApp\\Data\\XpressDB.mdf;Integrated Security=True; Connect Timeout = 30;";

        //"AttachDbFileName=c:\Project\Data\Database1.mdf"
    }
}
