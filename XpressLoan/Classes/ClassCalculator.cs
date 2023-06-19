using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XpressLoan
{
    internal class ClassCalculator
    {

        public int Amount { get; set; } = 0;
        public double Rate { get; set; } = 0;
        public int Duration { get; set; } = 0;
        public string Terms { get; set; } = "";
    


        public double CalculateInterest()
        {
            /*
            int years = 0;
            //Interest is billed yearly
            if (Duration <= 12)
            {
                years = 1;
            }
            else if (Duration <= 24)
            {
                years = 2;
            }
            else if (Duration <= 36)
            {
                years = 3;
            }
            else if (Duration <= 48)
            {
                years = 4;
            }
            else if (Duration <= 60)
            {
                years = 5;
            }
            else if (Duration <= 72)
            {
                years = 6;
            }

            double interest = (this.Amount * years * this.Rate) / 100;
            */
            double interest = (this.Amount * this.Duration * this.Rate) / 100;

            return interest;
        }

        //Get the number of installments to be made for loan completion
        public int getNumberOfRepayments()
        {
            double repayments = 0.0;
            int numOfTimesRepay = 0;

            switch (Terms)
            {
                case "WEEKLY":
                    numOfTimesRepay = Duration * 4;
                    repayments = getTotalRepayment() / numOfTimesRepay;
                    break;
                case "BI-WEEKLY":
                    numOfTimesRepay = Duration * 2;
                    repayments = getTotalRepayment() / numOfTimesRepay;
                    break;
                case "MONTHLY":
                    numOfTimesRepay = Duration * 1;
                    repayments = getTotalRepayment() / numOfTimesRepay;
                    break;

            }

            return numOfTimesRepay;
        }

        //Get the amount of installments to be made for loan completion
        public double getInstalledRepaymentsAmount()
        {
            double repayments = 0.0;
            int numOfTimesRepay = 0;

            switch (Terms)
            {
                case "WEEKLY":
                    numOfTimesRepay = Duration * 4;
                    repayments = getTotalRepayment() / numOfTimesRepay;
                    break;
                case "BI-WEEKLY":
                    numOfTimesRepay = Duration * 2;
                    repayments = getTotalRepayment() / numOfTimesRepay;
                    break;
                case "MONTHLY":
                    numOfTimesRepay = Duration * 1;
                    repayments = getTotalRepayment() / numOfTimesRepay;
                    break;

            }

            return repayments;
        }

        public double getTotalRepayment()
        {
            return CalculateInterest() + Amount;

        }
    }
    

}
