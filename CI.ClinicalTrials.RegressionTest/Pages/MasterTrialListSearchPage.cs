using System;
using System.Collections.Generic;
using System.Threading;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages.Administrator;
using CI.ClinicalTrials.RegressionTest.Resources;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class MasterTrialListSearchPage : PageBase
    {
        public string TrialName;
        public string TrialRegoNumber;
        public static string TrialAcronym;
        private const string SearchCriteria = "NickRegTest";

        [FindsBy(How = How.XPath, Using = "//form[@id='searchForm']/fieldset/legend")]
        private IWebElement MasterTrialListSearch { get; set; }

        [FindsBy(How = How.Id, Using = "Query")]
        private IWebElement Query { get; set; }

        [FindsBy(How = How.Name, Using = "submitCommand")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "SponsorID")]
        private IWebElement Sponsor { get; set; }

        [FindsBy(How = How.Id, Using = "CTUID")]
        private IWebElement CTU { get; set; }

        [FindsBy(How = How.Id, Using = "CTUId")]
        private IWebElement JoinTrialSite { get; set; }

        [FindsBy(How = How.Id, Using = "TumourGroupIDs_chosen")]
        private IWebElement TumourGroup { get; set; }

        [FindsBy(How = How.Id, Using = "TrialClassification")]
        private IWebElement TrialClassification { get; set; }

        [FindsBy(How = How.Id, Using = "TrialVerification")]
        private IWebElement TrialVerification { get; set; }

        [FindsBy(How = How.Id, Using = "portfolio_exlusion_reasons_chosen")]
        private IWebElement PortfolioExclusion { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='portfolio_exlusion_reasons_chosen']/div/ul/li")]
        private IList<IWebElement> PortfolioExclusionResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='TumourGroupIDs_chosen']/div/ul/li")]
        private IList<IWebElement> TumourGroupResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[6]")]
        private IWebElement AdminSearchTrialResult_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[4]")]
        private IWebElement AdminSearchTrialResult_Acronym { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[7]")]
        private IWebElement AdminSearchTrialResult_RegoNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[5]")]
        private IWebElement CTUSearchTrialResult_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[2]")]
        private IWebElement CTUSearchTrialResult_Sponsor { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[7]")]
        private IWebElement CTUSearchTrialResult_TumourGroup { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='paginate_button current']")]
        private IWebElement Load_DataTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[3]")]
        private IWebElement CTUSearchTrialResult_Acronym { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[12]")]
        private IWebElement AdminSearchTrialResult_ClassificationStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[11]")]
        private IWebElement AdminSearchTrialResult_VerificationStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr/td[1]")]
        private IWebElement SearchTrialResult { get; set; }

        [FindsBy(How = How.Id, Using = "verified")]
        private IWebElement Verified { get; set; }

        [FindsBy(How = How.Id, Using = "verify-comment")]
        private IWebElement VerifyComment { get; set; }

        [FindsBy(How = How.Id, Using = "rejected")]
        private IWebElement Rejected { get; set; }

        [FindsBy(How = How.Id, Using = "verify-in-review")]
        private IWebElement VerifyInReview { get; set; }

        [FindsBy(How = How.Id, Using = "verify-save")]
        private IWebElement SaveVerifyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='classification-verification-section']/div[2]/p")]
        private IWebElement ClassificationSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='classify']")]
        private IWebElement Classified { get; set; }

        [FindsBy(How = How.Id, Using = "classify-in-review")]
        private IWebElement ClassifyInReview { get; set; }

        [FindsBy(How = How.Id, Using = "classification-select")]
        private IWebElement ClassificationType { get; set; }

        [FindsBy(How = How.Id, Using = "paymentlevel-select")]
        private IWebElement PortfolioCategory { get; set; }

        [FindsBy(How = How.Id, Using = "TrialClassifyAndVerifySection_ClassificationExceptionComment")]
        private IWebElement ClassificationComment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='classify']/div[2]/button[1]")]
        private IWebElement SaveClassification { get; set; }

        [FindsBy(How = How.Id, Using = "regEditTrials")]
        private IWebElement EditTrials { get; set; }

        [FindsBy(How = How.Id, Using = "regAddToMyTrialsList")]
        private IWebElement AddToMyTrialsList { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@value='Save']")]
        private IWebElement JoinTrial { get; set; }

        [FindsBy(How = How.Id, Using = "regRemoveFromMasterList")]
        private IWebElement RemoveFromMasterList { get; set; }

        [FindsBy(How = How.Id, Using = "removeTrialConfirm")]
        private IWebElement ConfirmRemoveTrial { get; set; }

        [FindsBy(How = How.Id, Using = "removeTrialModalLabel")]
        private IWebElement RemoveTrialPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='validation-summary-errors']")]
        private IWebElement ValidationError { get; set; }

        public void VerifyMasterTrialListSearchPageIsLoaded()
        {
            PageHelper.WaitForElement(Driver, MasterTrialListSearch).Text.Should()
                .BeEquivalentTo("Master Trial List Search");
        }

        public void SearchAndVerifyTheCreatedTrialByAdmin(string title)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SearchForCreatedTrial(title);
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, AdminSearchTrialResult_Name).Text.Should().Contain(title);
        }

        public void SearchAndVerifyTheCreatedTrialByCTUUser(string title)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SearchForCreatedTrial(title);
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, CTUSearchTrialResult_Name).Text.Should().Contain(title);
        }

        private void SearchForCreatedTrial(string text)
        {
            Query.Clear();
            Query.SendKeys("Title" + text);
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
        }

        public void SearchByQuery()
        {
            Query.SendKeys(SearchCriteria);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        public void VerifySearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            Query.GetAttribute("value").Should().BeEquivalentTo(SearchCriteria);
            CTUSearchTrialResult_Acronym.Text.Should().Contain(SearchCriteria);
        }

        public void SearchBySponsor()
        {
            PageHelper.SelectValueFromDropdown(Sponsor, "Abbott");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        public void VerifySponsorSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            CTUSearchTrialResult_Sponsor.Text.Should().BeEquivalentTo("Abbott");
        }

        public void SearchByCTU()
        {
            PageHelper.SelectValueFromDropdown(CTU, "Bankstown Hospital");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        public void VerifyCTUSearchResults()
        {
            
        }

        public void SearchByTumourGroups()
        {
            TumourGroup.Click();
            PageHelper.SelectValueFromDropList(TumourGroupResult, "Brain");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        public void VerifyTumourGroupResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            CTUSearchTrialResult_TumourGroup.Text.Should().BeEquivalentTo("Brain");
        }

        public void SearchByTrialClassification()
        {
            PageHelper.SelectValueFromDropdown(TrialClassification, "Portfolio");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        public void VerifyClassificationSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_ClassificationStatus.Text.Should().BeEquivalentTo("Portfolio");
        }

        public void SearchByVerificationStatus()
        {
            PageHelper.SelectValueFromDropdown(TrialVerification, "Verified");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        public void VerifyVerificationStatusSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Verified");
        }

        public string AddTrialToMySiteTrialList()
        {
            var sAcronym = SearchAndAddTrial();
            JoinAddedTrialToSite();
            return sAcronym;
        }

        private void JoinAddedTrialToSite()
        {
            PageHelper.PickOnlyEnabledValueFromDropdown(JoinTrialSite);
            JoinTrial.Click();
        }

        private string SearchAndAddTrial()
        {
            SearchByTrialClassification();
            TrialAcronym = CTUSearchTrialResult_Acronym.Text;
            Query.SendKeys(TrialAcronym);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AddToMyTrialsList.Click();
            return TrialAcronym;
        }

        public void EditanExistingTrial()
        {
            GetanExistingTrialData();
            EditTrials.Click();
        }

        private void GetanExistingTrialData()
        {
            Query.SendKeys("NickRegTest");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            TrialRegoNumber = AdminSearchTrialResult_RegoNumber.Text;
            Query.Clear();
            Query.SendKeys(TrialRegoNumber);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        public void SearchAndVerifyTheEditedTrial()
        {
            Query.SendKeys(TrialRegoNumber);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            AdminSearchTrialResult_Acronym.Text.Should().Contain("Modified");
        }

        public void RemoveAnExistingTrial()
        {
            GetanExistingTrialData();
            PageHelper.WaitForElement(Driver, RemoveFromMasterList).Click();
            PageHelper.WaitForElement(Driver, RemoveTrialPopUp);
            ConfirmRemoveTrial.Click();
        }

        public void SearchAndVerifyTheRemovedTrial()
        {
            Driver.Navigate().Refresh();
            Query.Clear();
            Query.SendKeys(TrialRegoNumber);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(2000));
            SearchTrialResult.Text.Should().BeEquivalentTo("No results to show");
        }

        public void AddCreatedTrialToMySiteTrial(string trialTitle)
        {
            Query.Clear();
            Query.SendKeys(trialTitle);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AddToMyTrialsList.Click();
            JoinAddedTrialToSite();
        }

        public void VerifyAndClassifyTheTrial(string contextTrialTitle)
        {
            Query.Clear();
            Query.SendKeys(contextTrialTitle);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            EditTrials.Click();
            Verified.Click();
            VerifyComment.SendKeys("Verified by Automated Regression Test");
            ClassifyTheTrial();
        }

        public void SearchAndVerifyTheClassifiedTrial(string contextTrialTitle)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            Query.Clear();
            Query.SendKeys(contextTrialTitle);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_ClassificationStatus.Text.Should().BeEquivalentTo("Portfolio");
        }

        public void VerifyTheTrial()
        {
            Verified.Click();
            VerifyComment.SendKeys("Verified by Automated Regression Test");
            SaveVerifyButton.Click();
        }

        public void ClassifyTheTrial()
        {
            ClassificationSection.Click();
            PageHelper.WaitForElement(Driver, Classified).Click();
            PageHelper.SelectValueFromDropdown(ClassificationType, "Portfolio");
            PageHelper.PickRandomValueFromDropdown(PortfolioCategory);
            ClassificationComment.SendKeys("Classified by Automated Regression Test");
            SaveClassification.Click();
        }

        public bool VerifyDeprecatedSponsorIsNotListed(string deprecatedSponsor)
        {
            try
            {
                var select = new SelectElement(Sponsor);
                select.SelectByText(deprecatedSponsor);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public bool VerifyDeprecatedCTUIsNotListed(string deprecatedCTU)
        {
            try
            {
                var select = new SelectElement(Sponsor);
                select.SelectByText(deprecatedCTU);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public string SearchForPendingVerificationTrials()
        {
            PageHelper.SelectValueFromDropdown(TrialVerification, "Pending Verification");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            return AdminSearchTrialResult_Acronym.Text;
        }

        public string SearchForPortfolioPendingVerificationTrials()
        {
            PageHelper.SelectValueFromDropdown(Sponsor, "ACT Health");
            PageHelper.SelectValueFromDropdown(TrialVerification, "Pending Verification");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            return AdminSearchTrialResult_Acronym.Text;
        }

        public void SearchAndEditTheSelectedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, EditTrials).Click();
        }

        public void SearchAndVerifyTheVerifiedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Verified");
        }

        public void RejectTheTrial()
        {
            Rejected.Click();
            VerifyComment.SendKeys("Rejected by Automated Regression Test");
            SaveVerifyButton.Click();
        }

        public void SearchAndVerifyTheRejectedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Rejected");
        }

        public void ReviewTheTrial()
        {
            VerifyInReview.Click();
            VerifyComment.SendKeys("Reviewed by Automated Regression Test");
            SaveVerifyButton.Click();
        }

        public void SearchAndVerifyTheReviewedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Pending Verification (In Review)");
        }

        public void ClassifyTheVerifiedTrialAsInReview()
        {
            PageHelper.WaitForElement(Driver, ClassifyInReview).Click();
            ClassificationComment.SendKeys("Review needed by Automated Regression Test");
            SaveClassification.Click();
        }

        public void SearchAndVerifyTheClassifiedTrialStatus(string contextSelectedTrial, string status)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_ClassificationStatus.Text.Should().BeEquivalentTo(status);
        }

        public void ClassifyTheVerifiedTrialAsPortfolio()
        {
            PageHelper.WaitForElement(Driver, Classified).Click();
            PageHelper.SelectValueFromDropdown(ClassificationType, "Portfolio");
            PageHelper.PickRandomValueFromDropdown(PortfolioCategory);
            ClassificationComment.SendKeys("Classified Portfolio by Automated Regression Test");
            SaveClassification.Click();
        }

        public void ClassifyTheVerifiedTrialAsNonPortfolio()
        {
            PageHelper.WaitForElement(Driver, Classified).Click();
            PageHelper.SelectValueFromDropdown(ClassificationType, "Non-Portfolio");
            PortfolioExclusion.Click();
            PageHelper.PickRandomValueFromDropList(PortfolioExclusionResult);
            ClassificationComment.SendKeys("Classified Non-Portfolio by Automated Regression Test");
            SaveClassification.Click();
        }

        public void VerifyThatTrialSubmissionErrorIsDisplayed()
        {
            ValidationError.Text.Should().BeEquivalentTo(ErrorMessages.ClassificationError);
        }
    }
}