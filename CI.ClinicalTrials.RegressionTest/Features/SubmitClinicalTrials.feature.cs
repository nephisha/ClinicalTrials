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
    [NUnit.Framework.DescriptionAttribute("Submit a Clinical Trial for the Patient")]
    public partial class SubmitAClinicalTrialForThePatientFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SubmitClinicalTrials.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Submit a Clinical Trial for the Patient", "  In order to participate in clinical trials\r\n  As a User\r\n  I should be able to " +
                    "submit new Trials", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("26612 - Submit a Portfolio Clinical Trial")]
        [NUnit.Framework.CategoryAttribute("Clinical")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.CategoryAttribute("Test")]
        [NUnit.Framework.TestCaseAttribute("Portfolio", "ACT Health", "Interventional", null)]
        public virtual void _26612_SubmitAPortfolioClinicalTrial(string category, string sponsor, string design, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Clinical",
                    "Regression",
                    "Test"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("26612 - Submit a Portfolio Clinical Trial", @__tags);
#line 8
  this.ScenarioSetup(scenarioInfo);
#line 10
    testRunner.Given("I login to Clinical Trial Application as Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When(string.Format("I submit a new trial with details {0} and {1} and {2}", sponsor, design, category), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("I should see the new trial created by Administrator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("26623 - Submit a Non - Portfolio Clinical Trial")]
        [NUnit.Framework.CategoryAttribute("Clinical")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("NonPortfolio", "Cancer Council NSW", "Other", null)]
        public virtual void _26623_SubmitANon_PortfolioClinicalTrial(string category, string sponsor, string design, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Clinical",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("26623 - Submit a Non - Portfolio Clinical Trial", @__tags);
#line 19
  this.ScenarioSetup(scenarioInfo);
#line 21
    testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.When(string.Format("I submit a new trial with details {0} and {1} and {2}", sponsor, design, category), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I should see the new trial created by CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("26625 - Submit a Industrial Clinical Trial")]
        [NUnit.Framework.CategoryAttribute("Clinical")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("Industry", "Kosan", "Interventional", null)]
        public virtual void _26625_SubmitAIndustrialClinicalTrial(string category, string sponsor, string design, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Clinical",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("26625 - Submit a Industrial Clinical Trial", @__tags);
#line 30
  this.ScenarioSetup(scenarioInfo);
#line 32
    testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When(string.Format("I submit a new trial with details {0} and {1} and {2}", sponsor, design, category), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("I should see the new trial created by CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("26627 - Cancel a Non - Portfolio Clinical Trial")]
        [NUnit.Framework.CategoryAttribute("Clinical")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("NonPortfolio", "Cancer Council NSW", "Other", null)]
        public virtual void _26627_CancelANon_PortfolioClinicalTrial(string category, string sponsor, string design, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Clinical",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("26627 - Cancel a Non - Portfolio Clinical Trial", @__tags);
#line 41
  this.ScenarioSetup(scenarioInfo);
#line 43
    testRunner.Given("I login to Clinical Trial Application as CTU User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.When(string.Format("I cancel a new trial with entered details {0} and {1} and {2}", sponsor, design, category), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("the new trial should not get created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
