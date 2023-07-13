using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using XpressLoan.Classes;

namespace XpressLoan.Forms
{
    public partial class FormRepayments : Form
    {

        //Data 
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        
        string constr;
        SqlConnection conn;

        CurrentDate iCurrentDate = null;

        string mDateType = "";
        string mStatus = "";
        bool isButtonCreated = false;

        public FormRepayments()
        {
            InitializeComponent();
            constr = ConnString.ConnectionString;
            conn = new SqlConnection(constr);

            initializeFields();
            //tblRepaymentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void cbxDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set dateType
            mDateType = cbxDateType.SelectedItem.ToString();
            //Reset other components to default
            iCurrentDate = new CurrentDate();
            initDate(mDateType);
        }
        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
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
        private void btnNext_Click(object sender, EventArgs e)
        {

            nextDate( mDateType);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prevDate(mDateType);
        }
        public void fillDG_Day(string date_day, string status)
        {
            try
            {
                if (status.Equals("ALL"))
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID',tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments  From tblRepayment " +
                   "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                   "WHERE tblRepayment.RepaymentDate LIKE @date_day " +
                   "ORDER BY tblRepayment.RepaymentDate ", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_day", date_day);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID', tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments From tblRepayment " +
                   "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                   "WHERE tblRepayment.RepaymentDate LIKE @date_day AND tblRepayment.Status LIKE @status " +
                   "ORDER BY tblRepayment.RepaymentDate ", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_day", date_day);
                    da.SelectCommand.Parameters.AddWithValue("@status", status);
                }
               

                ds.Reset();
                da.Fill(ds);
                tblRepaymentDataGridView.DataSource = ds.Tables[0];

                if (!isButtonCreated) //Should run once
                {
                    isButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    tblRepaymentDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Repayment";
                    btn1.Name = "btnMakeRepayment";
                    btn1.Text = "Make Repayment";
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
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID', tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments From tblRepayment " +
                    "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblRepayment.RepaymentDate BETWEEN @start_date AND @end_date " +
                    "ORDER BY tblRepayment.RepaymentDate ", conn);                   
                    da.SelectCommand.Parameters.AddWithValue("@start_date", date_start);
                    da.SelectCommand.Parameters.AddWithValue("@end_date", date_end);
                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID', tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments From tblRepayment " +
                    "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblRepayment.RepaymentDate BETWEEN @start_date AND @end_date AND tblRepayment.Status LIKE '" + status + "'  " +
                    "ORDER BY tblRepayment.RepaymentDate ", conn);

                    da.SelectCommand.Parameters.AddWithValue("@start_date", date_start);
                    da.SelectCommand.Parameters.AddWithValue("@end_date", date_end);
                }
                    

                ds.Reset();
                da.Fill(ds);
                tblRepaymentDataGridView.DataSource = ds.Tables[0];

                if (!isButtonCreated) //Should run once
                {
                    isButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    tblRepaymentDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Repayment";
                    btn1.Name = "btnMakeRepayment";
                    btn1.Text = "Make Repayment";
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
                    da.SelectCommand = new SqlCommand("Select tblCustomers.CustomerID 'ID', tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments From tblRepayment " +
                    "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblRepayment.RepaymentDate LIKE @date_month " +
                    "ORDER BY tblRepayment.RepaymentDate ", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_month", date_month + "%");
                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select tblCustomers.CustomerID 'ID', tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments From tblRepayment " +
                    "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblRepayment.RepaymentDate LIKE @date_month AND tblRepayment.Status LIKE @status " +
                    "ORDER BY tblRepayment.RepaymentDate ", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_month", date_month + "%");
                    da.SelectCommand.Parameters.AddWithValue("@status", status);
                }
                ds.Reset();
                da.Fill(ds);
                tblRepaymentDataGridView.DataSource = ds.Tables[0];

                if (!isButtonCreated) //Should run once
                {
                    isButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    tblRepaymentDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Repayment";
                    btn1.Name = "btnMakeRepayment";
                    btn1.Text = "Make Repayment";
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
                    

                    da.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID', tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments From tblRepayment " +
                    "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblRepayment.RepaymentDate LIKE @date_year ORDER BY tblRepayment.RepaymentDate ", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_year", date_year +"%");
                }
                else
                {
                    da.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID', tblCustomers.Name 'Customer Name', tblRepayment.RepaymentID 'Repayment ID', tblRepayment.LoanID 'Loan ID', tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Amount, tblRepayment.Status, tblRepayment.PaidDate,tblRepayment.Comments From tblRepayment " +
                   "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                   "WHERE tblRepayment.RepaymentDate LIKE @date_year AND tblRepayment.Status LIKE @status " +
                   "ORDER BY tblRepayment.RepaymentDate ", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_year", date_year + "%");
                    da.SelectCommand.Parameters.AddWithValue("@status", status);
                    
                }
                   

                ds.Reset();
                da.Fill(ds);
                tblRepaymentDataGridView.DataSource = ds.Tables[0];

                if (!isButtonCreated) //Should run once
                {
                    isButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    tblRepaymentDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Repayment";
                    btn1.Name = "btnMakeRepayment";
                    btn1.Text = "Make Repayment";
                    btn1.UseColumnTextForButtonValue = true;
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initDate(mDateType);
        }

        private void tblRepaymentDataGridView_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void tblRepaymentDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {

                String cusID = tblRepaymentDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                int loanId = Convert.ToInt32(tblRepaymentDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                FormUserDetails fu = new FormUserDetails(Convert.ToInt32(cusID), loanId);
                fu.ShowDialog(this);
                initializeFields();
            }
        }
    }
}
