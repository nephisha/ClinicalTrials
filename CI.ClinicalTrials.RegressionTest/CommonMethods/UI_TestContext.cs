using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.ClinicalTrials.RegressionTest.CommonMethods
{
    public class UI_TestContext
    {
        public string TrialTitle { get; set; }
        public string Acronym { get; set; }
        public string DeprecatedSponsor { get; set; }
        public string DeprecatedCTU { get; set; }
        public string SelectedTrial { get; set; }
        public string ReportPeriod { get; set; }
    }
}
