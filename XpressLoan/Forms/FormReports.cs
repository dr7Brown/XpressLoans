using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpressLoan.Classes;

namespace XpressLoan.Forms
{
    public partial class FormReports : Form
    {

        SqlDataAdapter da = new SqlDataAdapter();

        FormMessage formMessage;
        int selectedDepositID = 0;
        int selectedExpensesID = 0;
        //List<string> listOfUserID = new List<string>();

        public FormReports()
        {
            InitializeComponent();
            tblDepositDataGridView.Columns[4].FillWeight = 200;
            tblExpensesDataGridView.Columns[2].FillWeight = 200;
        }

        private void tblDepositBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDepositBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.xpressLoanDBDataSet);

        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            /*// TODO: This line of code loads data into the 'xpressLoanDBDataSet.tblExpenses' table. You can move, or remove it, as needed.
            this.tblExpensesTableAdapter.Fill(this.xpressLoanDBDataSet.tblExpenses);
            // TODO: This line of code loads data into the 'xpressLoanDBDataSet.tblDeposit' table. You can move, or remove it, as needed.
            this.tblDepositTableAdapter.Fill(this.xpressLoanDBDataSet.tblDeposit);
*/
            fillDG_Deposit();
            fillDG_Expenses();
        }
        private int getUserID()
        {
            int userID = 0;
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                da.SelectCommand = new SqlCommand("select UserID, Name from tblUsers", conn);
                SqlDataReader dr;
                try
                {
                    dr = da.SelectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        userID = Convert.ToInt32(dr["UserID"]);
                    }

                    //close reader
                    dr.Close();
                    //Close connection
                    conn.Close();
                }
                catch (Exception exception)
                { }
            }
            return userID;
        }
        private void insertDepositRecords(double Amount, string Date, int UserID, string Description)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                try
                {
                    string query = "INSERT INTO tblDeposit VALUES(@Amount, @Date, @UserID, @Description)";
                    da.InsertCommand = new SqlCommand(query, conn);
                    da.InsertCommand.Parameters.AddWithValue("@Amount", Amount);
                    da.InsertCommand.Parameters.AddWithValue("@Date", Date);
                    da.InsertCommand.Parameters.AddWithValue("@UserID", UserID);
                    da.InsertCommand.Parameters.AddWithValue("@Description", Description);
                    da.InsertCommand.ExecuteNonQuery();


                    // Commit the transaction
                    conn.Close();

                    formMessage = new FormMessage("Success");
                    formMessage.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    formMessage = new FormMessage("Error adding deposit " + ex.Message);
                    formMessage.ShowDialog(this);
                    return;
                }

            }
        }
        private void updateDepositRecords(int id, double Amount, string Date, int UserID, string Description)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                try
                {
                    string query = "Update tblDeposit SET Amount=@Amount, Date=@Date, UserID=@UserID, Description=@Description WHERE DepositID =@DepositID";
                    da.UpdateCommand = new SqlCommand(query, conn);
                    da.UpdateCommand.Parameters.AddWithValue("@DepositID", id);
                    da.UpdateCommand.Parameters.AddWithValue("@Amount", Amount);
                    da.UpdateCommand.Parameters.AddWithValue("@Date", Date);
                    da.UpdateCommand.Parameters.AddWithValue("@UserID", UserID);
                    da.UpdateCommand.Parameters.AddWithValue("@Description", Description);
                    da.UpdateCommand.ExecuteNonQuery();

                    // Commit the transaction
                    conn.Close();

                    formMessage = new FormMessage("Record Updated");
                    formMessage.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    formMessage = new FormMessage("Error adding Record " + ex.Message);
                    formMessage.ShowDialog(this);
                    return;
                }

            }
        }
        public void fillDG_Deposit()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    da.SelectCommand = new SqlCommand("SELECT * FROM tblDeposit", conn);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    da.Fill(ds);
                    tblDepositDataGridView.DataSource = ds.Tables[0];
                }
                    
            }
            catch (Exception exception)
            { MessageBox.Show("Failed loading data" + exception.Message); }
        }
        public void fillDG_Expenses()
        {
            try
            {
                //Connection string is assigned to the instance of sql connection.
                //SqlConnection conn = new SqlConnection(ConnString.conString);
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    da.SelectCommand = new SqlCommand("SELECT * FROM tblExpenses", conn);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    da.Fill(ds);
                    tblExpensesDataGridView.DataSource = ds.Tables[0];
                    conn.Close();
                }
                

            }
            catch (Exception exception)
            { MessageBox.Show("Failed" + exception.Message); }
        }

        private void btnSaveDeposit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (btnSaveDeposit.Text.Equals("Save"))
                {
                    insertDepositRecords(Convert.ToDouble(depAmountNumericUpDown.Text), depDateTimePicker.Text, getUserID(), depDescriptionRichTextBox.Text);
                    //
                    /*this.Validate();
                    this.tblDepositBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.xpressLoanDBDataSet);*/
                    //this.tblDepositTableAdapter.Fill(this.xpressLoanDBDataSet.tblDeposit);
                    fillDG_Deposit();
                    depAmountNumericUpDown.Text = "";
                    depDescriptionRichTextBox.Text = "";
                }
                else if(btnSaveDeposit.Text.Equals("Update"))
                {
                    updateDepositRecords(selectedDepositID, Convert.ToDouble(depAmountNumericUpDown.Text), depDateTimePicker.Text, getUserID(), depDescriptionRichTextBox.Text);
                    btnSaveDeposit.Text = "Save";
                    /*this.Validate();
                    this.tblDepositBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.xpressLoanDBDataSet);*/
                    //this.tblDepositTableAdapter.Fill(this.xpressLoanDBDataSet.tblDeposit);
                    fillDG_Deposit();
                    depAmountNumericUpDown.Text = "";
                    depDescriptionRichTextBox.Text = "";
                }        

            }
        }

        private void amountNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(depAmountNumericUpDown.Text))
            {
                e.Cancel = true;
                //amountNumericUpDown.Focus();
                errorProvider1.SetError(depAmountNumericUpDown, "Amount is required!");
                depAmountNumericUpDown.ForeColor = ThemeColor.ColorRed;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(depAmountNumericUpDown, "");
                depAmountNumericUpDown.ForeColor = ThemeColor.ColorBlack;
            }
        }



        private void descriptionRichTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(depDescriptionRichTextBox.Text))
            {
                e.Cancel = true;
                //descriptionRichTextBox.Focus();
                errorProvider1.SetError(depDescriptionRichTextBox, "Amount is required!");
                depDescriptionRichTextBox.ForeColor = ThemeColor.ColorRed;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(depDescriptionRichTextBox, "");
                depDescriptionRichTextBox.ForeColor = ThemeColor.ColorBlack;
            }
        }

        private void insertExpensesRecords(double Amount, string Purpose, string Date, int UserID)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                try
                {
                    string query = "INSERT INTO tblExpenses VALUES(@Amount,  @Purpose, @Date, @UserID)";
                    da.InsertCommand = new SqlCommand(query, conn);
                    da.InsertCommand.Parameters.AddWithValue("@Amount", Amount);
                    da.InsertCommand.Parameters.AddWithValue("@Purpose", Purpose);
                    da.InsertCommand.Parameters.AddWithValue("@Date", Date);
                    da.InsertCommand.Parameters.AddWithValue("@UserID", UserID);
                    da.InsertCommand.ExecuteNonQuery();


                    // Commit the transaction
                    conn.Close();

                    formMessage = new FormMessage("Success");
                    formMessage.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    formMessage = new FormMessage("Error adding deposit " + ex.Message);
                    formMessage.ShowDialog(this);
                    return;
                }

            }
        }
        private void updateExpensesRecords(int id, double Amount, string Date, int UserID, string Purpose)
        {
            using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                try
                {
                    string query = "Update tblExpenses SET Amount=@Amount, Purpose=@Purpose, Date=@Date, UserID=@UserID  WHERE ExpensesID =@ExpensesID";
                    da.UpdateCommand = new SqlCommand(query, conn);
                    da.UpdateCommand.Parameters.AddWithValue("@ExpensesID", id);
                    da.UpdateCommand.Parameters.AddWithValue("@Amount", Amount);
                    da.UpdateCommand.Parameters.AddWithValue("@Purpose", Purpose);
                    da.UpdateCommand.Parameters.AddWithValue("@Date", Date);
                    da.UpdateCommand.Parameters.AddWithValue("@UserID", UserID);
                    da.UpdateCommand.ExecuteNonQuery();

                    // Commit the transaction
                    conn.Close();

                    formMessage = new FormMessage("Record Updated");
                    formMessage.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    formMessage = new FormMessage("Error Updating Record " + ex.Message);
                    formMessage.ShowDialog(this);
                    return;
                }

            }
        }

        private void btnSaveExpenses_Click(object sender, EventArgs e)
        {
            if (expAmountNumericUpDown1.Text.Length > 0 && expPurposeRichTextBox.Text.Length > 0)
            {   

                if (btnSaveExpenses.Text.Equals("Save"))
                {
                    insertExpensesRecords(Convert.ToDouble(expAmountNumericUpDown1.Text), expPurposeRichTextBox.Text, expDatePicker.Text, getUserID());
                    //tblExpensesTableAdapter.Fill(this.xpressLoanDBDataSet.tblExpenses);
                    fillDG_Expenses();
                    expAmountNumericUpDown1.Text = "";
                    expPurposeRichTextBox.Text = ""; 
                }else if (btnSaveExpenses.Text.Equals("Update"))
                {
                    updateExpensesRecords(selectedExpensesID, Convert.ToDouble(expAmountNumericUpDown1.Text), expDatePicker.Text, getUserID(), expPurposeRichTextBox.Text);
                    btnSaveExpenses.Text = "Save";
                    fillDG_Expenses();
                   /* this.tblExpensesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.xpressLoanDBDataSet);
                    tblExpensesTableAdapter.Fill(this.xpressLoanDBDataSet.tblExpenses);*/
                    expAmountNumericUpDown1.Text = "";
                    expPurposeRichTextBox.Text = "";
                }
            }
            else
            {
                formMessage = new FormMessage("All fields are required");
                formMessage.ShowDialog(this);
            }
        }

        private void tblDepositDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    selectedDepositID = Convert.ToInt32(tblDepositDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    btnSaveDeposit.Text = "Update";
                    depositIDTextBox.Text = tblDepositDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    depAmountNumericUpDown.Text = tblDepositDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    depDateTimePicker.Text = tblDepositDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    depDescriptionRichTextBox.Text = tblDepositDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error fetching data" + ex.ToString());
                }

               
            }
        }

        private void tblExpensesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 )
            {
                try
                {
                    selectedExpensesID = Convert.ToInt32(tblExpensesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    btnSaveExpenses.Text = "Update";
                    expensesIDTextBox.Text = tblExpensesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    expAmountNumericUpDown1.Text = tblExpensesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    expDatePicker.Text = tblExpensesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    expPurposeRichTextBox.Text = tblExpensesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();


                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error fetching data" + ex.ToString());
                }


            }
        }
    }
}
