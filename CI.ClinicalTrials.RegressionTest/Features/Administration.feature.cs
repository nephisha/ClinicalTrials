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
    [NUnit.Framework.DescriptionAttribute("Administration")]
    public partial class AdministrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Administration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Administration", "\tIn order to restrict the access to various features\r\n\tAs an Administrator\r\n\tI wa" +
                    "nt to create users with multiple roles", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("27340 - Create new User")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.TestCaseAttribute("CTU", "Clinical Trials Unit", null)]
        [NUnit.Framework.TestCaseAttribute("LHD", "Local Health District", null)]
        public virtual void _27340_CreateNewUser(string userType, string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Users"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27340 - Create new User", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When(string.Format("I create new {0} user from the user menu option", userType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("I should see the {0} user created successfully", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27347 - Create new Sponsor")]
        [NUnit.Framework.CategoryAttribute("Users")]
        public virtual void _27347_CreateNewSponsor()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27347 - Create new Sponsor", new string[] {
                        "Users"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.When("I create new sponsor from the menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I should see the sponsor created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27352 - Create new Local Health District")]
        [NUnit.Framework.CategoryAttribute("Users")]
        public virtual void _27352_CreateNewLocalHealthDistrict()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27352 - Create new Local Health District", new string[] {
                        "Users"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.When("I create new LHD from the menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("I should see the LHD created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27355 - Create new Clinical Trial Unit")]
        [NUnit.Framework.CategoryAttribute("Users")]
        public virtual void _27355_CreateNewClinicalTrialUnit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27355 - Create new Clinical Trial Unit", new string[] {
                        "Users"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.When("I create new CTU from the menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("I should see the CTU created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27358 - Create new Hospital")]
        [NUnit.Framework.CategoryAttribute("Users")]
        public virtual void _27358_CreateNewHospital()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27358 - Create new Hospital", new string[] {
                        "Users"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
 testRunner.When("I create new Hospital from the menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("I should see the Hospital created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27369 - Create new Report Period")]
        [NUnit.Framework.CategoryAttribute("Users")]
        public virtual void _27369_CreateNewReportPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27369 - Create new Report Period", new string[] {
                        "Users"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.When("I create new Report Period from the menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("I should see the Report Period created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27370 - 27372 - Modify and Delete Report Period")]
        [NUnit.Framework.CategoryAttribute("Users")]
        public virtual void _27370_27372_ModifyAndDeleteReportPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27370 - 27372 - Modify and Delete Report Period", new string[] {
                        "Users"});
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And("I have a existing Report Period", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When("I modify the Report Period", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("I should see the changes made in Report Period", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.And("When I delete the Report Period", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.Then("the report period should be deleted successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27389 - Create new Report Period Extension")]
        [NUnit.Framework.CategoryAttribute("Users")]
        public virtual void _27389_CreateNewReportPeriodExtension()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27389 - Create new Report Period Extension", new string[] {
                        "Users"});
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
 testRunner.When("I create new Report Period Extension from the menu option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("I should see the Extension created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27341 - Editing user details and access")]
        [NUnit.Framework.CategoryAttribute("Edit")]
        [NUnit.Framework.TestCaseAttribute("CTU", "LHD", "Master Trials, Submit New Trial, Reports", "", null)]
        [NUnit.Framework.TestCaseAttribute("LHD", "CTU", "Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trial" +
            "s, Reports", "Extracts, User Resources", null)]
        [NUnit.Framework.TestCaseAttribute("CTU", "Admin", "Dashboard, Master Trials, Submit New Trial, My Site Trial, Sign Off My Site Trial" +
            "s, Reports", "Extracts, User Resources, Administration", null)]
        public virtual void _27341_EditingUserDetailsAndAccess(string type1, string type2, string primaryMenu, string secondaryMenu, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Edit"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27341 - Editing user details and access", @__tags);
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
 testRunner.And(string.Format("I have an existing active {0} user", type1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.When(string.Format("I change the {0} user access to {1} and details", type1, type2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then(string.Format("{0} user should see the new changes in {1} and {2}", type2, primaryMenu, secondaryMenu), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("27342 - Disable Existing User")]
        [NUnit.Framework.CategoryAttribute("Users")]
        [NUnit.Framework.TestCaseAttribute("RegressionCTU030", "Disabled", null)]
        public virtual void _27342_DisableExistingUser(string cTUUser, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Users"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("27342 - Disable Existing User", @__tags);
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
 testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.And(string.Format("I have an existing {0} who is activated", cTUUser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.When("I disable the user account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then(string.Format("{0} should not be allowed to login the system", cTUUser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
