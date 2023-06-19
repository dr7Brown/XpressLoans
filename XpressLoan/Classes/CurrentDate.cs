using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpressLoan.Classes
{
    internal class CurrentDate
    {
        //convert from string
        DateTime recentDate;
        bool isWeekDaySet = false;

        public CurrentDate() //initialize when selected item changed
        {
            DateTime dateNow = DateTime.Now.Date;
            string date_long = dateNow.ToString("yyyy-MM-dd");
            recentDate = Convert.ToDateTime(date_long);
            this.day = recentDate.ToString("yyyy'-'MM'-'dd");
        }

        public string day { get; set; } = "";

        public string startDayOfWeek { get; set; } = "";
        public string endDayOfWeek { get; set; } = "";

        public string monthDate_long { get; set; } = ""; //yyyy-MM-dd
        public string monthDate_short { get; set; } = ""; //MMM, yyyy
        public string monthDate_db { get; set; } = "";   //yyyy-MM

        public string year { get; set; } = "";
        /*
         * 
         * Day mehthods
         */
        public void setDay()
        {
            this.day = recentDate.ToString("yyyy'-'MM'-'dd");
        }
        public void setNextDay()
        {
            recentDate = recentDate.AddDays(1);
            this.day = recentDate.ToString("yyyy'-'MM'-'dd");
        }
        public void setPrevDay()
        {
            recentDate = recentDate.AddDays(-1);
            this.day = recentDate.ToString("yyyy'-'MM'-'dd");
        }

        /*
         * 
         * Weekly mehthods
         */
        public void setWeek()
        {
            setStartDayOfWeek();
            setEndDayOfWeek();
        }
        public void setStartDayOfWeek() //Monday
        {
            try
            {

                isWeekDaySet = true;
                int day = 0;
                DateTime temp = recentDate;
                while (recentDate.DayOfWeek != DayOfWeek.Monday)
                {
                    day--;
                    Console.WriteLine(day + "Day of week:" + recentDate.DayOfWeek + "DayOfWeek.Monday" + DayOfWeek.Monday);
                    recentDate = temp.AddDays(day); //EROR
                }
                this.startDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
        public void setEndDayOfWeek() //Sunday
        {
            int day = 0;
            DateTime temp = recentDate;
            while (recentDate.DayOfWeek != DayOfWeek.Sunday)
            {
                day++;
                recentDate = temp.AddDays(day);

            }
            this.endDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");
        }
        public void setNextWeek()
        {
            if (isWeekDaySet)
            {
                recentDate = recentDate.AddDays(1);
                this.startDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");
                recentDate = recentDate.AddDays(6);
                this.endDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");
            }
            else
            {
                setStartDayOfWeek();
                setEndDayOfWeek();
                recentDate = recentDate.AddDays(1);
                this.startDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");
                recentDate = recentDate.AddDays(6);
                this.endDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");

            }
        }
        public void setPrevWeek()
        {

            DateTime temp = recentDate;

            if (isWeekDaySet)
            {
                recentDate = recentDate.AddDays(-7);
                this.endDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");
                temp = recentDate.AddDays(-6);
                this.startDayOfWeek = temp.ToString("yyyy'-'MM'-'dd");
            }
            else
            {
                setStartDayOfWeek();
                setEndDayOfWeek();
                recentDate = recentDate.AddDays(-7);
                this.endDayOfWeek = recentDate.ToString("yyyy'-'MM'-'dd");
                temp = recentDate.AddDays(-6);
                this.startDayOfWeek = temp.ToString("yyyy'-'MM'-'dd");
            }
        }
        /*
        * 
        * Monthly mehthods
        */
        public void setMonth()
        {
            monthDate_long = recentDate.ToString("yyyy'-'MM'-'dd");
            monthDate_short = recentDate.ToString("MMMM, yyyy");
            monthDate_db = recentDate.ToString("yyyy-MM");
        }
        public void setNextMonth()
        {
            recentDate = recentDate.AddMonths(1);
            monthDate_long = recentDate.ToString("yyyy'-'MM'-'dd");
            monthDate_short = recentDate.ToString("MMMM, yyyy");
            monthDate_db = recentDate.ToString("yyyy-MM");
        }
        public void setPrevMonth()
        {
            recentDate = recentDate.AddMonths(-1);
            monthDate_long = recentDate.ToString("yyyy'-'MM'-'dd");
            monthDate_short = recentDate.ToString("MMMM, yyyy");
            monthDate_db = recentDate.ToString("yyyy-MM");
        }

        /*
        * 
        * Year mehthods
        */
        public void setYear()
        {
            this.year = recentDate.ToString("yyyy");
        }
        public void setNextYear()
        {
            recentDate = recentDate.AddYears(1);
            this.year = recentDate.ToString("yyyy");
        }
        public void setPrevYear()
        {
            recentDate = recentDate.AddYears(-1);
            this.year = recentDate.ToString("yyyy");
        }
    }
}
