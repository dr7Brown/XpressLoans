using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using XpressLoan.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace XpressLoan.Forms
{
    public partial class FormSettings : Form //MetroFramework.Forms.MetroForm
    {
        SqlDataAdapter da = new SqlDataAdapter();
        bool isLogoSet = false;
        //bool isAuth = false;
        //public static bool isValidated = false;
        public FormSettings()
        {
            InitializeComponent();
            fillFields();
        }
        public void fillFields()
        {
            String constr = ConnString.ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //Get CustomerID for the last Customer   SELECT TOP 1 * FROM table ORDER    BY Id DESC;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tblLogo WHERE ID=1", conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    isLogoSet = true;
                    dr.Read();
                    txtName.Text = Convert.ToString(dr["CoName"]);
                    txtContact1.Text = Convert.ToString(dr["Contact1"]);
                    txtContact2.Text = Convert.ToString(dr["Contact2"]);
                    txtEmail.Text = dr["Email"].ToString();
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured"+exception.Message);
            }
        }
        private void updateRecords()
        {
            // Show the spinner
            txtSuccess.Visible = false;
            txtSuccess.Text = "";
            string err = "";
            if (txtName.Text.Trim() == string.Empty)
            {
                txtName.Focus();
                err = "Company name is required";
                txtError.Visible = true;
                txtError.Text = err;
                return;
            }
            else if (txtContact1.Text.Trim() == string.Empty)
            {
                txtContact1.Focus();
                err = "Contact1 is required";
                txtError.Visible = true;
                txtError.Text = err;
                return;
            }
            else if (txtContact2.Text.Trim() == string.Empty)
            {
                txtContact2.Focus();

                err = "Contact2 is required";
                txtError.Visible = true;
                txtError.Text = err;
                return;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                txtEmail.Focus();
                err = "Email is required";
                txtError.Visible = true;
                txtError.Text = err;
                return;
            }
            else
                try
                {
                    err = "";
                    txtError.Visible = false;
                    txtError.Text = err;

                    progressBar1.Visible = true;
                    //update DB     
                    updateSettings(txtName.Text, txtContact1.Text, txtContact2.Text, txtEmail.Text, 1);

                    showProgressBar(progressBar1);
                    txtSuccess.Visible = true;
                    txtSuccess.Text = "Saved !";
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    txtError.Visible = true;
                    txtError.Text = "Error occured";
                    MessageBox.Show("Errors");

                }
                finally
                {
                    txtError.Visible = false;
                    txtError.Text = "";
                    // Hide the spinner
                    progressBar1.Visible = false;
                   txtSuccess.Visible = false;
                    txtSuccess.Text = "";

                    Thread.Sleep(10);
                    txtSuccess.Visible = false;

                }
        }
        void updateSettings(String coName, string contact1, string contact2, string email, int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                try
                {
                    if(!isLogoSet)
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        string query = "INSERT INTO tblLogo VALUES(@ID,@CoName, @Contact1, @Contact2, @Email)";
                        da.InsertCommand = new SqlCommand(query, conn);
                        da.InsertCommand.Parameters.AddWithValue("@ID", id);
                        da.InsertCommand.Parameters.AddWithValue("@CoName", coName);
                        da.InsertCommand.Parameters.AddWithValue("@Contact1", contact1);
                        da.InsertCommand.Parameters.AddWithValue("@Contact2", contact2);
                        da.InsertCommand.Parameters.AddWithValue("@Email", email);
                        da.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                    }
                    else
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        string query = "UPDATE tblLogo SET CoName=@CoName, Contact1=@Contact1 , Contact2=@Contact2, Email=@Email WHERE ID=@ID";
                        da.UpdateCommand = new SqlCommand(query, conn);
                        da.UpdateCommand.Parameters.AddWithValue("@CoName", coName);
                        da.UpdateCommand.Parameters.AddWithValue("@Contact1", contact1);
                        da.UpdateCommand.Parameters.AddWithValue("@Contact2", contact2);
                        da.UpdateCommand.Parameters.AddWithValue("@Email", email);
                        da.UpdateCommand.Parameters.AddWithValue("@ID", id);
                        da.UpdateCommand.ExecuteNonQuery();

                        conn.Close();
                    }

                   
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }
        private void showProgressBar(ProgressBar progressBar)
        {
            // Show the spinner
            //circularProgressBar1.Visible = true;
            for (int i = 0; i < 1; i++) //increase i for the number of spins
            {
                for (int j = 0; j < 100; j++)
                {
                    Thread.Sleep(30);
                    progressBar.Value = j;
                    progressBar.Update();
                }

            }

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            updateRecords();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            string err;
            if (txtName.Text.Trim() == string.Empty)
            {
                txtName.Focus();
                err = "Company name is required";
                txtError.Visible = true;
                txtError.Text = err;
            }
            else
            {
                txtError.Visible = false;
                err = "";
                txtError.Text = err;
            }
        }

        private void txtContact1_Leave(object sender, EventArgs e)
        {
            string err;
            if (txtContact1.Text.Trim() == string.Empty)
            {
                txtContact1.Focus();
                err = "Contact1 is required";
                txtError.Visible = true;
                txtError.Text = err;
            }
            else
            {
                txtError.Visible = false;
                err = "";
                txtError.Text = err;
            }
        }

        private void txtContact2_Leave(object sender, EventArgs e)
        {
            string err;
            if (txtContact2.Text.Trim() == string.Empty)
            {
                txtContact2.Focus();
                err = "Contact2 is required";
                txtError.Visible = true;
                txtError.Text = err;
            }
            else
            {
                txtError.Visible = false;
                err = "";
                txtError.Text = err;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormAlerts alertDialog = new FormAlerts();
            alertDialog.ShowDialog("You are about to delete all system data");
            if (alertDialog.DialogResult == DialogResult.OK)
            {
                PasswordAlertForm ps= new PasswordAlertForm();
                ps.ShowDialog(this);
                //MessageBox.Show("Component Disabled");          
            }
        }
      
       
        private void btnBackup_Click(object sender, EventArgs e)
        {/* 
             * working
             * makeDir();
             using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
             {
                 try
                 {
                     if (conn.State != ConnectionState.Open)
                         conn.Open();
                     string database = conn.Database.ToString();
                     string dbPath = "c:\\LoanApp\\Data\\Backup";
                     string query = "BACKUP DATABASE [" + database + "] TO Disk =N'" + dbPath + "\\" + "Database" + "-" + DateTime.Now.ToString("yyy-MM-dd--HH-mm-ss") + ".bak'";

                     using (SqlCommand command = new SqlCommand(query, conn))
                     {
                         command.ExecuteNonQuery();
                         command.Dispose();
                         MessageBox.Show("The database is successfully backed up", "Backup process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error creating backup"+ex.Message);
                 }
             }*/
            FormAuth formAuth = new FormAuth();
            formAuth.ShowDialog(this);
            if (ClassAuth.isValidated)
            {
                try
                {
                    txtError2.Visible = false;
                    txtSuccess2.Visible = false;
                    progressBar2.Visible = true;
                    ClassPaths.createDatabaseBackupDir(); //create directory inside drive c:
                    System.Data.SqlClient.SqlConnection.ClearAllPools(); //stops sql service.
                    showProgressBar(progressBar2);

                    string sourceFilePath_db = ClassPaths.databaseFolder;
                    sourceFilePath_db = sourceFilePath_db + "\\XpressDB.mdf";
                    var sourceFile_db = new FileInfo(sourceFilePath_db);
                    var timing = DateTime.Now.ToString("yyyMMddHH.mm.ss");
                    string newFileName = "Database-" + timing + ".bak";
                    string targetDirPath_db = ClassPaths.databaseBackupFolder;
                    string destinationFilePath_db = targetDirPath_db + "\\" + newFileName;
                    sourceFile_db.CopyTo(destinationFilePath_db, true);

                    //Copy Log file
                    string sourceFilePath_log = ClassPaths.databaseFolder;
                    sourceFilePath_log = sourceFilePath_log + "\\XpressDB_log.ldf";
                    var sourceFile_log = new FileInfo(sourceFilePath_log);
                    string newfileName_log = "Database_log" + timing + ".bak";
                    string targetDirPath_log = ClassPaths.databaseBackupFolder;
                    string destinationFilePath_log = targetDirPath_log + "\\" + newfileName_log;
                    sourceFile_log.CopyTo(destinationFilePath_log, true);

                    //MessageBox.Show("File copied successfully");
                    txtSuccess2.Text = "Backup Created Successfully !";
                    txtSuccess2.Visible = true;
                    
                }
                catch (IOException ex)
                {
                    txtError2.Visible = true;
                    txtError2.Text = "Error creating backup !"+ex.Message;
                    progressBar2.Visible = false;
                }
                finally
                {
                    //Thread.Sleep(100);
                    //txtSuccess2.Visible = false;
                    progressBar2.Visible = false;
                }
            }
            else { MessageBox.Show("Wrong Credentials entered"); }
          

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            FormAuth formAuth = new FormAuth();
            formAuth.ShowDialog(this);
            if (ClassAuth.isValidated)
            {

                //To where your opendialog box get starting location. My initial directory location is desktop.
                openFileDialog1.InitialDirectory = @"c:\\LoanApp\\Data\\Backup";
                //Your opendialog box title name.
                openFileDialog1.Title = "Select Database to restore";
                //which type file format you want to upload.
                openFileDialog1.Filter = "(*.mdf; *.ldf; *.bak; )|*.mdf; *.ldf; *.bak;";
                //FilterIndex property represents the index of the filter currently selected in the file dialog box.
                openFileDialog1.FilterIndex = 1;
                try
                {
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (openFileDialog1.CheckFileExists)
                        {
                            

                            txtError2.Visible = false;
                            txtSuccess2.Visible = false;
                            progressBar2.Visible = true;
                            ClassPaths.createDatabaseBackupDir(); //create directory inside drive c:
                            System.Data.SqlClient.SqlConnection.ClearAllPools();
                            showProgressBar(progressBar2);

                           

                            string sourceFilePath_db = Path.GetFullPath(openFileDialog1.FileName);
                            txtbMd.Text = openFileDialog1.SafeFileName;
                            txtLog.Text = "Database_log" + openFileDialog1.SafeFileName.Substring(9);
                            string newFileName = "XpressDB.mdf";
                            string targetDirPath = ClassPaths.databaseFolder ;
                            string targetFilePath = System.IO.Path.Combine(targetDirPath+"\\", newFileName);
                            File.Copy(sourceFilePath_db, targetFilePath, true);

                            //Copy Log file
                            string sourceFilePath_log = ClassPaths.databaseBackupFolder + "\\Database_log" + openFileDialog1.SafeFileName.Substring(9);
                            string newfileName_log = "XpressDB_log.ldf";
                            string targetDirPath_log = ClassPaths.databaseFolder;
                            string mTargetFilePath = System.IO.Path.Combine(targetDirPath_log + "\\", newfileName_log);
                            File.Copy(sourceFilePath_log, mTargetFilePath, true);

                            txtSuccess2.Text = "System Restored Successfully !";
                            txtSuccess2.Visible = true;
                        }
                    }
                  

                }
                catch (IOException ex)
                {
                    txtError2.Visible = true;
                    txtError2.Text = "System Restore Failed !";
                    progressBar2.Visible = false;


                }
                finally
                {

                    //Thread.Sleep(100);
                    //txtSuccess2.Visible = false;
                    progressBar2.Visible = false;
                }
            }
            else { MessageBox.Show("Wrong Credentials entered"); }
        }

    }
}
