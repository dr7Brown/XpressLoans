using MetroFramework.Drawing.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpressLoan.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XpressLoan.Forms
{
    public partial class FormHome : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        SqlDataAdapter dueDA = new SqlDataAdapter();
        DataSet dueDS = new DataSet();

        string constr;
        SqlConnection conn;

        CurrentDate iCurrentDate = null;

        public FormHome()
        {  
            InitializeComponent();
            

            Initialize();
        }
        public void refresh()
        {
            Initialize();
        }
        public void Initialize()
        {
            constr = ConnString.ConnectionString;
            conn = new SqlConnection(constr);
            iCurrentDate = new CurrentDate();
            iCurrentDate.setDay();
            fillDG_Due(iCurrentDate.day);
            fillDG_OverDue(iCurrentDate.day);
            txtDate.Text = iCurrentDate.day;
            DGVTodayRep.Columns[1].FillWeight = 150;

            lblLoansQ.Text = getApprovedLoans()[0] + "";
            lblLoansAmount.Text = "GHC " + string.Format("{0:0.00}", getApprovedLoans()[1]);
           
            lblPending.Text = getPendingLoans()[0] + "";
            lblPendingAmt.Text = "GHC " + string.Format("{0:0.00}", getPendingLoans()[1]);

            lblRep.Text = getRepayemts()[0] + "";
            lblRepAmt.Text = "GHC " + string.Format("{0:0.00}", getRepayemts()[1]);

            lblCustomers.Text = getCustomers()[0] + "";

            lblExpenses.Text = getExpenses()[0] + "";
        }
        public double[] getApprovedLoans()
        {
            int itemCount = 0;
            double totalAmount = 0;
            double[] data = { 0,0};
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblLoans Where Status LIKE @Status", conn);
                    cmd.Parameters.AddWithValue("@Status", "APPROVED");
                    sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        totalAmount += Convert.ToDouble(sqlDataReader["Amount"]);
                        itemCount++;
                    }
                    data[0] = itemCount;
                    data[1] = totalAmount;    

                    sqlDataReader.Close();
                    conn.Close();
                }

            }
            catch (Exception exception)
            { MessageBox.Show("Error occured" + exception.ToString()); }
            return data;
        }
        public double[] getPendingLoans()
        {
            int itemCount = 0;
            double totalAmount = 0;
            double[] data = { 0, 0 };
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblLoans Where Status LIKE @Status", conn);
                    cmd.Parameters.AddWithValue("@Status", "PENDING");
                    sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        totalAmount += Convert.ToDouble(sqlDataReader["Amount"]);
                        itemCount++;
                    }
                    data[0] = itemCount;
                    data[1] = totalAmount;

                    sqlDataReader.Close();
                    conn.Close();
                }

            }
            catch (Exception exception)
            { MessageBox.Show("Error occured" + exception.ToString()); }
            return data;
        }
        public double[] getRepayemts()
        {
            int itemCount = 0;
            double totalAmount = 0;
            double[] data = { 0, 0 };
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblRepayment Where Status LIKE @Status", conn);
                    cmd.Parameters.AddWithValue("@Status", "PAID");
                    sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        totalAmount += Convert.ToDouble(sqlDataReader["Amount"]);
                        itemCount++;
                    }
                    data[0] = itemCount;
                    data[1] = totalAmount;

                    sqlDataReader.Close();
                    conn.Close();
                }

            }
            catch (Exception exception)
            { MessageBox.Show("Error occured" + exception.ToString()); }
            return data;
        }
        public double[] getCustomers()
        {
            int itemCount = 0;
            //double totalAmount = 0;
            double[] data = { 0 };
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblCustomers", conn);
                    sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        //totalAmount += Convert.ToDouble(sqlDataReader["Amount"]);
                        itemCount++;
                    }
                    data[0] = itemCount;
                   // data[1] = totalAmount;

                    sqlDataReader.Close();
                    conn.Close();
                }

            }
            catch (Exception exception)
            { MessageBox.Show("Error occured" + exception.ToString()); }
            return data;
        }
        public double[] getExpenses()
        {
            double totalAmount = 0;
            double[] data = { 0 };
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblExpenses", conn);
                    sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        totalAmount += Convert.ToDouble(sqlDataReader["Amount"]);
                    }
                    data[0] = totalAmount;

                    sqlDataReader.Close();
                    conn.Close();
                }

            }
            catch (Exception exception)
            { MessageBox.Show("Error occured" + exception.ToString()); }
            return data;
        }
        public void fillDG_Due(string date_day)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                try
                {
                    dueDA.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID',tblCustomers.Name 'Customer Name', tblRepayment.Amount, tblRepayment.Status From tblRepayment " +
                    "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblRepayment.RepaymentDate LIKE @date_day " +
                    "ORDER BY tblRepayment.RepaymentDate ", conn);
                    dueDA.SelectCommand.Parameters.AddWithValue("@date_day", date_day); 
                   

                       
                    dueDS.Reset();
                    dueDA.Fill(dueDS);
                    DGVTodayRep.DataSource = dueDS.Tables[0];
                    conn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        public void fillDG_OverDue(string date_day)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();


                try
                {

                    da.SelectCommand = new SqlCommand("Select  tblCustomers.CustomerID 'ID',tblCustomers.Name 'Customer Name', tblRepayment.Amount , tblRepayment.RepaymentDate 'Repayment Date', tblRepayment.Status From tblRepayment " +
                    "JOIN tblLoans ON tblRepayment.LoanID=tblLoans.LoanID JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID " +
                    "WHERE tblRepayment.RepaymentDate < @date_day " +
                    "AND tblRepayment.Status LIKE @status " +
                    "ORDER BY tblRepayment.RepaymentDate ", conn);
                    da.SelectCommand.Parameters.AddWithValue("@date_day", date_day);
                    da.SelectCommand.Parameters.AddWithValue("@status", "UNPAID");


                    ds.Reset();
                    da.Fill(ds);
                    DGVOverDue.DataSource = ds.Tables[0];
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
            }
        }
        private void myButton_MouseEnter(object sender, EventArgs e)
        { //Handle mouse hover effects on panels
            panel1.BackColor = ThemeColor.ColorSeaBlue;
            if (sender.GetType() == typeof(Panel))
            {
                Panel pn = (Panel)sender;
                pn.BackColor = ThemeColor.ColorLightSeaBlue;
            }
        }

        private void myButton_MouseLeave(object sender, EventArgs e)
        { //Handle mouse hover effects on panels
            if (sender.GetType() == typeof(Panel))
            {
                Panel pn = (Panel)sender;
                pn.BackColor= ThemeColor.ColorSeaBlue;
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {//Handle mouse hover effects on panels
            foreach (Control panel in tableLayoutPanel2.Controls)
            {
                if (panel.GetType() == typeof(Panel))
                {
                    panel.MouseEnter += new EventHandler(myButton_MouseEnter);
                    panel.MouseLeave += new EventHandler(myButton_MouseLeave);
                }
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FormCalculator formCalculator = new FormCalculator();
            formCalculator.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void DGVTodayRep_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void DGVOverDue_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
