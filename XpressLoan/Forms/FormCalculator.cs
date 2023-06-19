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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
        //empty textfields
        private void emptyTextFields()
        {
            txtAmount.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtDuration.Text = string.Empty;
            cbxTerms.Text = string.Empty;
            lvCalculator.Items.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //validate that text has been entered.
            if (txtAmount.Text.Length > 0
                    && txtRate.Text.Length > 0
                    && txtDuration.Text.Length > 0
                    && cbxTerms.Text.Length > 0)
            {
                ClassCalculator newCalc = new ClassCalculator
                {
                    Amount = Convert.ToInt32(txtAmount.Text.ToString()),
                    Rate = Convert.ToDouble(txtRate.Text.ToString()),
                    Duration = Convert.ToInt32(txtDuration.Text.ToString()),
                    Terms = cbxTerms.SelectedItem.ToString(),

                };

                lvCalculator.Items.Clear();

                String[] space = { " ", " "  };
                String[] amount = { "Amount", "" + newCalc.Amount };
                String[] rate = { "Rate", "" + newCalc.Rate +"%" };
                String[] duration = { "Duration", "" + newCalc.Duration +" Months" };
                String[] terms = { "Terms", "" + newCalc.Terms };
                String[] interest = { "Interest", "" + string.Format("{0:0.00}", newCalc.CalculateInterest())};
                String[] numOfRepayments = { "Times", "" + newCalc.getNumberOfRepayments() };
                String[] instalment = { "Instalment", "" + string.Format("{0:0.00}", newCalc.getInstalledRepaymentsAmount() )};
                String[] totalRepayment = { "Total Repayments", "" + string.Format("{0:0.00}", newCalc.getTotalRepayment() ) };



                var lvSpceRow = new ListViewItem(amount);
                var lvAmtRow = new ListViewItem(amount);
                var lvRateRow = new ListViewItem(rate);
                var lvDurationRow = new ListViewItem(duration);
                var lvTermsRow = new ListViewItem(terms);
                var lvInterestRow = new ListViewItem(interest);
                var lvNumOfRepRow = new ListViewItem(numOfRepayments);
                var lvInstalmentRow = new ListViewItem(instalment);
                var lvTotalRepRow = new ListViewItem(totalRepayment);


                /* lvCalculator.Items.Add(lvAmtRow);
                 
                 
                 lvCalculator.Items.Add(lvTermsRow); */
                lvCalculator.Items.Add(lvSpceRow);
                lvCalculator.Items.Add(lvRateRow);
                lvCalculator.Items.Add(lvDurationRow);
                lvCalculator.Items.Add(lvInterestRow);
                lvCalculator.Items.Add(lvNumOfRepRow);
                lvCalculator.Items.Add(lvInstalmentRow);
                lvCalculator.Items.Add(lvTotalRepRow);

            }
            else
            {
                FormMessage alertDialog = new FormMessage("All Fields are required");
                alertDialog.ShowDialog(this);
            }
        }

            private void btnClear_Click(object sender, EventArgs e)
        {
            emptyTextFields();
        }

        private void btnCloseCalc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
