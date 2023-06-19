using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpressLoan.Forms
{
    public partial class FormAlerts : Form
    {
        public FormAlerts()
        {
            InitializeComponent();
        }
        public void ShowDialog(string message)
        {
            lblAlertMessage.Text = message;
            this.ShowDialog();
        }
    }
}
