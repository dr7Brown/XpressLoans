using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpressLoan.Forms
{
    public partial class FormMessage : Form
    {
        public FormMessage(string message)
        {
            InitializeComponent();
            txtMessage.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            //set size of form to max len of msg
            //and min 200
            //this.Size = new Size(420, 200);
        }
    }
}
