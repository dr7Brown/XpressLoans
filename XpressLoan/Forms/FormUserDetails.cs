using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using XpressLoan.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XpressLoan.Forms
{
    public partial class FormUserDetails : MetroFramework.Forms.MetroForm
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataGridViewButtonColumn btnPay;
        FormMessage formMessage;

        bool isButtonCreated = false;
        bool isRepaymentButtonCreated = false;
        List<string> listOfLoansByID = new List<string>();
        bool isConstructor1 = false;
        int repaymentLoanID = 0;
        int CustomerID = 0;
        string Name = "";
        string Gender = "";
        string Phone = "";
        string IDNumber = "";
        string IDType = "";
        string Address = "";
        string AccountNumber = "";
        string profilePath = "";
        bool aproveSuccessfull = false;
        bool isStatusChecked = false;


        //printing data
        private List<ScheduleDetails> ScheduleList = new List<ScheduleDetails>();
        int lineNum = 0;
        LoanDetails ld;

        //selected loan details
        //int pLoanID = 0;
        string pLoanAmount = "";
        string pTerms = "";
        string pStartDate = "";
        string pDuration = "";
        string pStatus = "";
        string pProcessingFees = "";
        string pDisbursement = "";
        bool isHeaderPrinted = false;
        


        public FormUserDetails(int CustomerID)
        {
            isConstructor1 = true;
            InitializeComponent();
            this.CustomerID = CustomerID;
            getCurrentCustomer();
            fillLoanDG();
        }
        public FormUserDetails(int CustomerID, int loanID)
        {
            repaymentLoanID = loanID;
            isConstructor1 = false;
            InitializeComponent();
            this.CustomerID = CustomerID;
            getCurrentCustomer();
            fillLoanCB_FrmRep(loanID);
            metroTabControl1.SelectedTab = repaymentMetroTab;
            fillDG_Repayments(loanID);
        }
        private void showProgressBar()
        {
            for (int i = 0; i < 1; i++) //increase i for the number of spins
            {
                for (int j = 0; j < 100; j++)
                {
                    Thread.Sleep(1);
                    progressBar1.Value = j;
                    progressBar1.Update();
                }

            }


        }
        bool validateFields()
        {
            Gender = genderComboBox.Text.ToString();
            IDType = idTypeComboBox.Text.ToString();

            if (customerIDTextBox.Text.Length > 0 &&
            nameTextBox.Text.Length > 0 &&
            phoneTextBox.Text.Length > 0 &&
            idNumberTextBox.Text.Length > 0 &&
            addressTextBox.Text.Length > 0)
            {
                Name = nameTextBox.Text;
                Phone = phoneTextBox.Text;
                IDNumber = idNumberTextBox.Text;
                Address = addressTextBox.Text;

                return true;
            }

            else return false;
        }
        void updateRecords()
        {
            if (validateFields())
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    //status, PaidDate, Comments
                    string query = "UPDATE tblCustomers SET Name=@Name, Gender=@Gender, Phone=@Phone, IdNumber=@IdNumber, IdType=@IDType, Address=@Address WHERE CustomerID=@mCustomerID";
                    da.UpdateCommand = new SqlCommand(query, conn);
                    da.UpdateCommand.Parameters.AddWithValue("@Name", Name);
                    da.UpdateCommand.Parameters.AddWithValue("@Gender", Gender);
                    da.UpdateCommand.Parameters.AddWithValue("@Phone", Phone);
                    da.UpdateCommand.Parameters.AddWithValue("@IdNumber", IDNumber);
                    da.UpdateCommand.Parameters.AddWithValue("@IDType", IDType);
                    da.UpdateCommand.Parameters.AddWithValue("@Address", Address);
                    da.UpdateCommand.Parameters.AddWithValue("@mCustomerID", CustomerID);

                    da.UpdateCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                FormMessage fm = new FormMessage("All fields are required");
                fm.ShowDialog(this);
            }
        }
        private async Task SaveUserDetails()
        {
            try
            {
                // Show the spinner
                progressBar1.Show();

                showProgressBar();

                updateRecords();

                FormMessage fm = new FormMessage("Customer details updated");
                fm.ShowDialog(this);
                fillLoanDG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Customer details" + ex.ToString());
            }
            finally
            {

                genderComboBox.Enabled = false;
                customerIDTextBox.ReadOnly = true;
                nameTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                idNumberTextBox.ReadOnly = true;
                idTypeComboBox.Enabled = false;
                addressTextBox.ReadOnly = true;

                txtTextCount.Visible = false;
                progressBar1.Hide();
                btnSave.Visible = false;
            }
        }

        public void getCurrentCustomer()
        {
            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //Get CustomerID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tblCustomers WHERE CustomerID='" + CustomerID + "'", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    Name = Convert.ToString(dr["Name"]);
                    Gender = Convert.ToString(dr["Gender"]);
                    Phone = Convert.ToString(dr["Phone"]);
                    IDNumber = Convert.ToString(dr["IdNumber"]);
                    IDType = Convert.ToString(dr["IdType"]);
                    Address = Convert.ToString(dr["Address"]);
                }
                dr.Close();
                conn.Close();
               
                getCustomerAccountNumber();
                getCurrentCustomerProfile();
                fillCustomerDetails();
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating Customer Details " + exception.ToString());
                formMessage.ShowDialog(this);
            }
        }
        public void getCurrentCustomerProfile()
        {
            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //Get CustomerID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;

            SqlCommand cmd = new SqlCommand("SELECT Path FROM tblProfile WHERE CustomerID='" + CustomerID + "'", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    profilePath = Convert.ToString(dr["Path"]);
                    
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating Customer Details " + exception.ToString());
                formMessage.ShowDialog(this);
            }
        }
        public void getCustomerAccountNumber()
        {
            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //Get CustomerID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tblAccount WHERE CustomerID='" + CustomerID + "'", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    AccountNumber = Convert.ToString(dr["AccNumber"]);
                    
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating Customer Details " + exception.ToString());
                formMessage.ShowDialog(this);
            }
        }
        public void fillCustomerDetails()
        {
            customerIDTextBox.Text = CustomerID + "";
            nameTextBox.Text = Name;
            genderComboBox.SelectedItem = Gender;
            phoneTextBox.Text = Phone;
            idNumberTextBox.Text = IDNumber;
            idTypeComboBox.Text = IDType;
            addressTextBox.Text = Address;
            txtAccounNum.Text = AccountNumber;

            //string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            //string path = "c:\\LoanApp\\Data";
            pbProfile.ImageLocation = ClassPaths.profileFolder +"\\"+ profilePath;
        }
        public void fillLoanDG()
        {
            try
            {
                //Connection string is assigned to the instance of sql connection.
                String constr = ConnString.ConnectionString;
                SqlConnection conn = new SqlConnection(constr);


                da.SelectCommand = new SqlCommand("Select  tblCustomers.Name 'Customer Name',tblCustomers.CustomerID 'Customer ID', tblLoans.LoanID 'Loan ID', tblLoans.Amount, tblLoans.Purpose, tblLoans.Terms, tblLoans.Rate, tblLoans.ApplicationDate 'Application', tblLoans.CashoutDate 'Cashout', tblLoans.Duration, tblLoans.FirstRepDate 'First Repayemt', tblLoans.Processing, tblLoans.Status,tblLoans.Interest From tblLoans JOIN tblCustomers ON tblLoans.CustomerID=tblCustomers.CustomerID WHERE tblCustomers.CustomerID=@CustomerID", conn);
                da.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                //clear dataset.
                ds.Reset();
                da.Fill(ds);
                tblLoansDataGridView.DataSource = ds.Tables[0];

                if (!isButtonCreated) //Should run once
                {
                    isButtonCreated = true;

                    //Codes to display update button at runtime.
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    tblLoansDataGridView.Columns.Add(btn1);
                    btn1.HeaderText = "Approval";
                    btn1.Name = "btnApprove";
                    btn1.Text = "Approve";
                    btn1.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn c = (DataGridViewButtonColumn)tblLoansDataGridView.Columns["btnApprove"];
                    c.FlatStyle = FlatStyle.Popup;
                    c.DefaultCellStyle.ForeColor = Color.Navy;
                    c.DefaultCellStyle.BackColor = ThemeColor.ColorApproveBtn;

                    //Codes to display delete button at runtime.
                    DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
                    tblLoansDataGridView.Columns.Add(btn3);
                    btn3.HeaderText = "Cancel";
                    btn3.Name = "btnCancel";
                    btn3.Text = "Cancel";
                    btn3.UseColumnTextForButtonValue = true;
                    DataGridViewButtonColumn e = (DataGridViewButtonColumn)tblLoansDataGridView.Columns["btnCancel"];
                    e.FlatStyle = FlatStyle.Popup;
                    e.DefaultCellStyle.ForeColor = Color.Navy;
                    e.DefaultCellStyle.BackColor = ThemeColor.ColorCancelBtn;

                    //Codes to display delete button at runtime.
                    DataGridViewButtonColumn btn4 = new DataGridViewButtonColumn();
                    tblLoansDataGridView.Columns.Add(btn4);
                    btn4.HeaderText = "Delete";
                    btn4.Name = "btnDelete";
                    btn4.Text = "Delete";
                    btn4.UseColumnTextForButtonValue = true;
                    DataGridViewButtonColumn f = (DataGridViewButtonColumn)tblLoansDataGridView.Columns["btnDelete"];
                    f.FlatStyle = FlatStyle.Popup;
                    f.DefaultCellStyle.ForeColor = Color.White;
                    f.DefaultCellStyle.BackColor = ThemeColor.ColorDeletBtn;

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                metroTabControl1.SelectedTab = loanMetroTab;
            }

        }
        public void fillDG_Repayments(int loanId)
        {
            try
            {
                //Connection string is assigned to the instance of sql connection.
                String constr = ConnString.ConnectionString;
                SqlConnection conn = new SqlConnection(constr);

                da.SelectCommand = new SqlCommand("SELECT RepaymentID, RepaymentDate, Amount, Status, PaidDate, Comments, Paid FROM tblRepayment WHERE LoanID LIKE @loanId", conn);
                da.SelectCommand.Parameters.AddWithValue("@loanId", loanId);

                ds.Reset();
                da.Fill(ds);
                tblRepaymentDataGridView1.DataSource = ds.Tables[0];

                if (!isRepaymentButtonCreated) //Should run once
                {
                    isRepaymentButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    btnPay = new DataGridViewButtonColumn();
                    tblRepaymentDataGridView1.Columns.Add(btnPay);
                    btnPay.HeaderText = "PAY";
                    btnPay.Name = "btnPay";
                    btnPay.Text = "PAY";
                    btnPay.UseColumnTextForButtonValue = true;
                }
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading Repayments"+exception.Message); }
        }
        public SqlDataReader repaymentStatement(int loanId)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT RepaymentID, RepaymentDate, Amount, Status, PaidDate, Comments FROM tblRepayment WHERE LoanID LIKE @loanId", conn);
                    cmd.Parameters.AddWithValue("@loanId", loanId);
                    

                    sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.HasRows)
                    {
                        /*sqlDataReader.Read();
                        int repID = Convert.ToInt32(sqlDataReader["RepaymentID"]);*/
                    }

                    sqlDataReader.Close();
                    conn.Close();

                }
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading Statement"); }
            return sqlDataReader;
        }

        private void btnRequestLoan_Click(object sender, EventArgs e)
        {
            FormApplyLoan fa = new FormApplyLoan(CustomerID, Name);
            fa.ShowDialog(this);
            fillLoanDG();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            //Allow editing after buttom click
            genderComboBox.Enabled = true;
            customerIDTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = false;
            phoneTextBox.ReadOnly = false;
            idNumberTextBox.ReadOnly = false;
            idTypeComboBox.Enabled = true;
            addressTextBox.ReadOnly = false;
            btnSave.Visible = true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveUserDetails();
        }
        private void fillCB_Default()
        {

            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);

            da.SelectCommand = new SqlCommand("select LoanID from tblLoans WHERE CustomerID LIKE @CustomerID ORDER BY LoanID ASC", conn);
            da.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = da.SelectCommand.ExecuteReader();
                cbxLoans.Items.Clear(); //Clear items first.
                listOfLoansByID.Clear();

                while (dr.Read())
                {
                    listOfLoansByID.Add(dr["LoanID"].ToString());
                    string loanID = "LOAN ID: #" + dr["LoanID"].ToString();
                    cbxLoans.Items.Add(loanID);
                }
                if (cbxLoans.Items.Count > 0)
                {
                    //GET INDEX OF LAST ITEM
                    cbxLoans.SelectedItem = cbxLoans.Items[cbxLoans.Items.Count - 1];
                    repaymentLoanID = (int)Convert.ToInt64(listOfLoansByID[cbxLoans.SelectedIndex]);
                }
                else { MessageBox.Show("NO LOAN BY USER"); }
                //close reader
                dr.Close();
                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            { }
        }
        private void fillLoanCB_FrmRep(int loansId)
        {

            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);

            da.SelectCommand = new SqlCommand("select LoanID from tblLoans WHERE CustomerID LIKE @CustomerID ORDER BY LoanID ASC", conn);
            da.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = da.SelectCommand.ExecuteReader();
                cbxLoans.Items.Clear(); //Clear items first.
                listOfLoansByID.Clear();

                while (dr.Read())
                {
                    listOfLoansByID.Add(dr["LoanID"].ToString());
                    string loanID = "LOAN ID: #" + dr["LoanID"].ToString();
                    cbxLoans.Items.Add(loanID);
                }
                if (cbxLoans.Items.Count > 0)
                {
                    //GET INDEX OF Clicked Loan from Parent Form ITEM
                    cbxLoans.SelectedIndex = listOfLoansByID.IndexOf(loansId + ""); //cbxLoans.Items[cbxLoans.Items.Count - 1];
                    repaymentLoanID = loansId;
                }
                else { }
                //close reader
                dr.Close();
                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            { }
        }
        void fillTransCB()
        {

            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);

            da.SelectCommand = new SqlCommand("select LoanID from tblLoans WHERE CustomerID LIKE @CustomerID ORDER BY LoanID ASC", conn);
            da.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = da.SelectCommand.ExecuteReader();
                cbxTransLoans.Items.Clear(); //Clear items first.
                listOfLoansByID.Clear();

                while (dr.Read())
                {
                    listOfLoansByID.Add(dr["LoanID"].ToString());
                    string loanID = "LOAN ID: #" + dr["LoanID"].ToString();
                    cbxTransLoans.Items.Add(loanID);
                }
                if (cbxTransLoans.Items.Count > 0)
                {
                    //GET INDEX OF LAST ITEM
                    cbxTransLoans.SelectedItem = cbxTransLoans.Items[cbxTransLoans.Items.Count - 1];
                    repaymentLoanID = (int)Convert.ToInt64(listOfLoansByID[cbxTransLoans.SelectedIndex]);
                }
                else { MessageBox.Show("NO LOAN BY USER"); }
                //close reader
                dr.Close();
                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            { }
        }
        void fillDG_Transactions(int loanId)
        {
            try
            {
                //Connection string is assigned to the instance of sql connection.
                String constr = ConnString.ConnectionString;
                SqlConnection conn = new SqlConnection(constr);

                da.SelectCommand = new SqlCommand("SELECT * FROM tblTransactions WHERE LoanID LIKE @loanId", conn);
                da.SelectCommand.Parameters.AddWithValue("@loanId", loanId);

                ds.Reset();
                da.Fill(ds);
                dgvTransactions.DataSource = ds.Tables[0];

               /* if (!isRepaymentButtonCreated) //Should run once
                {
                    isRepaymentButtonCreated = true;
                    //Codes to display runtime button at runtime.
                    btnPay = new DataGridViewButtonColumn();
                    tblRepaymentDataGridView1.Columns.Add(btnPay);
                    btnPay.HeaderText = "PAY";
                    btnPay.Name = "btnPay";
                    btnPay.Text = "PAY";
                    btnPay.UseColumnTextForButtonValue = true;
                }*/
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading Transactions" + exception.Message); }
        }
        private void cbxLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfItem = cbxLoans.SelectedIndex;
            repaymentLoanID = (int)Convert.ToInt64(listOfLoansByID[indexOfItem]);
            fillDG_Repayments(repaymentLoanID);
        }
        private void cbxTransLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfItem = cbxTransLoans.SelectedIndex;
            repaymentLoanID = (int)Convert.ToInt64(listOfLoansByID[indexOfItem]);
            fillDG_Transactions(repaymentLoanID);
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (metroTabControl1.SelectedIndex)
            {
                case (0):
                    fillLoanDG();
                    break;
                case (1):
                    //Repayments
                    if (isConstructor1)
                    {
                        fillCB_Default();
                    }
                    else
                    {
                        fillLoanCB_FrmRep(repaymentLoanID);
                    }                       
                    fillDG_Repayments(repaymentLoanID);                
                    break;
                case (2):
                    //Transactions
                    fillTransCB();
                    fillDG_Transactions(repaymentLoanID);
                    break;
                case (3):
                    break;
            }
        }

        private void tblRepaymentDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                //Pay Button clicked
                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {
                    //String cusID = tblRepaymentDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int repaymentID = Convert.ToInt32(tblRepaymentDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    double amount = Convert.ToDouble(tblRepaymentDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    string status = tblRepaymentDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    FormAddRepayment fr = new FormAddRepayment(repaymentID, CustomerID, Name, repaymentLoanID, amount, status);
                    fr.ShowDialog(this);
                    fillDG_Repayments(repaymentLoanID);
                }
            }
            catch(Exception exception) { }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillDG_Repayments(repaymentLoanID);
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderComboBox.SelectedIndex == 0)
                Gender = "FEMALE";
            else
                Gender = "MALE";

        }

        private void idTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idTypeComboBox.SelectedIndex == 0)
                IDType = "GHANA CARD";
            else IDType = "VOTER";
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            txtTextCount.Text = addressTextBox.Text.Length.ToString() + "/20";
            txtTextCount.Visible= true;
        }

        private void tblLoansDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void tblRepaymentDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }

        }
        public int generateRepaymentID()
        {
            int repID = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                //Get RegionID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblRepayment WHERE RepaymentID=(SELECT max(RepaymentID) FROM tblRepayment);", conn);
                SqlDataReader dr;
                try
                {
                    dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        repID = 1000;
                    }
                    else
                    {
                        dr.Read();
                        repID = Convert.ToInt32(dr["RepaymentID"])+1;
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception exception)
                {
                    formMessage = new FormMessage("Error generating mRepaymentID " + exception.ToString());
                    formMessage.ShowDialog(this);
                }
            }
            return repID;

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

        private void generateRepaymentDates(int loanId, double mAmount, string mTerms, double mRate, int mDuration, string mFirstRepaymentDate)
        {
            double myInterestPlusPrincipal = 0;
            double myInterest = 0;
            double myRepayments =  0.0;
            int myNumOfTimesRepay = 0;

            myInterest = (mAmount * mDuration * mRate) / 100;
            myInterestPlusPrincipal = myInterest + mAmount;

            //to del
            myRepayments = myInterestPlusPrincipal / mDuration; 
            Console.WriteLine("my repayments: " + myRepayments + "");
            Console.WriteLine("my myInterestPlusPrincipal: " + myInterestPlusPrincipal + "");
            Console.WriteLine("my mAmount: " + mAmount + "");
            Console.WriteLine("my mDuration: " + mDuration + "");
            Console.WriteLine("my mRate: " + mRate + "");
            Console.WriteLine("my myInterest: " + myInterest + "");

            //end
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
                    //Get the repayment dates
                    for (int i = 0; i < myNumOfTimesRepay; i++)
                    {
                        var nextrepdate = nextRepaymentDate(mFirstRepaymentDate, 7 * i, 0);
                        repaymentDates.Add(nextrepdate);
                     }
                    approveLoan(loanId, repaymentDates, myRepayments);
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
                    approveLoan(loanId, repaymentDates, myRepayments);
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
                    approveLoan(loanId, repaymentDates, myRepayments);
                    break;
            }
        }

        void approveLoan(int loanId, List<string> repaymentDates, double myRepayments)
        {
            ld = new LoanDetails(loanId);
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {   
                   //status, PaidDate, Comments
                    string query = "UPDATE tblLoans SET Status=@status WHERE LoanID=@loanId";
                    da.UpdateCommand = new SqlCommand(query, conn, transaction);
                    da.UpdateCommand.Parameters.AddWithValue("@status", "APPROVED");
                    da.UpdateCommand.Parameters.AddWithValue("@loanId", loanId);
                    da.UpdateCommand.ExecuteNonQuery();

                    //
                    string query2 = "INSERT INTO tblRepayment VALUES(@RepaymentID, @LoanID, @RepaymentDate, @Amount, @Status, @PaidDate, @Comments, @Paid)";
                    int repaymentID = generateRepaymentID();
                    foreach (string date in repaymentDates)
                    {
                        da.InsertCommand = new SqlCommand(query2, conn, transaction);
                        da.InsertCommand.Parameters.AddWithValue("@RepaymentID", repaymentID);
                        da.InsertCommand.Parameters.AddWithValue("@LoanID", loanId);
                        da.InsertCommand.Parameters.AddWithValue("@RepaymentDate", date);
                        da.InsertCommand.Parameters.AddWithValue("@Amount", myRepayments);
                        da.InsertCommand.Parameters.AddWithValue("@Status", "UNPAID");
                        da.InsertCommand.Parameters.AddWithValue("@PaidDate", "-");
                        da.InsertCommand.Parameters.AddWithValue("@Comments", "-");
                        da.InsertCommand.Parameters.AddWithValue("@Paid", "0");
                        da.InsertCommand.ExecuteNonQuery();
                        //next repayment ID
                        repaymentID += 1;
                    }

                    
                    string mTransInfo = "LOAN" + loanId;
                    string query3 = "INSERT INTO tblTransactions VALUES(@AppDate,@Info, @Credit, @Debit, @LoanID, @Balance)";
                    da.InsertCommand = new SqlCommand(query3, conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@AppDate", ld.applicationDate);
                    da.InsertCommand.Parameters.AddWithValue("@Info", mTransInfo);
                    da.InsertCommand.Parameters.AddWithValue("@Credit", 0);
                    da.InsertCommand.Parameters.AddWithValue("@Debit", ld.amount);
                    da.InsertCommand.Parameters.AddWithValue("@LoanID", loanId);
                    da.InsertCommand.Parameters.AddWithValue("@Balance", (ld.amount * -1));
                    da.InsertCommand.ExecuteNonQuery();

                    mTransInfo = "LOAN" + loanId + " INTEREST";
                    string query4 = "INSERT INTO tblTransactions VALUES(@AppDate,@Info, @Credit, @Debit, @LoanID, @Balance)";
                    da.InsertCommand = new SqlCommand(query4, conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@AppDate", ld.applicationDate);
                    da.InsertCommand.Parameters.AddWithValue("@Info", mTransInfo);
                    da.InsertCommand.Parameters.AddWithValue("@Credit", 0);
                    da.InsertCommand.Parameters.AddWithValue("@Debit", ld.interest);
                    da.InsertCommand.Parameters.AddWithValue("@LoanID", loanId);
                    da.InsertCommand.Parameters.AddWithValue("@Balance", ((ld.interest +ld.amount) * -1) );
                    da.InsertCommand.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                    aproveSuccessfull = true;
                    //
                    conn.Close();
                }catch(Exception ex) { transaction.Rollback(); MessageBox.Show(ex.Message + "here");
                    aproveSuccessfull = false;
                }
            }
            
        }
        void cancelLoan(int loanId)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "UPDATE tblLoans SET Status=@status WHERE LoanID=@loanId";
                da.UpdateCommand = new SqlCommand(query, conn);
                da.UpdateCommand.Parameters.AddWithValue("@status", "CANCELLED");
                da.UpdateCommand.Parameters.AddWithValue("@loanId", loanId);
                da.UpdateCommand.ExecuteNonQuery();
                
                conn.Close();
            }
        }
        void deletLoan(int loanId)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {

                    string query = "DELETE FROM tblRepayment WHERE LoanID=@loanId";
                    da.DeleteCommand = new SqlCommand(query, conn, transaction);
                    da.DeleteCommand.Parameters.AddWithValue("@loanId", loanId);
                    da.DeleteCommand.ExecuteNonQuery();

                    string query2 = "DELETE FROM tblLoans WHERE LoanID=@loanId";
                    da.DeleteCommand = new SqlCommand(query2, conn, transaction);
                    da.DeleteCommand.Parameters.AddWithValue("@loanId", loanId);
                    da.DeleteCommand.ExecuteNonQuery();

                    transaction.Commit();
                    conn.Close();
                }
                catch { transaction.Rollback(); }
            }
        }
        private void tblLoansDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int loanId = 0;
                double mAmount = 0;
                string mTerms = "";
                double mRate = 0;
                int mDuration = 0;
                string mFirstRepaymentDate = "";
                string mStatus = "";


                try
                {
                     loanId = Convert.ToInt32(tblLoansDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                     mAmount = Convert.ToDouble(tblLoansDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
                     mTerms = tblLoansDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                     mRate = Convert.ToDouble(tblLoansDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString());
                     mDuration = Convert.ToInt32(tblLoansDataGridView.Rows[e.RowIndex].Cells[12].Value.ToString());
                     mFirstRepaymentDate = tblLoansDataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
                     mStatus = tblLoansDataGridView.Rows[e.RowIndex].Cells[15].Value.ToString();
                }
                catch(Exception ex) { MessageBox.Show("Error fetching data"+ex.ToString());
       }

                //Approve Button clicked
                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {

                    if (mStatus.Equals("PENDING"))
                    {
                        FormAlerts alertDialog = new FormAlerts();
                        alertDialog.ShowDialog("Confirm Approval of LOAN #" + loanId);
                        if (alertDialog.DialogResult == DialogResult.OK)
                        {
                            generateRepaymentDates(loanId, mAmount, mTerms, mRate, mDuration, mFirstRepaymentDate);
                            Thread.Sleep(300);
                            if (aproveSuccessfull)
                            {
                                FormMessage fm = new FormMessage("Loan #" + loanId + " Approved");
                                fm.ShowDialog(this);
                                fillLoanDG();
                            }
                           
                            
                        }
                    }
                    else if (mStatus.Equals("APPROVED"))
                    {
                        FormMessage fm = new FormMessage("Loan #" + loanId + " Already Approved");
                        fm.ShowDialog(this);
                    }
                    else
                    {
                        FormMessage fm = new FormMessage("No Action Perfomed");
                        fm.ShowDialog(this);
                    }
                }
                
                //Cancel Button clicked
                if (e.ColumnIndex == 1 && e.RowIndex > -1)
                {
                    if (mStatus.Equals("PENDING"))
                    {

                        FormAlerts alertDialog = new FormAlerts();
                        alertDialog.ShowDialog("Confirm Cancel of LOAN #" +loanId);
                        if (alertDialog.DialogResult == DialogResult.OK)
                        {
                            cancelLoan(loanId);
                            Thread.Sleep(300);
                            FormMessage fm = new FormMessage("Loan #" + loanId + " Cancelled");
                            fm.ShowDialog(this);
                            fillLoanDG();
                        }                         
                    }
                    else if (mStatus.Equals("CANCELLED"))
                    {
                        FormMessage fm = new FormMessage("Loan #" + loanId + " Already Cancelled");
                        fm.ShowDialog(this);
                    }
                    else
                    {
                        FormMessage fm = new FormMessage("Can NOT Cancel Loan #" + loanId );
                        fm.ShowDialog(this);
                    }
                }
                //Delet Button clicked
                if (e.ColumnIndex == 2 && e.RowIndex > -1)
                {
                    FormAlerts alertDialog = new FormAlerts();
                    alertDialog.ShowDialog("Confirm Delete of LOAN #" + loanId);
                    if (alertDialog.DialogResult == DialogResult.OK)
                    {
                        alertDialog.ShowDialog("This Action CANNOT be reversed");
                        if (alertDialog.DialogResult == DialogResult.OK)
                        {
                            deletLoan(loanId);
                            Thread.Sleep(300);
                            FormMessage fm = new FormMessage("Loan #" + loanId + " Deleted");
                            fm.ShowDialog(this);
                            fillLoanDG();
                        }
                    }
                }
            }
        }
        private void btnPrintSchedule_Click(object sender, EventArgs e)
        {
            selectedToPrintLoanDetails(repaymentLoanID);
            getScheduleData(repaymentLoanID);
           /* for print preview
            lineNum = 0;
            printPreviewDialog1.Document = printDocument1;        
            printPreviewDialog1.ShowDialog();*/

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            lineNum = 0;
            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = pd;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        
        public void selectedToPrintLoanDetails(int loanId)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Amount, Terms, FirstRepDate, Duration, Status, Processing, CashoutDate FROM tblLoans WHERE LoanID LIKE @loanId", conn);
                    cmd.Parameters.AddWithValue("@loanId", loanId);
                    sqlDataReader = cmd.ExecuteReader();
                    /*while (sqlDataReader.HasRows)
                    {*/
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();
                        pLoanAmount = sqlDataReader["Amount"].ToString();
                        pTerms = sqlDataReader["Terms"].ToString();
                        DateTime dt1 = Convert.ToDateTime(sqlDataReader["FirstRepDate"].ToString());
                        pStartDate = dt1.ToString("dd'-'MM'-'yyyy");
                        pDuration = sqlDataReader["Duration"].ToString() + " Months";
                        pStatus = sqlDataReader["Status"].ToString();
                        pProcessingFees = sqlDataReader["Processing"].ToString();

                        DateTime dt = Convert.ToDateTime(sqlDataReader["CashoutDate"].ToString());
                        pDisbursement = dt.ToString("dd'-'MM'-'yyyy");
                    }
                    sqlDataReader.Close();
                    conn.Close();
                }
               
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading Statement" + exception.ToString()); }
        }
        public void getScheduleData(int loanId)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                //Connection string is assigned to the instance of sql connection.
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand SelectCommand = new SqlCommand("SELECT RepaymentID, RepaymentDate , Amount, Status, PaidDate FROM tblRepayment WHERE LoanID LIKE @loanId", conn);
                    SelectCommand.Parameters.AddWithValue("@loanId", loanId);
                    sqlDataReader = SelectCommand.ExecuteReader();
                    ScheduleList.Clear(); //reset 
                    while (sqlDataReader.Read())
                    {
                        ScheduleList.Add(new ScheduleDetails(sqlDataReader["RepaymentID"].ToString(),
                                                 sqlDataReader["RepaymentDate"].ToString(),
                                                 sqlDataReader["Amount"].ToString(),
                                                 sqlDataReader["Status"].ToString(),
                                                 sqlDataReader["PaidDate"].ToString()));


                    }
                    sqlDataReader.Close();
                    conn.Close();
                }
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading data into array" + exception.ToString()); }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            // Logo
            Image image = Properties.Resources.xpress_logo;
            e.Graphics.DrawImage(image, 10, 5, 100, 100);
            Pen pen = new Pen(Color.FromKnownColor(KnownColor.Blue), 2);
            e.Graphics.DrawRectangle(pen, 10, 5, 800, 100);
            ClassHeader classHeader = new ClassHeader();
            e.Graphics.DrawString(classHeader.companyName, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(120, 15));
            e.Graphics.DrawString("Contact1: " + classHeader.contact1, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 49));
            e.Graphics.DrawString("Contact2: " + classHeader.contact2, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(475, 49));
            e.Graphics.DrawString("Email: " + classHeader.email, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 78));


            //Header 
            e.Graphics.DrawString("Repayment Schedule ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(50, 120));

            //Data headings
            e.Graphics.DrawString("Loan ID: " + repaymentLoanID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 162));
            e.Graphics.DrawString("Duration: " + pDuration, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 162));

            e.Graphics.DrawString("Name: " + Name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 186));
            e.Graphics.DrawString("Start Date: " + pStartDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 186));

            e.Graphics.DrawString("Amount: " + pLoanAmount, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 208));
            e.Graphics.DrawString("Terms: " + pTerms, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 208));
            //e.Graphics.DrawString("Processing fees: " + pProcessingFees, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 195));

            e.Graphics.DrawString("Disbursement: " + pDisbursement, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 230));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd-MM-yyyy"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 230));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 245));

            e.Graphics.DrawString("ID", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 265));
            e.Graphics.DrawString("Date ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 265));
            e.Graphics.DrawString("Amount ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(300, 265));
            e.Graphics.DrawString("Status ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(450, 265));
            e.Graphics.DrawString("Date Paid", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 265));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 280));



            Font myFont = new Font("m_svoboda", 14, FontStyle.Underline, GraphicsUnit.Point);

            float lineHeight = myFont.GetHeight(e.Graphics) + 4;

            //float yLineTop = e.MarginBounds.Top + 200;
            float yLineTop = e.MarginBounds.Top + 200;

            for (; lineNum < ScheduleList.Count; lineNum++)
            {
                if (yLineTop + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }         

                e.Graphics.DrawString(ScheduleList[lineNum].repID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(50, yLineTop));
                e.Graphics.DrawString(ScheduleList[lineNum].repDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(150, yLineTop));
                e.Graphics.DrawString(ScheduleList[lineNum].amount, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(300, yLineTop));
                if (isStatusChecked)
                {
                    e.Graphics.DrawString(ScheduleList[lineNum].status, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(450, yLineTop));

                }
                else
                {
                    e.Graphics.DrawString("----------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(450, yLineTop));

                }
                e.Graphics.DrawString(ScheduleList[lineNum].paidDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(600, yLineTop));

                yLineTop += lineHeight;
            }

            e.HasMorePages = false;


            //Print on last page buttom
            e.Graphics.DrawString("The Manager ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 1040));

            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 1060));


        }
        private void btnPrintStmt_Click_1(object sender, EventArgs e)
        {
            selectedToPrintLoanDetails(repaymentLoanID); //for header data
            getScheduleData(repaymentLoanID);

            /*lineNum = 0;
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();*/

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
            lineNum = 0;
            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = pd;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            
        }


        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Logo
            Image image = Properties.Resources.xpress_logo;
            e.Graphics.DrawImage(image, 10, 5, 100, 100);
            Pen pen = new Pen(Color.FromKnownColor(KnownColor.Blue), 2);
            e.Graphics.DrawRectangle(pen, 10, 5, 800, 100);
            ClassHeader classHeader = new ClassHeader();
            e.Graphics.DrawString(classHeader.companyName, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(120, 15));
            e.Graphics.DrawString("Contact1: " + classHeader.contact1, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 49));
            e.Graphics.DrawString("Contact2: " + classHeader.contact2, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(475, 49));
            e.Graphics.DrawString("Email: " + classHeader.email, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 78));


            //Header 
            e.Graphics.DrawString("Loan Statement ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(50, 120));

            //Data headings
            e.Graphics.DrawString("Loan ID: " + repaymentLoanID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 162));
            e.Graphics.DrawString("Duration: " + pDuration, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 162));

            e.Graphics.DrawString("Name: " + Name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 186));
            e.Graphics.DrawString("Start Date: " + pStartDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 186));
                     
            e.Graphics.DrawString("Amount: " + pLoanAmount, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 208));
            e.Graphics.DrawString("Terms: " + pTerms, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 208));
            //e.Graphics.DrawString("Processing fees: " + pProcessingFees, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 195));

            e.Graphics.DrawString("Disbursement: " + pDisbursement, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 230));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd-MM-yyyy"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 230));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 245));
            
            e.Graphics.DrawString("Date", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(50, 265));
            e.Graphics.DrawString("Info ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 265));
            e.Graphics.DrawString("Credit ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 265));
            e.Graphics.DrawString("Debit ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(480, 265));
            e.Graphics.DrawString("Balance ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 265));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 280));



            Font myFont = new Font("m_svoboda", 14, FontStyle.Underline, GraphicsUnit.Point);

            float lineHeight = myFont.GetHeight(e.Graphics) + 4;

            //float yLineTop = e.MarginBounds.Top + 200;
            float yLineTop = e.MarginBounds.Top + 200;

            TransactionData td = new TransactionData(repaymentLoanID);
            //td.getTransactionData(repaymentLoanID);
            int itemcount = td.TransList.Count;
            for (; lineNum < itemcount; lineNum++)
            {
                if (yLineTop + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                
                e.Graphics.DrawString(td.TransList[lineNum].date, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(50, yLineTop));
                e.Graphics.DrawString(td.TransList[lineNum].info, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(150, yLineTop));
                e.Graphics.DrawString(string.Format("{0:0.00}", td.TransList[lineNum].credit), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(350, yLineTop));
                e.Graphics.DrawString(string.Format("{0:0.00}", td.TransList[lineNum].debit), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(480, yLineTop));
                e.Graphics.DrawString(string.Format("{0:0.00}", td.TransList[lineNum].balance), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(600, yLineTop));

                yLineTop += lineHeight;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(50, yLineTop));
            yLineTop += lineHeight;
            e.Graphics.DrawString("Total: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(50, yLineTop));
            //e.Graphics.DrawString("kdks", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(150, yLineTop));
            e.Graphics.DrawString(string.Format("{0:0.00}", td.totalCredit), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(350, yLineTop));
            e.Graphics.DrawString(string.Format("{0:0.00}", td.totalDebit), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(480, yLineTop));
            e.Graphics.DrawString(string.Format("{0:0.00}", td.totalBalance), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(600, yLineTop));
            yLineTop += lineHeight;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(50, yLineTop));

            e.HasMorePages = false;


            //Print on last page buttom
            e.Graphics.DrawString("The Manager ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 1040));

            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 1060));


        }

        private void ckbxEnableStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxEnableStatus.Checked) { isStatusChecked = true; } 
            else { isStatusChecked = false; }
        }
    }
}
