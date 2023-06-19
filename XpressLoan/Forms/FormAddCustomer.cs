using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using WinFormAnimation;
using XpressLoan.Classes;

namespace XpressLoan.Forms
{
    public partial class FormAddCustomer : MetroFramework.Forms.MetroForm
    {
        SqlDataAdapter da = new SqlDataAdapter();
        String constr;
        SqlConnection conn;
        //DataSet ds = new DataSet();
        FormMessage formMessage;

        long mCusAccountNumber = 0;
        int mAccountID = 0;
        int mCustomerID = 0;
        bool errOccured = false;

        public FormAddCustomer()
        {
            InitializeComponent();
            constr = ConnString.ConnectionString;
            conn = new SqlConnection(constr);
            //makeDir();
            ClassPaths.createProfileDir();
        }
        
        public int generateAccountID()
        {
            /*string constr = ConnString.conString;
            SqlConnection conn = new SqlConnection(constr);*/

            //Get ID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY AccID Id DESC;
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblAccount WHERE AccID=(SELECT max(AccID) FROM tblAccount);", conn);

            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    mAccountID = 3100;
                }
                else
                {
                    dr.Read();
                    mAccountID = Convert.ToInt32(dr["AccID"]) + 1;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating CustomerID " + exception.ToString());
                formMessage.ShowDialog(this);
            }
            return mAccountID;

        }
        public int generateCustomerID()
        {
            /*String constr = ConnString.conString;
            SqlConnection conn = new SqlConnection(constr);*/

            //Get RegionID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblCustomers WHERE CustomerID=(SELECT max(CustomerID) FROM tblCustomers);", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                
                if (!dr.HasRows)
                {
                    mCustomerID = 1100;
                }
                else
                {
                    dr.Read();
                    mCustomerID = Convert.ToInt32(dr["CustomerID"]) +1;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating CustomerID " + exception.ToString());
                formMessage.ShowDialog(this);
            }
            return mCustomerID;

        }

        public long generateAccountNumber()
        {
            /*String constr = ConnString.conString;
            SqlConnection conn = new SqlConnection(constr);*/

            //Get RegionID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;
            SqlCommand cmd = new SqlCommand("SELECT AccNumber FROM tblAccount WHERE AccID=(SELECT max(AccID) FROM tblAccount);", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    mCusAccountNumber = 2070001000001;
                }
                else
                {
                    
                    dr.Read();
                    
                   /* long x = 0;
                    string accnum = Convert.ToString(dr["AccNumber"]);
                    Int64.TryParse(accnum, out x );*/

                    mCusAccountNumber = Convert.ToInt64(dr["AccNumber"]) + 1; 
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                formMessage = new FormMessage("Error generating Account Number " + exception.ToString());
                formMessage.ShowDialog(this);
            }
            return mCusAccountNumber;

        }
        bool validateFields()
        {
            if (nameTextBox.Text.Length > 0
                   && phoneTextBox.Text.Length > 0
                   && idNumberTextBox.Text.Length > 0
                   && addressTextBox.Text.Length > 0
                   && genAccNumTextBox.Text.Length > 0
                   && genderComboBox.Text.Length > 0
                   && idTypeComboBox.Text.Length > 0
                   )
            {
                return true;
            }else
            {
                FormMessage fm = new FormMessage("All fields are required");
                fm.Show(this);
                return false; }
        }
        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            customerIDTextBox.Text = generateCustomerID()+"";
        }
        public int getrProfilesCount()
        {
            int count = 0;
            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //Get CustomerID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblProfile", conn);
            try
            {
                conn.Open();
                count = (Int32)cmd.ExecuteScalar();
                conn.Close();
            }
            catch 
            {
            }
            return count;
        }
        private void insertRecord()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    errOccured = false;
                    string query = "INSERT INTO tblCustomers VALUES(@CustomerID, @Name, @Gender, @Phone, @IdNumber, @IdType, @Address)";
                    da.InsertCommand = new SqlCommand(query, conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@CustomerID", mCustomerID);
                    da.InsertCommand.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    da.InsertCommand.Parameters.AddWithValue("@Gender", genderComboBox.SelectedItem.ToString());
                    da.InsertCommand.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
                    da.InsertCommand.Parameters.AddWithValue("@IdNumber", idNumberTextBox.Text);
                    da.InsertCommand.Parameters.AddWithValue("@IdType", idTypeComboBox.SelectedItem.ToString());
                    da.InsertCommand.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    int id = Convert.ToInt32(da.InsertCommand.ExecuteScalar());

                    DateTime todayDate = DateTime.Now.Date;
                    string date = todayDate.ToString("yyyy-MM-dd");
                    string query2 = "INSERT INTO tblAccount VALUES(@AccID, @AccNumber, @CustomerID, @Status, @DateCreated)";
                    da.InsertCommand = new SqlCommand(query2, conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@AccID", mAccountID);
                    da.InsertCommand.Parameters.AddWithValue("@AccNumber", mCusAccountNumber);
                    da.InsertCommand.Parameters.AddWithValue("@CustomerID", mCustomerID);
                    da.InsertCommand.Parameters.AddWithValue("@Status", "Active");
                    da.InsertCommand.Parameters.AddWithValue("@DateCreated", date);
                    da.InsertCommand.ExecuteNonQuery();


                    string filename = getrProfilesCount() + System.IO.Path.GetFileName(openFileDialog1.FileName);
                    da.InsertCommand = new SqlCommand("insert into tblProfile values('" +filename + "', @CustomerID)", conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@CustomerID", mCustomerID);
                    System.IO.File.Copy(openFileDialog1.FileName,ClassPaths.profileFolder +"\\" + filename);
                    da.InsertCommand.ExecuteNonQuery();

                    /*  string filename = getrProfilesCount() + System.IO.Path.GetFileName(openFileDialog1.FileName);
                      da.InsertCommand = new SqlCommand("insert into tblProfile values('\\Profiles\\" + filename + "', @CustomerID)", conn, transaction);
                      da.InsertCommand.Parameters.AddWithValue("@CustomerID", mCustomerID);
                      string path = "c:\\LoanApp\\Data";
                      System.IO.File.Copy(openFileDialog1.FileName, path + "\\Profiles\\" + filename);
                      da.InsertCommand.ExecuteNonQuery();
  */
                    /** appData dir
                    string filename = getrProfilesCount()+System.IO.Path.GetFileName(openFileDialog1.FileName);
                    da.InsertCommand = new SqlCommand("insert into tblProfile values('\\Profiles\\" + filename + "', @CustomerID)", conn, transaction);
                    da.InsertCommand.Parameters.AddWithValue("@CustomerID", mCustomerID);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Profiles\\" + filename);
                    da.InsertCommand.ExecuteNonQuery();*/



                    // Commit the transaction
                    transaction.Commit();
                    conn.Close();

                    //emptying all fields on success
                    nameTextBox.Text = "";
                    phoneTextBox.Text = "";
                    idNumberTextBox.Text = "";
                    addressTextBox.Text = "";
                    genAccNumTextBox.Text = "";
                    idTypeComboBox.Text = "";
                    genderComboBox.Text = "";

                    formMessage = new FormMessage("Success");
                    formMessage.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    errOccured = true;
                    // Roll back the transaction if an error occurred
                    transaction.Rollback();
                    formMessage = new FormMessage("Error uploading profile. "+ex.Message );
                    formMessage.ShowDialog(this);
                }

            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {    
            if (validateFields() && ValidateChildren(ValidationConstraints.Enabled))
            {
                insertRecord();
                if (!errOccured)
                {
                    this.Close();
                }
                
            }
        }

        private void btnGenAccNum_Click(object sender, EventArgs e)
        {
            genAccNumTextBox.Text = generateAccountNumber()+"";
            generateAccountID();
        }
        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {   
            txtAddressCount.Text = addressTextBox.Text.Length.ToString() + "/30"; 
        }
        void validateFormFields(TextBox txtField, string fieldName, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtField.Text))
            {
                e.Cancel = true;
                //txtField.Focus();
                errorProvider1.SetError(txtField, fieldName + " is required!");
                txtField.ForeColor = ThemeColor.ColorRed;
            }
            else if (txtField.Text.Length < 3)
            {
                e.Cancel = true;
                //txtField.Focus();
                errorProvider1.SetError(txtField, fieldName + " is too short" +
                    "!");
                txtField.ForeColor = ThemeColor.ColorRed;

            }else if (fieldName.Equals("Phone Number"))
            {
                try { 
                    Convert.ToInt64(txtField.Text);
                    if (txtField.Text.Length != 10 )
                    {
                        e.Cancel = true;
                        //numPhone.Focus();
                        errorProvider1.SetError(txtField, "Invalid phone number!, Format(024XXXXXXX)");
                        txtField.ForeColor = ThemeColor.ColorRed;

                    }
                    else
                    {
                        e.Cancel = false;
                        txtField.ForeColor = ThemeColor.ColorBlack;
                    }
                }
                catch {
                    // if text was entered
                    txtField.Text = "";
                    errorProvider1.SetError(txtField, "Contact Invalid ");
                    e.Cancel = true;
                }
               
            }
            
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtField, "");
                txtField.ForeColor = ThemeColor.ColorBlack;
            }
        }
       
        private void nameTextBox_Validating_1(object sender, CancelEventArgs e)
        {
            validateFormFields(nameTextBox, "Name", e);
        }

        private void idNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateFormFields(idNumberTextBox, "ID Number", e);
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateFormFields(phoneTextBox, "Phone Number", e);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        txtPath.Text = path;
                        pbProfile.Image = new Bitmap(openFileDialog1.FileName);
                        pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }

        }
    }
}
