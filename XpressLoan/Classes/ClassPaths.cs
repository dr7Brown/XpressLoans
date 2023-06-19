using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpressLoan.Classes
{
    internal static class ClassPaths
    {

        //public static string databaseFolder { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
        //    "\\Local\\Apps\\2.0\\Data\\7N4VCKKO.DQA\\D2J6MH1X.Y0Z\\xpre..tion_2f17425c9cbd3820_0001.0000_2f3c29da10deb706\\Data";


        /*public static string roamingDir { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\Local\\Apps\\2.0\\Data\\Z8E1QHRG.A2O\\V697RZGD.N7C\\xpre..tion_2f17425c9cbd3820_0002.0003_cf279549897d6232\\Data";
        public static string databaseFolder { get; set; } = roamingDir.Replace("Roaming\\", "");*/


        public static string rootFolder { get; set; } = myAppFolder = Path.Combine(Environment.GetFolderPath
           (Environment.SpecialFolder.CommonApplicationData), "LoanAppData");

        public static string myAppFolder { get; set; } = rootFolder + "\\data";
        public static string profileFolder { get; set; } = rootFolder + "\\profiles";
        public static string databaseFolder { get; set; } = rootFolder + "\\data";
        public static string backupRootFolder { get; set; } = "c:\\LoanApp";
        public static string profileBackupFolder { get; set; } = "c:\\LoanApp\\backup\\profiles";
        public static string databaseBackupFolder { get; set; } = "c:\\LoanApp\\backup\\data";

       // public static bool isValidated { get; set; } = false;
        public static void createAppDir()
        {   //Create db directory
            try
            {
                if (!Directory.Exists(myAppFolder))
                {
                    Directory.CreateDirectory(myAppFolder);
                }
                AppDomain.CurrentDomain.SetData("DataDirectory", myAppFolder);
            }
            catch (Exception ex) { MessageBox.Show("Error creating directory"); }
        }
        public static void createProfileDir()
        {   //Create db directory
            try
            {
                if (!Directory.Exists(profileFolder))
                {
                    Directory.CreateDirectory(profileFolder);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error creating directory"); }

        }
        public static void createProfileBackupDir()
        {   //Create db directory
            try
            {

                if (!Directory.Exists(profileBackupFolder))
                {
                    DirectoryInfo di = Directory.CreateDirectory(profileBackupFolder);
                    if ((di.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                        //Add Hidden flag    
                        di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error creating directory"); }
        }
        public static void createDatabaseDir()
        {   //Create db directory
            try
            {

                if (!Directory.Exists(databaseFolder))
                {
                    Directory.CreateDirectory(databaseFolder);
                }
            } catch (Exception ex) { MessageBox.Show("Error creating directory"); }
}
      
            public static void createDatabaseBackupDir()
        {   //Create db directory
            try {
                if (!Directory.Exists(backupRootFolder))
                {
                    DirectoryInfo dInfo = Directory.CreateDirectory(backupRootFolder);
                    if ((dInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                        //Add Hidden flag    
                        dInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    }

                    if (!Directory.Exists(databaseBackupFolder))
                    {

                        DirectoryInfo di = Directory.CreateDirectory(databaseBackupFolder);
                        if ((di.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                        {
                            //Add Hidden flag    
                            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error creating directory"); }
        }
        
    }
}
