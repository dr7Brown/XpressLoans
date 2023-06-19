using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpressLoan.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace XpressLoan.Forms
{
    public partial class FormsStatement : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();


        private List<ScheduleDetails> StmtList = new List<ScheduleDetails>();
        int lineNum = 0;

        private int itemCount = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
       /* int i = 0;
        private int _Line = 0;
        int yPos = 295;*/

        int loanId = 0;
        string customerName;
        /*        double loanAmount;
                string repaymentTerms; 
                string dateApplied;
                string dateDued;
                int duration;*/

        double paidAmount;
        double remainingBalance;

        public FormsStatement(int loanID, string name)
        {
           


            this.customerName = name;
            this.loanId = loanID;
            InitializeComponent();
            loadLogoData();
            fillDG_Repayments(loanID);
            getLoanDetails(loanId);
            getStatementData(loanId);
        }
        private void loadLogoData()
        {
            ClassHeader classHeader = new ClassHeader();
            lblContact1.Text = classHeader.contact1;
            lblContact2.Text = classHeader.contact2;
            lblEmail.Text = classHeader.email;
        }

        public void getLoanDetails(int loanId)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Amount, Terms, FirstRepDate, Duration, Status FROM tblLoans WHERE LoanID LIKE @loanId", conn);
                    cmd.Parameters.AddWithValue("@loanId", loanId);
                    sqlDataReader = cmd.ExecuteReader();
                    /*while (sqlDataReader.HasRows)
                    {*/
                    if (sqlDataReader.HasRows) {
                        sqlDataReader.Read();
                        lblAmount.Text = sqlDataReader["Amount"].ToString();
                        lblTerms.Text = sqlDataReader["Terms"].ToString();
                        lblStartDate.Text = sqlDataReader["FirstRepDate"].ToString();
                        lblDuration.Text = sqlDataReader["Duration"].ToString() + " Months";
                        String status = sqlDataReader["Status"].ToString();

                        DateTime todayDate = DateTime.Now.Date;
                        string date = todayDate.ToString("yyyy-MM-dd");
                        lblDate.Text = date;

                        if (!status.Equals("APPROVED"))
                        {

                            //hide contents and show message
                            p1.Show(); p2.Show(); p3.Show();
                        }
                        else { p1.Hide(); p2.Hide(); p3.Hide(); }
                    }
                    else
                    {

                    }
                    sqlDataReader.Close();
                    conn.Close();
                }
                lblName.Text = Name;
                lblLoanID.Text = loanId + "";
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading Statement" + exception.ToString()); }
        }
        public void fillDG_Repayments(int loanId)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                //Connection string is assigned to the instance of sql connection.
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    da.SelectCommand = new SqlCommand("SELECT RepaymentID 'ID', RepaymentDate 'Repayment Date', Amount, Status, PaidDate 'Date Paid' FROM tblRepayment WHERE LoanID LIKE @loanId", conn);
                    da.SelectCommand.Parameters.AddWithValue("@loanId", loanId);
                    ds.Reset();
                    da.Fill(ds);
                    statementDGView.DataSource = ds.Tables[0];
                }
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading data"); }
        }
        public void getStatementData(int loanId)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                //Connection string is assigned to the instance of sql connection.
                using (SqlConnection conn = new SqlConnection(ConnString.ConnectionString))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand SelectCommand = new SqlCommand("SELECT RepaymentID, RepaymentDate , Amount, Status, PaidDate FROM tblRepayment WHERE LoanID LIKE @loanId", conn);
                    SelectCommand.Parameters.AddWithValue("@loanId", loanId);
                    sqlDataReader = SelectCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                       StmtList.Add(new ScheduleDetails(sqlDataReader["RepaymentID"].ToString(),
                                                sqlDataReader["RepaymentDate"].ToString(),
                                                sqlDataReader["Amount"].ToString(),
                                                sqlDataReader["Status"].ToString(),
                                                sqlDataReader["PaidDate"].ToString()));

                       
                    }
                    sqlDataReader.Close();
                    conn.Close();
                }
            }
            catch (Exception exception)
            { MessageBox.Show("Error Loading data into array"+exception.ToString());}
        }
        Bitmap bmp;
        private void printBtn_Click(object sender, EventArgs e)
        {
            lineNum = 0;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = pd;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Logo
            Image image = Properties.Resources.xpress_logo;
            e.Graphics.DrawImage(image, 10, 5, 100, 100);
            Pen pen = new Pen(Color.FromKnownColor(KnownColor.Blue), 2);
            e.Graphics.DrawRectangle(pen, 10, 5, 800, 100);
            ClassHeader classHeader = new ClassHeader();
            e.Graphics.DrawString("Express Loans Ltd", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(120, 15));
            e.Graphics.DrawString("Contact1: " + classHeader.contact1, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 49));
            e.Graphics.DrawString("Contact2: " + classHeader.contact2, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(475, 49));
            e.Graphics.DrawString("Email: " + classHeader.email, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 78));

            //Header 
            e.Graphics.DrawString("Name: " + lblName.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 120));
            e.Graphics.DrawString("Loan ID: " + lblLoanID.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 150));
            e.Graphics.DrawString("Amount: " + lblAmount.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Terms: " + lblTerms.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 210));
            e.Graphics.DrawString("Start Date: " + lblStartDate.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 120));
            e.Graphics.DrawString("Duration: " + lblDuration.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 150));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd-MM-yyyy"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 210));



            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("ID", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(30, 255));
            e.Graphics.DrawString("Date ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 255));
            e.Graphics.DrawString("Amount ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(300, 255));
            e.Graphics.DrawString("Status ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(450, 255));
            e.Graphics.DrawString("Date Paid" , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 255));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));



            Font myFont = new Font("m_svoboda", 14, FontStyle.Underline, GraphicsUnit.Point);

            float lineHeight = myFont.GetHeight(e.Graphics) + 4;

            float yLineTop = e.MarginBounds.Top +200;

            
            for (; lineNum < StmtList.Count; lineNum++)
            {
                if (yLineTop + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                e.Graphics.DrawString(StmtList[lineNum].repID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(30, yLineTop));
                e.Graphics.DrawString(StmtList[lineNum].repDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(150, yLineTop));
                e.Graphics.DrawString(StmtList[lineNum].amount, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(300, yLineTop));
                e.Graphics.DrawString(StmtList[lineNum].status, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(450, yLineTop));
                e.Graphics.DrawString(StmtList[lineNum].paidDate, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(600, yLineTop));

                

                yLineTop += lineHeight;
            }

            e.HasMorePages = false; 
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;

            //Print on last page buttom
            e.Graphics.DrawString("The Manager ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 1040));

            e.Graphics.DrawString("---------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 1060));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            lineNum = 0;
            printPreviewDialog1.ShowDialog();
            /*PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            //items = GetEnumerator();
            
                pd.Print();*/

        }
    }
}
