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
    public partial class ActivationForm : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();

        //private string[] activationKeys = { " JK45J-8UE1F-KU36E-8FE4F-EUW09", " D8J76-8UE1F-KU36E-8FE4F-EDRW4", " D8J76-0PF1F-KU36E-900RT-EDRW4", "D8J76-77KJ0-KU36E-8FE4F-89FR4" };
        private string key = "JK45J-8UE1F-KU36E-8FE4F-EUW09";
        public ActivationForm()
        {
            InitializeComponent();
        }


        private void btnActivate_Click(object sender, EventArgs e)
        {
            if(txtField.Text.Length > 0 )
            {

                if (txtField.Text.Equals(key)) 
                {
                    updateActivationStatusDB("True");
                    this.Close();
                }
                else
                {
                    txtError.Visible = true;
                    txtError.Text = "Wrong key entered! Contact Brownzip Inc +233248391469 for activation key";
                }
            }
            else
            {
                txtError.Visible = true;
                txtError.Text = "Enter Activation key to register!";
                
            }
        }
        void updateActivationStatusDB(string newValue)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string query = "UPDATE tblActivation SET FirstAct=@ColName WHERE ID=1";
                    da.UpdateCommand = new SqlCommand(query, conn);
                    da.UpdateCommand.Parameters.AddWithValue("@ColName", newValue);
                    da.UpdateCommand.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

    }
}
