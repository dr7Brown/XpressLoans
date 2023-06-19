using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpressLoan.Classes
{
    internal class ClassHeader
    {
        //Default Contructor
        public ClassHeader()
        {
            fillLogoFields();

        }
        public void fillLogoFields()
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblLogo WHERE ID=1", conn);
                SqlDataReader dr;
                try
                {
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        this.companyName = Convert.ToString(dr["CoName"]);
                        this.contact1 = Convert.ToString(dr["Contact1"]);
                        this.contact2 = Convert.ToString(dr["Contact2"]);
                        this.email = dr["Email"].ToString();
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error occured" + exception.Message);
                }
            }

        }
        public PictureBox logoPicture { get; set; }
        public double PictureNumber { get; set; }
        public string companyName { get; set; }
        public string contact1 { get; set; }
        public string contact2 { get; set; }
        public string email { get; set; }
    }
}
