using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpressLoan.Classes
{
    internal class classActivator
    {
        //activation
        /*public bool isActivatedM { get; set; } = false;
        public bool isActivatedMay { get; set; } = false;
        public bool isActivatedJune { get; set; } = false;
        public bool isActivatedJuly { get; set; } = false;*/

        public string tempAct { get; set; } = "";
        public string firstAct { get; set; } = "";
        public string secondAct { get; set; } = "";
        public string thirdAct { get; set; } = "";

        public classActivator(string tempAct, string firstAct, string secondAct, string thirdAct)
        {
            this.tempAct = tempAct; 
            this.firstAct = firstAct;
            this.secondAct = secondAct;
            this.thirdAct = thirdAct;
        }
    }
}
