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

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable_trials']/tbody/tr[1]/td[6]")]
        private IWebElement CTUSearchTrialResult_RegoNumber { get; set; }

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

        /// <summary>
        /// Verifies the master trial list search page is loaded.
        /// </summary>
        public void VerifyMasterTrialListSearchPageIsLoaded()
        {
            PageHelper.WaitForElement(Driver, MasterTrialListSearch).Text.Should()
                .BeEquivalentTo("Master Trial List Search");
        }

        /// <summary>
        /// Search and verify the created trial by admin.
        /// </summary>
        /// <param name="title">The title.</param>
        public void SearchAndVerifyTheCreatedTrialByAdmin(string title)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SearchForCreatedTrial(title);
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, AdminSearchTrialResult_Name).Text.Should().Contain(title);
        }

        /// <summary>
        /// Search and verify the created trial by ctu user.
        /// </summary>
        /// <param name="title">The title.</param>
        public void SearchAndVerifyTheCreatedTrialByCTUUser(string title)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            SearchForCreatedTrial(title);
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, CTUSearchTrialResult_Name).Text.Should().Contain(title);
        }

        /// <summary>
        /// Searches for created trial.
        /// </summary>
        /// <param name="text">The text.</param>
        private void SearchForCreatedTrial(string text)
        {
            Query.Clear();
            Query.SendKeys("Title" + text);
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
        }

        /// <summary>
        /// Searches by query.
        /// </summary>
        public void SearchByQuery()
        {
            Query.SendKeys(SearchCriteria);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        /// <summary>
        /// Verifies the search results.
        /// </summary>
        public void VerifySearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            Query.GetAttribute("value").Should().BeEquivalentTo(SearchCriteria);
            CTUSearchTrialResult_Acronym.Text.Should().Contain(SearchCriteria);
        }

        /// <summary>
        /// Searches by sponsor.
        /// </summary>
        public void SearchBySponsor()
        {
            PageHelper.SelectValueFromDropdown(Sponsor, "Kosan");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        /// <summary>
        /// Verifies the sponsor search results.
        /// </summary>
        public void VerifySponsorSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            CTUSearchTrialResult_Sponsor.Text.Should().BeEquivalentTo("Kosan");
        }

        /// <summary>
        /// Searches by ctu.
        /// </summary>
        public void SearchByCTU()
        {
            PageHelper.SelectValueFromDropdown(CTU, "Calvary Healthcare Sydney");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        /// <summary>
        /// Verifies the ctu search results.
        /// </summary>
        public void VerifyCTUSearchResults()
        {
            
        }

        /// <summary>
        /// Searches by tumour groups.
        /// </summary>
        public void SearchByTumourGroups()
        {
            TumourGroup.Click();
            PageHelper.SelectValueFromDropList(TumourGroupResult, "Brain");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        /// <summary>
        /// Verifies the tumour group results.
        /// </summary>
        public void VerifyTumourGroupResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            CTUSearchTrialResult_TumourGroup.Text.Should().BeEquivalentTo("Brain");
        }

        /// <summary>
        /// Searches by trial classification.
        /// </summary>
        public void SearchByTrialClassification()
        {
            PageHelper.SelectValueFromDropdown(TrialClassification, "Portfolio");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        /// <summary>
        /// Verifies the classification search results.
        /// </summary>
        public void VerifyClassificationSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_ClassificationStatus.Text.Should().BeEquivalentTo("Portfolio");
        }

        /// <summary>
        /// Searches by verification status.
        /// </summary>
        public void SearchByVerificationStatus()
        {
            PageHelper.SelectValueFromDropdown(TrialVerification, "Verified");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        /// <summary>
        /// Verifies the verification status search results.
        /// </summary>
        public void VerifyVerificationStatusSearchResults()
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Verified");
        }

        /// <summary>
        /// Adds the trial to my site trial list.
        /// </summary>
        /// <returns>System.String.</returns>
        public string AddTrialToMySiteTrialList()
        {
            var sAcronym = SearchAndAddTrial();
            JoinAddedTrialToSite();
            return sAcronym;
        }

        /// <summary>
        /// Joins the added trial to site.
        /// </summary>
        private void JoinAddedTrialToSite()
        {
            PageHelper.PickOnlyEnabledValueFromDropdown(JoinTrialSite);
            JoinTrial.Click();
        }

        /// <summary>
        /// Searches and add trial.
        /// </summary>
        /// <returns>System.String.</returns>
        private string SearchAndAddTrial()
        {
            SearchByTrialClassification();
            TrialAcronym = CTUSearchTrialResult_Acronym.Text;
            TrialRegoNumber = CTUSearchTrialResult_RegoNumber.Text;
            Query.SendKeys(TrialRegoNumber);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AddToMyTrialsList.Click();
            return TrialAcronym;
        }

        /// <summary>
        /// Edits an existing trial.
        /// </summary>
        public void EditanExistingTrial()
        {
            GetanExistingTrialData();
            EditTrials.Click();
        }

        /// <summary>
        /// Get an existing trial data.
        /// </summary>
        private void GetanExistingTrialData()
        {
            Query.SendKeys("NickRegTest");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            TrialRegoNumber = AdminSearchTrialResult_RegoNumber.Text;
            Query.Clear();
            Query.SendKeys(TrialRegoNumber);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
        }

        /// <summary>
        /// Search and verify the edited trial.
        /// </summary>
        public void SearchAndVerifyTheEditedTrial()
        {
            Query.SendKeys(TrialRegoNumber);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            AdminSearchTrialResult_Acronym.Text.Should().Contain("Modified");
        }

        /// <summary>
        /// Removes an existing trial.
        /// </summary>
        public void RemoveAnExistingTrial()
        {
            GetanExistingTrialData();
            PageHelper.WaitForElement(Driver, RemoveFromMasterList).Click();
            PageHelper.WaitForElement(Driver, RemoveTrialPopUp);
            ConfirmRemoveTrial.Click();
        }

        /// <summary>
        /// Search and verify the removed trial.
        /// </summary>
        public void SearchAndVerifyTheRemovedTrial()
        {
            Driver.Navigate().Refresh();
            Query.Clear();
            Query.SendKeys(TrialRegoNumber);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(2000));
            SearchTrialResult.Text.Should().BeEquivalentTo("No results to show");
        }

        /// <summary>
        /// Adds the created trial to my site trial.
        /// </summary>
        /// <param name="trialTitle">The trial title.</param>
        public void AddCreatedTrialToMySiteTrial(string trialTitle)
        {
            Query.Clear();
            Query.SendKeys(trialTitle);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AddToMyTrialsList.Click();
            JoinAddedTrialToSite();
        }

        /// <summary>
        /// Verifies and classify the trial.
        /// </summary>
        /// <param name="contextTrialTitle">The context trial title.</param>
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

        /// <summary>
        /// Searches and verify the classified trial.
        /// </summary>
        /// <param name="contextTrialTitle">The context trial title.</param>
        public void SearchAndVerifyTheClassifiedTrial(string contextTrialTitle)
        {
            PageHelper.WaitForElement(Driver, Load_DataTable);
            Query.Clear();
            Query.SendKeys(contextTrialTitle);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_ClassificationStatus.Text.Should().BeEquivalentTo("Portfolio");
        }

        /// <summary>
        /// Verifies the trial.
        /// </summary>
        public void VerifyTheTrial()
        {
            Verified.Click();
            VerifyComment.SendKeys("Verified by Automated Regression Test");
            SaveVerifyButton.Click();
        }

        /// <summary>
        /// Classifies the trial.
        /// </summary>
        public void ClassifyTheTrial()
        {
            ClassificationSection.Click();
            PageHelper.WaitForElement(Driver, Classified).Click();
            PageHelper.SelectValueFromDropdown(ClassificationType, "Portfolio");
            PageHelper.PickRandomValueFromDropdown(PortfolioCategory);
            ClassificationComment.SendKeys("Classified by Automated Regression Test");
            SaveClassification.Click();
        }

        /// <summary>
        /// Verifies the deprecated sponsor is not listed.
        /// </summary>
        /// <param name="deprecatedSponsor">The deprecated sponsor.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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

        /// <summary>
        /// Verifies the deprecated ctu is not listed.
        /// </summary>
        /// <param name="deprecatedCTU">The deprecated ctu.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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

        /// <summary>
        /// Searches for pending verification trials.
        /// </summary>
        /// <returns>System.String.</returns>
        public string SearchForPendingVerificationTrials()
        {
            PageHelper.SelectValueFromDropdown(TrialVerification, "Pending Verification");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            return AdminSearchTrialResult_Acronym.Text;
        }

        /// <summary>
        /// Searches for portfolio pending verification trials.
        /// </summary>
        /// <returns>System.String.</returns>
        public string SearchForPortfolioPendingVerificationTrials()
        {
            PageHelper.SelectValueFromDropdown(Sponsor, "ACT Health");
            PageHelper.SelectValueFromDropdown(TrialVerification, "Pending Verification");
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            return AdminSearchTrialResult_Acronym.Text;
        }

        /// <summary>
        /// Searches and edit the selected trial.
        /// </summary>
        /// <param name="contextSelectedTrial">The context selected trial.</param>
        public void SearchAndEditTheSelectedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            PageHelper.WaitForElement(Driver, EditTrials).Click();
        }

        /// <summary>
        /// Searches and verify the verified trial.
        /// </summary>
        /// <param name="contextSelectedTrial">The context selected trial.</param>
        public void SearchAndVerifyTheVerifiedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Verified");
        }

        /// <summary>
        /// Rejects the trial.
        /// </summary>
        public void RejectTheTrial()
        {
            Rejected.Click();
            VerifyComment.SendKeys("Rejected by Automated Regression Test");
            SaveVerifyButton.Click();
        }

        /// <summary>
        /// Search and verify the rejected trial.
        /// </summary>
        /// <param name="contextSelectedTrial">The context selected trial.</param>
        public void SearchAndVerifyTheRejectedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Rejected");
        }

        /// <summary>
        /// Reviews the trial.
        /// </summary>
        public void ReviewTheTrial()
        {
            VerifyInReview.Click();
            VerifyComment.SendKeys("Reviewed by Automated Regression Test");
            SaveVerifyButton.Click();
        }

        /// <summary>
        /// Search and verify the reviewed trial.
        /// </summary>
        /// <param name="contextSelectedTrial">The context selected trial.</param>
        public void SearchAndVerifyTheReviewedTrial(string contextSelectedTrial)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_VerificationStatus.Text.Should().BeEquivalentTo("Pending Verification (In Review)");
        }

        /// <summary>
        /// Classifies the verified trial as in review.
        /// </summary>
        public void ClassifyTheVerifiedTrialAsInReview()
        {
            PageHelper.WaitForElement(Driver, ClassifyInReview).Click();
            ClassificationComment.SendKeys("Review needed by Automated Regression Test");
            SaveClassification.Click();
        }

        /// <summary>
        /// Search and verify the classified trial status.
        /// </summary>
        /// <param name="contextSelectedTrial">The context selected trial.</param>
        /// <param name="status">The status.</param>
        public void SearchAndVerifyTheClassifiedTrialStatus(string contextSelectedTrial, string status)
        {
            Query.Clear();
            Query.SendKeys(contextSelectedTrial);
            PageHelper.WaitForElement(Driver, SearchButton).Click();
            PageHelper.WaitForElement(Driver, Load_DataTable);
            AdminSearchTrialResult_ClassificationStatus.Text.Should().BeEquivalentTo(status);
        }

        /// <summary>
        /// Classifies the verified trial as portfolio.
        /// </summary>
        public void ClassifyTheVerifiedTrialAsPortfolio()
        {
            PageHelper.WaitForElement(Driver, Classified).Click();
            PageHelper.SelectValueFromDropdown(ClassificationType, "Portfolio");
            PageHelper.PickRandomValueFromDropdown(PortfolioCategory);
            ClassificationComment.SendKeys("Classified Portfolio by Automated Regression Test");
            SaveClassification.Click();
        }

        /// <summary>
        /// Classifies the verified trial as non portfolio.
        /// </summary>
        public void ClassifyTheVerifiedTrialAsNonPortfolio()
        {
            PageHelper.WaitForElement(Driver, Classified).Click();
            PageHelper.SelectValueFromDropdown(ClassificationType, "Non-Portfolio");
            PortfolioExclusion.Click();
            PageHelper.PickRandomValueFromDropList(PortfolioExclusionResult);
            ClassificationComment.SendKeys("Classified Non-Portfolio by Automated Regression Test");
            SaveClassification.Click();
        }

        /// <summary>
        /// Verifies the that trial submission error is displayed.
        /// </summary>
        public void VerifyThatTrialSubmissionErrorIsDisplayed()
        {
            ValidationError.Text.Should().BeEquivalentTo(ErrorMessages.ClassificationError);
        }
    }
}