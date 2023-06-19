using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using XpressLoan.Classes;
using XpressLoan.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace XpressLoan
{
    public partial class SignupForm : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        String constr;
        FormMessage fm;
        string name = "";
        string password = "";
        string password2 = "";
        string username = "";
        string email = "";
        string phone = "";
        string gender = "";
        Color primaryColor = ColorTranslator.FromHtml("#00ccff");
        public SignupForm()
        {
            InitializeComponent();
            RemoveBG();
            constr = ConnString.ConnectionString;
            numPhone.Controls[0].Enabled = false;
            cbxGender.SelectedIndex = 0;
            if (isAdminRegistered())
            {
                //if admin already has acc, nav to login
                LoginForm lf = new LoginForm();
                lf.ShowDialog(this);
                this.Close();

            }
        }
        private void RemoveBG()
        {
            //Components to set primary backgroud color
            //labels
            lblConfirmPassword.BackColor = primaryColor;
            lblemail.BackColor = primaryColor;
            lblgender.BackColor = primaryColor;
            lblname.BackColor = primaryColor;
            lblphone.BackColor = primaryColor;
            lblpwd.BackColor = primaryColor;
            lblusername.BackColor = primaryColor;
            lbl_userreg.BackColor = primaryColor;

            //icons
            pbAccount.BackColor = primaryColor;
            pbEmail.BackColor = primaryColor;
            pbGender.BackColor = primaryColor;
            pbPhone.BackColor = primaryColor;
            pbPwd.BackColor = primaryColor;
            pbUsername.BackColor = primaryColor;
            pbPwdConfirm.BackColor = primaryColor;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Navigate to the signup screen
            LoginForm loginForm  = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        bool validateFields()
        {
            if (cbxGender.Text.Length > 0 &&
                txtPassword.Text.Length > 0 &&
                txtUsername.Text.Length > 0 &&
                txtEmail.Text.Length > 0 &&
                numPhone.Text.Length > 0 &&
                txtPasswordConfirm.Text.Length > 0 &&
                txtName.Text.Length > 0)
            {
                
                name = txtName.Text;
                password = txtPassword.Text;
                password2 = txtPasswordConfirm.Text;
                username = txtUsername.Text;
                email = txtEmail.Text;
                phone = numPhone.Text;
                gender = cbxGender.Text;
                if (password.Equals(password2))
                    return true;
                else
                {
                    fm = new FormMessage("Password Mismatch");
                    fm.ShowDialog(this);
                    return false;
                }
            }
            else return false;
        }
        private bool isAdminRegistered()
        {
            bool isValid = false;
            // Validate the user's credentials against a database or other authentication mechanism
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers ", conn);

                    sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                    sqlDataReader.Close();
                    conn.Close();
                }
            }
            catch (Exception exception)
            {}

            return isValid;
        }
        private void showProgressBar()
        {
            // Show the spinner
            //circularProgressBar1.Visible = true;
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
        private async Task CreateAccount()
        {
            // Show the spinner
            progressBar1.Visible = true;
            showProgressBar();

            try
            {
                // Validate the user's credentials
                if (validateFields())
                {
                    //insert record to db
                    insertDB();
                    // Navigate to the login page.
                    LoginForm lf = new LoginForm();
                    lf.ShowDialog();
                    this.Dispose();
                    //this.Close();


                }
                else
                {
                    FormMessage fm = new FormMessage("Invalid field values");
                    fm.ShowDialog(this);

                }
                // Perform the async operation
                //var data = await GetDataAsync();

                // Process the data
                //ProcessData(data);
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred: "+ ex.ToString());
            }
            finally
            {
                // Hide the spinner
                progressBar1.Visible = false;
            }
        }
        public void insertDB()
        {
            string status = "";
            if (isAdminRegistered())
            {
                fm = new FormMessage("Only One Account is allowed! ");
                fm.ShowDialog(this);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    try
                    {


                        string query = "INSERT INTO tblUsers VALUES(@Name, @Phone, @Gender, @Email, @Username, @Passwrod, @ApprovalStatus)";
                        da.InsertCommand = new SqlCommand(query, conn);
                        da.InsertCommand.Parameters.AddWithValue("@Name", name);
                        da.InsertCommand.Parameters.AddWithValue("@Phone", phone);
                        da.InsertCommand.Parameters.AddWithValue("@Gender", cbxGender.SelectedItem.ToString());
                        da.InsertCommand.Parameters.AddWithValue("@Email", email);
                        da.InsertCommand.Parameters.AddWithValue("@Username", username);
                        da.InsertCommand.Parameters.AddWithValue("@Passwrod", password);
                        da.InsertCommand.Parameters.AddWithValue("@ApprovalStatus", "APPROVED");
                        da.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        // Roll back the transaction if an error occurred
                        fm = new FormMessage("Error Writing to DB! ");
                        fm.ShowDialog(this);
                    }

                }

            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                CreateAccount();
            }
        }
        void validateFormFields(TextBox txtField, string fieldName, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtField.Text))
            {
                e.Cancel = true;
                //txtField.Focus();
                errorProvider1.SetError(txtField, fieldName +" is required!");
                txtField.ForeColor = ThemeColor.ColorRed;
            }
            else if (txtField.Text.Length < 4)
            {
                e.Cancel = true;
                //txtField.Focus();
                errorProvider1.SetError(txtField, fieldName + " is too short" +
                    "!");
                txtField.ForeColor = ThemeColor.ColorRed;

            }else if (fieldName.Equals("Email")){
                string str = txtField.Text;
                str = str.Replace(" ", "");
                str = str.Trim();
                str = str.ToLower();
                txtField.Text = str;
                if (!Regex.IsMatch(str, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    e.Cancel = true;
                    //txtField.Focus();
                    errorProvider1.SetError(txtField, fieldName + " wrong format");
                    txtField.ForeColor = ThemeColor.ColorRed;
                }
                else
                {
                    
                }
            }
            else if (fieldName.Equals("Password2"))
            {
                if (!txtPassword.Text.Equals(txtPasswordConfirm.Text))
                {
                    e.Cancel = true;
                    //txtField.Focus();
                    errorProvider1.SetError(txtField, fieldName + " Password mismatch");
                    txtField.ForeColor = ThemeColor.ColorRed;
                }
            }
           /* else if (fieldName.Equals("Phone Number"))
            {
                try
                {
                    Convert.ToInt64(txtField.Text);
                    if (txtField.Text.Length < 12 || txtField.Text.Length > 13)
                    {
                        e.Cancel = true;
                        //numPhone.Focus();
                        errorProvider1.SetError(txtField, "Invalid phone number!, Format(233 024XXXXXXX)");
                        txtField.ForeColor = ThemeColor.ColorRed;

                    }
                }
                catch
                {
                    // if text was entered
                    txtField.Text = "";
                    errorProvider1.SetError(txtField, "Contact Invalid ");
                    e.Cancel = true;
                }

            }*/
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtField, "");
                txtField.ForeColor = ThemeColor.ColorBlack;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            validateFormFields(txtName, "Full name", e);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            validateFormFields(txtUsername, "Username", e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            validateFormFields(txtEmail, "Email", e);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            validateFormFields(txtPassword, "Password", e);
        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            validateFormFields(txtPasswordConfirm, "Password2", e);
        }

        private void numPhone_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(numPhone.Text))
            {
                e.Cancel = true;
                //numPhone.Focus();


                errorProvider1.SetError(numPhone, "Phone is required!");
                numPhone.ForeColor = ThemeColor.ColorRed;
            }
            else if (numPhone.Text.Length < 12 || numPhone.Text.Length > 13)
            {
                e.Cancel = true;
                //numPhone.Focus();
                errorProvider1.SetError(numPhone, "Invalid phone number!, Format(233 024xxxxxxxxx)");
                numPhone.ForeColor = ThemeColor.ColorRed;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numPhone, "");
                numPhone.ForeColor = ThemeColor.ColorBlack;
            }
        }
    }
}
