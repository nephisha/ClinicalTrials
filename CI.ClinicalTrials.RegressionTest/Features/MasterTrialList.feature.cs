﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CI.ClinicalTrials.RegressionTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MasterTrialList")]
    public partial class MasterTrialListFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MasterTrialList.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MasterTrialList", "\tIn order to action on a Clinical Trial\r\n\tAs a User\r\n\tI want perform search on th" +
                    "e Master Trials", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27012 - Master Trial List - Basic Search")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27012_MasterTrialList_BasicSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27012 - Master Trial List - Basic Search", new string[] {
                        "Search"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I perform a basic search in Master Trial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I should see the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27013 - Master Trial List Search By Top Navigation")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27013_MasterTrialListSearchByTopNavigation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27013 - Master Trial List Search By Top Navigation", new string[] {
                        "Search"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I search in the top navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I should see the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27015 - Master Trial List - Search By Sponsor")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27015_MasterTrialList_SearchBySponsor()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27015 - Master Trial List - Search By Sponsor", new string[] {
                        "Search"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When("I search by sponsor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("I should see the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27020 - Master Trial List - Search By CTU")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27020_MasterTrialList_SearchByCTU()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27020 - Master Trial List - Search By CTU", new string[] {
                        "Search"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.When("I search by CTU", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("I should see the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27021 - Master Trial List - Search By Tumour Groups")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27021_MasterTrialList_SearchByTumourGroups()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27021 - Master Trial List - Search By Tumour Groups", new string[] {
                        "Search"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When("I search by Tumour Groups", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("I should see the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27022 - Master Trial List - Search By Trial Classification")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27022_MasterTrialList_SearchByTrialClassification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27022 - Master Trial List - Search By Trial Classification", new string[] {
                        "Search"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When("I search by Trial Classification", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("I should see the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27023 - Master Trial List - Search By Verification Status")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27023_MasterTrialList_SearchByVerificationStatus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27023 - Master Trial List - Search By Verification Status", new string[] {
                        "Search"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.When("I search by verification Status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("I should see the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27043 - Master Trial - Add to My Site Trial")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27043_MasterTrial_AddToMySiteTrial()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27043 - Master Trial - Add to My Site Trial", new string[] {
                        "Search"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.When("I add a trial to my site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("I should see the trial added successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27044 - Master Trial - Edit Trial Details")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27044_MasterTrial_EditTrialDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27044 - Master Trial - Edit Trial Details", new string[] {
                        "Search"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.When("I edit a trial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("I should see the trial details added successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27045 - Master Trial - View Locations")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27045_MasterTrial_ViewLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27045 - Master Trial - View Locations", new string[] {
                        "Search"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.When("I select the location tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("I should see the location details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27048 - Master Trial - Remove Trial")]
        [NUnit.Framework.CategoryAttribute("Search")]
        public virtual void _27048_MasterTrial_RemoveTrial()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27048 - Master Trial - Remove Trial", new string[] {
                        "Search"});
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
 testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
 testRunner.When("I remove a trial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("I should see the trial getting removed successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
