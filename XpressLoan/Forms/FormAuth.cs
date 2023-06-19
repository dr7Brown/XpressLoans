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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }
        private bool ValidateCredentials(string password)
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
        private void btnAuth_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length > 0 ) {
                ClassAuth.isValidated =  ValidateCredentials(txtPassword.Text);
                this.Close();
            }
        }
    }
}
