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
    public partial class PasswordAlertForm : MetroFramework.Forms.MetroForm
    {
        SqlDataAdapter da = new SqlDataAdapter();
        FormMessage formMessage;
        public PasswordAlertForm()
        {
            InitializeComponent();
        }
        private bool ValidateCredentials( string password)
        {
            bool isValid = false;
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE Password LIKE @password", conn);
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
        private void deleteAllRecords()
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    //Account
                   /* da.DeleteCommand = new SqlCommand("DELETE FROM tblLogo", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();*/

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblSettings", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblExpenses", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblDeposit", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblRepDeposits", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblUsers", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();


                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblRepayment", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblAccount", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblTransactions", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblLoans", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblProfile", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();

                    //Account
                    da.DeleteCommand = new SqlCommand("DELETE FROM tblCustomers", conn, transaction);
                    da.DeleteCommand.ExecuteNonQuery();
                    

           

                    // Commit the transaction
                    transaction.Commit();
                    conn.Close();


                    formMessage = new FormMessage("System reset Successfull");
                    formMessage.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    // Roll back the transaction if an error occurred
                    transaction.Rollback();
                    formMessage = new FormMessage("Error Deleting" + ex.Message);
                    formMessage.ShowDialog(this);
                    return;
                }

            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length>0)
            {
                if (ValidateCredentials(txtPassword.Text))
                {
                    deleteAllRecords();
                }
                else
                {
                    MessageBox.Show("Wrong password entered");
                }
            }
        }
    }
}
