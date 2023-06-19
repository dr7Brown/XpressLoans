using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpressLoan.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using XpressLoan.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.InteropServices;
using System.IO;

namespace XpressLoan
{
    public partial class LoginForm : Form
    {
        Color primaryColor = ColorTranslator.FromHtml("#00ccff");
        //Adding Placeholder or hint
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);


        public LoginForm()
        {
            InitializeComponent();
            SendMessage(txtUsername.Handle, EM_SETCUEBANNER, 0, "Enter Username here");
            SendMessage(txtPassword.Handle, EM_SETCUEBANNER, 0, "Enter Password");
            removeBG();
            txtUsername.Text = getUsername();
            if (!isAdminRegistered())
            {
                //if admin already has acc, nav to login
                SignupForm sf = new SignupForm();
                sf.ShowDialog(this);
                this.Close();

            }
        }

        // Set background of selected images to primary color
        private void removeBG()
        {
            pb_account.BackColor = primaryColor;
            pb_pwd.BackColor = primaryColor;
        }
        private string getUsername()
        {
            string username = "";
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
                        sqlDataReader.Read();
                        username = sqlDataReader["Username"].ToString();
                    }
                    sqlDataReader.Close();
                    conn.Close();
                }
            }
            catch (Exception exception)
            { }

            return username;
        }

        private bool ValidateCredentials(string username, string password)
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

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE Username LIKE @username AND Password LIKE @password", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

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
            { MessageBox.Show("Error Reading Credentials" + exception.ToString()); }

            return isValid;
        }

        private void SetSessionData(string username)
        {
            // Set the user's session data
            // For example, you can create an authentication token or set a session cookie to identify the user and their session
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
        bool validateFields()
        {
            if (txtUsername.Text.Length > 0 &&
                txtPassword.Text.Length > 0) return true;
            else
            {
                FormMessage formMessage = new FormMessage("All fields are required");
                formMessage.ShowDialog(this);
                return false;
            }
        }
        private async Task Login(string username, string password)
        {
            // Show the spinner


            try
            {
                if (validateFields())
                {
                    progressBar1.Visible = true;
                    showProgressBar();

                    if (ValidateCredentials(username, password))
                    {
                        // Establish the user's session
                        SetSessionData(username);

                        // Navigate to the main application screen
                        ParentForm parentForm = new ParentForm();
                        parentForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormMessage fm = new FormMessage("Invalid Username or Password");
                        fm.ShowDialog(this);

                    }
                }

            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred: ");
            }
            finally
            {
                // Hide the spinner
                progressBar1.Visible = false;
            }
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
                    //if(sqlDataReader.Read())
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
            { }

            return isValid;
        }

        // In the form that handles the login event, you can call the Login method
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                Login(username, password);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Navigate to the signup screen
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username is required!");
                //txtUsername.BackColor = ThemeColor.ColorRed;
            }
            else if (txtUsername.Text.Length < 3)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username is too short!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password is required!");
            }
            else if (txtPassword.Text.Length < 3)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password is too short!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }
    }
}