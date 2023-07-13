using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using XpressLoan.Classes;
using XpressLoan.Forms;

namespace XpressLoan
{  
    public partial class ParentForm : Form
    {
        //Initialize forms
        FormHome formHome = new FormHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormLoans formLoans = new FormLoans() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormRepayments formRepayments = new FormRepayments() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormCustomers formCustomers = new FormCustomers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FormReports formReports = new FormReports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //FormSettings formSettings = new FormSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        private Button currentButton;
        private Form activeForm;

        private classActivator classActivator;

        //Constructor
        public ParentForm()
        {
            InitializeComponent();
            //Default Form to open
            CreateChildFormView(btnHome, formHome, "Home");

            formBorderSettings();

            //checkActivation();

            isSystemDateSet();
            lblUsername.Text = getUsername();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        private void isSystemDateSet()
        {
            DateTime dateNow = DateTime.Now.Date;
            string dateToday = dateNow.ToString("MM-yyyy");
            DateTime recentDate = Convert.ToDateTime(dateToday);
            DateTime pivDate = Convert.ToDateTime("02-2023");
            if (recentDate < pivDate)
            {
                FormSystemDate fs = new FormSystemDate();
                fs.ShowDialog(this);
                Application.Exit();
            }
        }
        public string getUsername()
        {
            string username ="";
            
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Username FROM tblUsers", conn);
                    cmd.Parameters.AddWithValue("@Status", "PAID");
                    sqlDataReader = cmd.ExecuteReader();
                    
                    if (sqlDataReader.Read())
                    {
                        username = sqlDataReader["Username"].ToString();
                    }
                  
                    sqlDataReader.Close();
                    conn.Close();
                }

            }
            catch (Exception exception)
            { MessageBox.Show("Error occured" + exception.ToString()); }
            return username;
        }
        public void getActivationStatusDB()
        {
            Console.WriteLine("inside getActivationStatusDB()");
            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //Get CustomerID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tblActivation WHERE ID=1", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    this.classActivator = new classActivator(dr["TempAct"].ToString(), 
                                                        dr["FirstAct"].ToString(), 
                                                        dr["SecondAct"].ToString(),
                                                        dr["ThirdAct"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured" + exception.Message);
            }
        }
        private void checkActivation()
        {
            Console.WriteLine("inside checkActivation()");
            getActivationStatusDB();

            DateTime dateNow = DateTime.Now.Date;
            string dateToday = dateNow.ToString("MM-yyyy");
            DateTime recentDate = Convert.ToDateTime(dateToday);

            DateTime firstActivationDate = Convert.ToDateTime("04-2023");
           
            if(recentDate > firstActivationDate  && classActivator.firstAct == "False")
            {
                Console.WriteLine("inside 1");
                ActivationForm actForm = new ActivationForm();
                actForm.ShowDialog(this);
                checkActivation();
            }
        }
        private void formBorderSettings() {
            //this.Text = string.Empty; //uncomment to hide form border text
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Hide title bar
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        }
        
        private void CreateChildFormView(Button activatedButton, Form childForm, String titleText)
        {
            panelCurrentButton.Height = activatedButton.Height;
            panelCurrentButton.Top = activatedButton.Top;
            panelCurrentButton.Left = activatedButton.Left;
            highlightActiveButton(activatedButton);
            //panelTitleBar.BackColor = Color.FromArgb(0, 204, 255);
            lblTitle.Text = titleText;
            this.PanelChildForms.Controls.Clear();
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.PanelChildForms.Controls.Add(childForm);
            childForm.Show();
        }
        private void highlightActiveButton(Button activeButton)
        {
            //Disactivate other buttons
            DisableButtons();
            //Activate current button
            activeButton.BackColor = ThemeColor.PrimaryColorsActive; ;
            //activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void DisableButtons()
        {
            foreach (Control previousBtn in panelSidePane.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ThemeColor.PrimaryColor;
                    previousBtn.ForeColor = System.Drawing.SystemColors.Control;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //btnLogout.BackColor = Color.Red;
                }
            }
        }
        
        //End    
             
        private void btnHome_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            
            //OpenChildForm(new Forms.FormHome(), sender);
            CreateChildFormView(btnHome, formHome, "Home");

        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            CreateChildFormView(btnLoans, formLoans, "Loans");
        }

        private void btnRepayments_Click(object sender, EventArgs e)
        {
            CreateChildFormView(btnRepayments, formRepayments, "Repayments");

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CreateChildFormView(btnCustomers, formCustomers, "Customers");

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            CreateChildFormView(btnReports, formReports, "Reports");

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CreateChildFormView(btnSettings, formSettings, "Settings");

        }        

        private void btnMaxRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseMain_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Panel drag and drop functionality
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            /*FormAlerts dialog = new FormAlerts();
           dialog.ShowDialog(this);*/
            FormAlerts alertDialog = new FormAlerts();
            alertDialog.ShowDialog("Confirm logout");
            if (alertDialog.DialogResult == DialogResult.OK)
            {
                // Perform the action
                // Clear the user's session data
                //ClearSessionData();

                // Reset the application state
                //ResetApplicationState();

                // Navigate to the login screen
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                // Perform the delete operation here
            }
            else
            {
                // Cancel the action
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FormCalculator formCalculator = new FormCalculator();
            formCalculator.ShowDialog(this);
           
        }
        //All updates made to Database
        private void updateDataBaseStructure()
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                try
                {
                    conn.Open();
                    var query = "If not exists (select name from sysobjects where name = 'tblUpdates') CREATE TABLE tblUpdates(ID int,Type Varchar(50),Status int),Date datetime)";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception eq)
                {
                    
                }
            }
        }
    }

    
}
