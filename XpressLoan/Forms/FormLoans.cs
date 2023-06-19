using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpressLoan.Classes;

namespace XpressLoan.Forms
{
    public partial class FormLoans : Form
    {
        //Data 
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        String constr;
        SqlConnection conn;
        DataGridViewButtonColumn btn1;
        bool isBorrowerButtonCreated = false;

        CurrentDate iCurrentDate = null;
        string mDateType = "";
        string mStatus = "";
        //int sn = 1;

        public FormLoans()
        {
            InitializeComponent();
            constr = ConnString.ConnectionString;
            conn = new SqlConnection(constr);
            initializeFields();
            //fillDG();
            fillDG_Day(iCurrentDate.day, mStatus);
            tblLoansDataGridView.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.AllCells;

        }
        string val = "";
        public void fillDG()
        {
            try
            {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest From tblLoans JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID", conn);
                    ds.Clear();
                    da.Fill(ds);
                    tblLoansDataGridView.DataSource = ds.Tables[0];

                    if (!isBorrowerButtonCreated) //Should run once
                    {
                        isBorrowerButtonCreated = true;
                        //Codes to display runtime button at runtime.
                        btn1 = new DataGridViewButtonColumn();
                        tblLoansDataGridView.Columns.Add(btn1);
                        btn1.HeaderText = "Borrower";
                        btn1.Name = "btnViewBorrower";
                        btn1.Text = "View Borrower";
                        btn1.UseColumnTextForButtonValue = true;
                    }

                    //increase column width       //1ST SPECIFY THE NUMBER OF COLUMNS
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //fillDG();
            initDate(mDateType);
        }

        private void cbxDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set dateType
            mDateType = cbxDateType.SelectedItem.ToString();
            //Reset other components to default
            iCurrentDate = new CurrentDate();
            initDate(mDateType);
        }

        private void cbxLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            mStatus = cbxStatus.SelectedItem.ToString();
            initDate(mDateType);
        }
        void initializeFields()
        {
            iCurrentDate = new CurrentDate();
            txtDate.Text = iCurrentDate.day;
            mDateType = "DAY";
            mStatus = "ALL";
            cbxDateType.SelectedItem = mDateType;
            cbxStatus.SelectedItem = mStatus;
            initDate(mDateType);
        }
        void initDate(string date_literals)
        {
            switch (date_literals)
            {
                case ("DAY"):
                    //goto day
                    iCurrentDate.setDay();
                    txtDate.Text = iCurrentDate.day;
                    fillDG_Day(iCurrentDate.day, mStatus);
                    break;
                case ("WEEK"):
                    //goto month
                    iCurrentDate.setWeek();
                    txtDate.Text = iCurrentDate.endDayOfWeek;
                    fillDG_Week(iCurrentDate.startDayOfWeek, iCurrentDate.endDayOfWeek, mStatus);
                    break;
                case ("MONTH"):
                    //goto month
                    iCurrentDate.setMonth();
                    txtDate.Text = iCurrentDate.monthDate_short;
                    fillDG_Month(iCurrentDate.monthDate_db, mStatus);
                    break;
                case ("YEAR"):
                    //goto next year
                    iCurrentDate.setYear();
                    txtDate.Text = iCurrentDate.year;
                    fillDG_Year(iCurrentDate.year, mStatus);
                    break;
            }
        }
        void nextDate(string date_literals)
        {
            switch (date_literals)
            {
                case ("DAY"):
                    //goto next day
                    iCurrentDate.setNextDay();
                    txtDate.Text = iCurrentDate.day;
                    fillDG_Day(iCurrentDate.day, mStatus);
                    break;
                case ("WEEK"):
                    //goto next month
                    iCurrentDate.setNextWeek();
                    txtDate.Text = iCurrentDate.endDayOfWeek;
                    fillDG_Week(iCurrentDate.startDayOfWeek, iCurrentDate.endDayOfWeek, mStatus);
                    break;
                case ("MONTH"):
                    //goto next month
                    iCurrentDate.setNextMonth();
                    txtDate.Text = iCurrentDate.monthDate_short;
                    fillDG_Month(iCurrentDate.monthDate_db, mStatus);
                    break;
                case ("YEAR"):
                    //goto next year
                    iCurrentDate.setNextYear();
                    txtDate.Text = iCurrentDate.year;
                    fillDG_Year(iCurrentDate.year, mStatus);
                    break;
            }
        }
        void prevDate(string date_literals)
        {
            switch (date_literals)
            {
                case ("DAY"):
                    //goto next day
                    iCurrentDate.setPrevDay();
                    txtDate.Text = iCurrentDate.day;
                    fillDG_Day(iCurrentDate.day, mStatus);
                    break;
                case ("WEEK"):
                    //goto next month
                    iCurrentDate.setPrevWeek();
                    txtDate.Text = iCurrentDate.endDayOfWeek;
                    fillDG_Week(iCurrentDate.startDayOfWeek, iCurrentDate.endDayOfWeek, mStatus);
                    break;
                case ("MONTH"):
                    //goto next month
                    iCurrentDate.setPrevMonth();
                    txtDate.Text = iCurrentDate.monthDate_short;
                    fillDG_Month(iCurrentDate.monthDate_db, mStatus);
                    break;
                case ("YEAR"):
                    //goto next year
                    iCurrentDate.setPrevYear();
                    txtDate.Text = iCurrentDate.year;
                    fillDG_Year(iCurrentDate.year, mStatus);
                    break;
            }
        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            nextDate(mDateType);
        }

        private void btnArrowLeft_Click(object sender, EventArgs e)
        {
            prevDate(mDateType);
        }
        public void fillDG_Day(string date_day, string status)
        {
            try
            {
                /* da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', " +
                     "tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', " +
                     "tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status " +
                     "From tblLoans " +
                     "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID", conn);*/
                if (status.Equals("ALL"))
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                    "From tblLoans " +
                    "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblLoans.ApplicationDate LIKE @date_day " +
                    "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_day", date_day);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                    "From tblLoans " +
                    "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblLoans.ApplicationDate LIKE @date_day AND tblLoans.Status LIKE @Status " +
                    "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_day", date_day);
                    da.SelectCommand.Parameters.AddWithValue("@status", status);      
                }
                ds.Reset();
                da.Fill(ds);
                tblLoansDataGridView.DataSource = ds.Tables[0];
                if (!isBorrowerButtonCreated) //Should run once
                {
                    isBorrowerButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    btn1 = new DataGridViewButtonColumn();
                    tblLoansDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Borrower";
                    btn1.Name = "btnViewBorrower";
                    btn1.Text = "View Borrower";
                    btn1.UseColumnTextForButtonValue = true;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void fillDG_Week(string date_start, string date_end, string status)
        {
            try
            {
                if (status.Equals("ALL"))
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                    "From tblLoans " +
                    "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblLoans.ApplicationDate BETWEEN @start_date AND @end_date " +
                    "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@start_date", date_start);
                    da.SelectCommand.Parameters.AddWithValue("@end_date", date_end);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                   "From tblLoans " +
                   "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                   "WHERE tblLoans.ApplicationDate BETWEEN @start_date AND @end_date AND tblLoans.Status LIKE @status " +
                   "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@start_date", date_start);
                    da.SelectCommand.Parameters.AddWithValue("@end_date", date_end);
                    da.SelectCommand.Parameters.AddWithValue("@status", status);  
                }


                ds.Reset();
                da.Fill(ds);
                tblLoansDataGridView.DataSource = ds.Tables[0];
                if (!isBorrowerButtonCreated) //Should run once
                {
                    isBorrowerButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    btn1 = new DataGridViewButtonColumn();
                    tblLoansDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Borrower";
                    btn1.Name = "btnViewBorrower";
                    btn1.Text = "View Borrower";
                    btn1.UseColumnTextForButtonValue = true;
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void fillDG_Month(string date_month, string status)
        {
            try
            {
                if (status.Equals("ALL"))
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                    "From tblLoans " +
                    "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblLoans.ApplicationDate LIKE @date_month " +
                    "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_month", date_month + "%");

                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                   "From tblLoans " +
                   "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                   "WHERE tblLoans.ApplicationDate LIKE @date_month AND tblLoans.Status LIKE @Status " +
                   "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_month", date_month + "%");
                    da.SelectCommand.Parameters.AddWithValue("@status", status);
                }
                ds.Reset();
                da.Fill(ds);
                tblLoansDataGridView.DataSource = ds.Tables[0];
                if (!isBorrowerButtonCreated) //Should run once
                {
                    isBorrowerButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    btn1 = new DataGridViewButtonColumn();
                    tblLoansDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Borrower";
                    btn1.Name = "btnViewBorrower";
                    btn1.Text = "View Borrower";
                    btn1.UseColumnTextForButtonValue = true;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void fillDG_Year(string date_year, string status)
        {
            try
            {
                if (status.Equals("ALL"))
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                    "From tblLoans " +
                    "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblLoans.ApplicationDate LIKE @date_year " +
                    "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_year", date_year + "%");                   
                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status, tblLoans.Interest " +
                    "From tblLoans " +
                    "JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblLoans.ApplicationDate LIKE @date_year AND tblLoans.Status LIKE @Status " +
                    "ORDER BY tblLoans.ApplicationDate", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_year", date_year + "%");
                    da.SelectCommand.Parameters.AddWithValue("@status", status);
                }


                ds.Reset();
                da.Fill(ds);
                tblLoansDataGridView.DataSource = ds.Tables[0];
                if (!isBorrowerButtonCreated) //Should run once
                {
                    isBorrowerButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    btn1 = new DataGridViewButtonColumn();
                    tblLoansDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Borrower";
                    btn1.Name = "btnViewBorrower";
                    btn1.Text = "View Borrower";
                    btn1.UseColumnTextForButtonValue = true;
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void tblLoansDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String cusID = tblLoansDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                //send user details to 
                FormUserDetails fu = new FormUserDetails(Convert.ToInt32(cusID));
                fu.ShowDialog(this);
            }
            else if (e.ColumnIndex == 103)
            {
                FormMessage fm = new FormMessage(val);
                fm.ShowDialog(this);
            }
        }

        private void tblLoansDataGridView_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
