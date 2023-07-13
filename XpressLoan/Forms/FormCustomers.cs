using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using XpressLoan.Classes;

namespace XpressLoan.Forms
{
    public partial class FormCustomers : Form
    {
        //Adding Placeholder or hint
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        DataGridViewButtonColumn btn1;
        bool isBorrowerButtonCreated = false;
        string mAccountNumber = "";

        //Data 
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

            public FormCustomers()
        {
            InitializeComponent();
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search Customer");
            fillDG();
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            FormAddCustomer fc = new FormAddCustomer();
            fc.ShowDialog(this);
            searchCustomerByAccNumber(mAccountNumber);
        }
   

        public void fillDG()
        {
            try
            {
                //Connection string is assigned to the instance of sql connection.
                String constr = ConnString.ConnectionString;
                SqlConnection conn = new SqlConnection(constr);

                //da.SelectCommand = new SqlCommand("SELECT Farmers.FarmerID, Farmers.Firstname, Farmers.Othernames, Farmers.Lastname,Farmers.Phone, Farmers.FarmAddress, Farmers.Location, Farmers.Gender, Farmers.DoB, Regions.Region FROM Farmers join Regions on Farmers.RegionID = Regions.RegionID", conn);
                da.SelectCommand = new SqlCommand("Select CustomerID 'ID', Name, Gender, Phone, IdNumber 'ID Number', IdType 'ID Type', Address From tblCustomers", conn);
                ds.Clear();
                da.Fill(ds);
                tblCustomersDataGridView.DataSource = ds.Tables[0];

                if (!isBorrowerButtonCreated) //Should run once
                {
                isBorrowerButtonCreated = true;
                    //Codes to display update button at runtime.
                    btn1 = new DataGridViewButtonColumn();
                    tblCustomersDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "View";
                    btn1.Name = "btnView";
                    btn1.Text = "View";
                    btn1.UseColumnTextForButtonValue = true;
                }
                
              
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            searchCustomerByAccNumber(mAccountNumber);
        }

        private void tblCustomersDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex>-1)
            {
                try
                {
                    String cusID = tblCustomersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    FormUserDetails fu = new FormUserDetails(Convert.ToInt32(cusID));
                    fu.ShowDialog(this);
                    fillDG();
                }
                catch(Exception d){ }
                
            }
        }

        private void tblCustomersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchCustomerByAccNumber(mAccountNumber);
        }
        void searchCustomerByAccNumber(string accNumber)
        {
            try
            {
                //Connection string is assigned to the instance of sql connection.
                String constr = ConnString.ConnectionString;
                SqlConnection conn = new SqlConnection(constr);

                /*da.SelectCommand = new SqlCommand("SELECT * FROM tblCustomers " +
                    "WHERE CustomerID LIKE " +
                    "(SELECT MAX(CustomerID) FROM tblAccount WHERE AccNumber LIKE @accNumber)", conn);
                da.SelectCommand.Parameters.AddWithValue("@accNumber", mAccountNumber +"%");*/
                try
                { //Logic: if it is able to convert to int, then acc number was entered // else name was entered
                    Convert.ToInt64(mAccountNumber); 
                    da.SelectCommand = new SqlCommand("SELECT * FROM tblCustomers " +
                    "WHERE CustomerID LIKE " +
                    "(SELECT CustomerID FROM tblAccount WHERE AccNumber LIKE @accNumber)" +
                    "ORDER BY CustomerID DESC", conn);
                    da.SelectCommand.Parameters.AddWithValue("@accNumber", mAccountNumber);
                }
                catch(Exception e)
                {//if name was entered
                    da.SelectCommand = new SqlCommand("SELECT * FROM tblCustomers " +
                    "WHERE Name LIKE @name " +
                    "ORDER BY CustomerID DESC", conn);
                    da.SelectCommand.Parameters.AddWithValue("@name", "%" + mAccountNumber + "%");
                    //da.SelectCommand.Parameters.AddWithValue("@name2", "%" +mAccountNumber + "%");

                }


                ds.Reset();
                da.Fill(ds);
                tblCustomersDataGridView.DataSource = ds.Tables[0];

                if (!isBorrowerButtonCreated) //Should run once
                {
                    isBorrowerButtonCreated = true;
                    //Codes to display update button at runtime.
                    btn1 = new DataGridViewButtonColumn();
                    tblCustomersDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "View";
                    btn1.Name = "btnView";
                    btn1.Text = "View";
                    btn1.UseColumnTextForButtonValue = true;
                }
                
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            mAccountNumber = txtSearch.Text;
            searchCustomerByAccNumber(mAccountNumber);
        }
    }
}
