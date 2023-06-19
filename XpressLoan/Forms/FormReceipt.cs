using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpressLoan.Classes;

namespace XpressLoan.Forms
{
    public partial class FormReceipt : MetroFramework.Forms.MetroForm
    {
        public FormReceipt()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Print doc
        }
        private void loadLogoData()
        {
            ClassHeader classHeader = new ClassHeader();
            lblContact1.Text = classHeader.contact1;
            lblContact2.Text = classHeader.contact2;
            lblEmail.Text = classHeader.email;
        }

      

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            loadLogoData();



        }
    }
}
