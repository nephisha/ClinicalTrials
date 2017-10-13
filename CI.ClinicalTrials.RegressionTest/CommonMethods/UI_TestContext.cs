namespace CI.ClinicalTrials.RegressionTest.CommonMethods
{
    /// <summary>
    /// UI_TestContext is used for constructor context injection.
    /// </summary>
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
