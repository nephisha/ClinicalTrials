using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.ClinicalTrials.RegressionTest.Resources
{
    public class UserCredentials
    {
        public static string Admin_UserName => ConfigurationManager.AppSettings["Admin_UserName"];
        public static string Admin_Password => ConfigurationManager.AppSettings["Admin_Password"];
        public static string CTU_UserName => ConfigurationManager.AppSettings["CTU_UserName"];
        public static string CTU_Password => ConfigurationManager.AppSettings["CTU_Password"];
        public static string AutoCTU_UserName => ConfigurationManager.AppSettings["AutoCTU_UserName"];
        public static string AutoCTU_Password => ConfigurationManager.AppSettings["AutoCTU_Password"];
    }
}
