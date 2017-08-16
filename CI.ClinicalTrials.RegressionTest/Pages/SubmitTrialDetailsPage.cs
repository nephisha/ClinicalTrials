using System;
using System.Collections.Generic;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class SubmitTrialDetailsPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "Details_StudyName")]
        private IWebElement ScientificTitle { get; set; }

        [FindsBy(How = How.Id, Using = "Details_PublicTitle")]
        private IWebElement PublicTitle { get; set; }

        [FindsBy(How = How.Id, Using = "Details_SponsorId")]
        private IWebElement Sponsor { get; set; }

        [FindsBy(How = How.Id, Using = "Details_CooperativeGroups_chosen")]
        private IWebElement CooperativeGroups { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='Details_CooperativeGroups_chosen']/div/ul/li")]
        private IList<IWebElement> CoopGroupResult { get; set; }

        [FindsBy(How = How.Id, Using = "Details_Acronym")]
        private IWebElement Nickname { get; set; }

        [FindsBy(How = How.Id, Using = "Details_RegistrationNumber")]
        private IWebElement RegistrationNumber { get; set; }

        [FindsBy(How = How.Id, Using = "Details_Phase")]
        private IWebElement Phase { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='regGroup']")]
        private IList<IWebElement> Group { get; set; }

        [FindsBy(How = How.Id, Using = "Details_TumourCategory")]
        private IWebElement TumourCategory { get; set; }

        [FindsBy(How = How.Id, Using = "Details_TumourGroups_chosen")]
        private IWebElement TumourGroup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Details_TumourGroups_chosen']/div/ul/li")]
        private IList<IWebElement> TumourGroupResult { get; set; }

        [FindsBy(How = How.Id, Using = "Details_StageOfDisease_chosen")]
        private IWebElement StagesOfDisease { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Details_StageOfDisease_chosen']/div/ul/li")]
        private IList<IWebElement> DiseaseStageResult { get; set; }

        [FindsBy(How = How.Id, Using = "Details_Population")]
        private IWebElement Population { get; set; }

        [FindsBy(How = How.Id, Using = "regMultiTrialYes")]
        private IWebElement MultiTrialYes { get; set; }

        [FindsBy(How = How.Id, Using = "Details_LeadSite")]
        private IWebElement LeadSite { get; set; }

        [FindsBy(How = How.Id, Using = "regBiomarkerSubstudyYes")]
        private IWebElement BiomarkerSubstudyYes { get; set; }

        [FindsBy(How = How.Id, Using = "regMoleculeTargetBox_chosen")]
        private IWebElement MoleculeTargetBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regMoleculeTargetBox_chosen']/div/ul/li")]
        private IList<IWebElement> MolecularTarget { get; set; }

        [FindsBy(How = How.Id, Using = "regBioMarkerTrialEligiblityYes")]
        private IWebElement BioMarkerTrialEligiblityYes { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='BioMarkerSection_MainMolecularTargets']/following-sibling::div[1]/div")]
        private IWebElement BioMarkerMolecularTarget { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='BioMarkerSection_MainMolecularTargets']/following-sibling::div[1]/div/div/ul/li")]
        private IList<IWebElement> BioMarkerMolecularList { get; set; }

        [FindsBy(How = How.Id, Using = "regTissueAvailabilityYes")]
        private IWebElement TissueAvailabilityYes { get; set; }

        [FindsBy(How = How.Id, Using = "Design_MainInterventionMode")]
        private IWebElement TrialPurpose { get; set; }

        [FindsBy(How = How.Id, Using = "Design_IsInterventional")]
        private IWebElement InterventionalDesign { get; set; }

        [FindsBy(How = How.Id, Using = "non-interventional")]
        private IWebElement OtherCancerRelatedDesign { get; set; }

        [FindsBy(How = How.Name, Using = "Design.TrialDesign")]
        private IWebElement TrialDesign { get; set; }

        [FindsBy(How = How.Id, Using = "trial-design-other-select")]
        private IWebElement TrialDesignOther { get; set; }

        [FindsBy(How = How.Id, Using = "Design_InterventionType_chosen")]
        private IWebElement InterventionType { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='Design_InterventionType_chosen']/div/ul/li")]
        private IList<IWebElement> InterventionTypeList { get; set; }

        [FindsBy(How = How.Id, Using = "PortfolioInclusion_PortfolioInclusionRequested")]
        private IWebElement PortfolioInclusion { get; set; }

        [FindsBy(How = How.Id, Using = "PortfolioInclusion_HrecApprovalDate")]
        private IWebElement HrecApprovalDate { get; set; }

        [FindsBy(How = How.Id, Using = "regPorfolioInclusionPeerReviewedYes")]
        private IWebElement PorfolioInclusionPeerReviewedYes { get; set; }

        [FindsBy(How = How.Id, Using = "regPorfolioInclusionEthicsApprovalYes")]
        private IWebElement PorfolioInclusionEthicsApprovalYes { get; set; }

        [FindsBy(How = How.Id, Using = "regPortfolioInclusionInfluenceClinicalPracticeYes")]
        private IWebElement PortfolioInclusionInfluenceClinicalPracticeYes { get; set; }

        [FindsBy(How = How.Id, Using = "regPortfolioInclusionIntendToPublishResultsYes")]
        private IWebElement PortfolioInclusionIntendToPublishResultsYes { get; set; }

        [FindsBy(How = How.Id, Using = "regPortfolioInclusionIndustryIndependentSponsorYes")]
        private IWebElement PortfolioInclusionIndustryIndependentSponsorYes { get; set; }

        [FindsBy(How = How.Id, Using = "regAddToMySiteListSectionYes")]
        private IWebElement AddToMySiteListSectionYes { get; set; }

        [FindsBy(How = How.Id, Using = "AddToMySiteListSection_CTUId")]
        private IWebElement ActiveSite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='notificationTab']/form/div[2]/div[2]/div[2]/button[1]")]
        private IWebElement EditTrialSaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@value='Create']")]
        private IWebElement SubmitTrialButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary dirty-cop-applied']")]
        private IWebElement SubmitAnywayButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@value='Cancel']")]
        private IWebElement CancelButton { get; set; }

        public void EnterScientificTitle(string text)
        {
            ScientificTitle.Click();
            ScientificTitle.SendKeys("Title" + text);
        }

        private void EnterPublicTitle(string title)
        {
            PublicTitle.Click();
            PublicTitle.SendKeys("Public Title" + title);
        }

        public void SelectASponsor(string sponsorType)
        {
            PageHelper.SelectValueFromDropdown(Sponsor, sponsorType);
        }

        public void SelectACooperativeGroup()
        {
            CooperativeGroups.Click();
            PageHelper.PickRandomValueFromDropList(CoopGroupResult);
        }

        private void EnterNickName(string text)
        {
            Nickname.SendKeys("Nick" + text);
        }

        private void EnterRegistrationNumber(string text)
        {
            RegistrationNumber.SendKeys("Rego" + text);
        }

        public void SelectAPhase()
        {
            PageHelper.PickRandomValueFromDropdown(Phase);
        }

        public void SelectAGroup()
        {
            PageHelper.PickRandomValueFromDropList(Group);
        }

        public void SelectATumourCategory()
        {
            PageHelper.PickRandomValueFromDropdown(TumourCategory);
        }

        public void SelectATumourGroup()
        {
            TumourGroup.Click();
            PageHelper.PickRandomValueFromDropList(TumourGroupResult);
        }

        public void SelectStagesOfDisease()
        {
            StagesOfDisease.Click();
            PageHelper.PickRandomValueFromDropList(DiseaseStageResult);
        }

        private void SelectAPopulation()
        {
            PageHelper.PickRandomValueFromDropdown(Population);
        }

        private void SelectMultiCentreTrial()
        {
            MultiTrialYes.Click();
        }

        private void SelectLeadSite()
        {
            PageHelper.SelectValueFromDropdown(LeadSite, "Bankstown Hospital");
        }

        private void SelectBioMarkerSubstudy()
        {
            BiomarkerSubstudyYes.Click();
        }

        private void SelectAMolecularTarget()
        {
            PageHelper.WaitForElement(Driver, MoleculeTargetBox).Click();
            PageHelper.PickRandomValueFromDropList(MolecularTarget);
        }

        private void IsthePresenceOfBiomarkerRequiredForTrialEligibility()
        {
            BioMarkerTrialEligiblityYes.Click();
        }

        private void SelectABioMarkerMolecularTarget()
        {
            PageHelper.WaitForElement(Driver, BioMarkerMolecularTarget).Click();
            PageHelper.PickRandomValueFromDropList(BioMarkerMolecularList);
        }

        private void IsTissueAvailabilityRequirementToThisStudy()
        {
            TissueAvailabilityYes.Click();
        }

        private void SelectATypeOfIntervention()
        {
            InterventionType.Click();
            PageHelper.PickRandomValueFromDropList(InterventionTypeList, new List<string> {"Not Aplicable"});
        }

        private void SelectOtherCancerRelatedDesignType()
        {
            OtherCancerRelatedDesign.Click();
            PageHelper.SelectValueFromDropdown(TrialDesignOther, "Prospective Observation Study - Controlled");
        }

        private void SelectInterventionalDesignType()
        {
            InterventionalDesign.Click();
            PageHelper.SelectValueFromDropdown(TrialDesign, "Randomised Controlled Trial");
        }

        private void SelectPrimaryPurposeOfTrial()
        {
            PageHelper.PickRandomValueFromDropdown(TrialPurpose);
        }

        private void SelectaActiveSite()
        {
            PageHelper.PickRandomValueFromDropdown(ActiveSite);
        }

        private void SelectAddToMyTrialsList()
        {
            AddToMySiteListSectionYes.Click();
        }

        public void FillUpTrialDetails(string title, string sponsor)
        {
            EnterScientificTitle(title);
            EnterPublicTitle(title);
            SelectASponsor(sponsor);
            SelectACooperativeGroup();
            EnterNickName(title);
            EnterRegistrationNumber(title);
            SelectAPhase();
            SelectAGroup();
            SelectATumourCategory();
            SelectATumourGroup();
            SelectStagesOfDisease();
            SelectAPopulation();
            SelectMultiCentreTrial();
            SelectLeadSite();
            SelectBioMarkerSubstudy();
            SelectAMolecularTarget();
        }
        
        public void FillUpBioMarkerDetails()
        {
            IsthePresenceOfBiomarkerRequiredForTrialEligibility();
            SelectABioMarkerMolecularTarget();
            IsTissueAvailabilityRequirementToThisStudy();

        }

        public void FillUpTrialType(string design)
        {
            SelectPrimaryPurposeOfTrial();
            if (design.ToLower().Equals("interventional"))
                SelectInterventionalDesignType();
            else
                SelectOtherCancerRelatedDesignType();

            SelectATypeOfIntervention();
        }

        public void FillUpPortfolioInclusion(string category)
        {
            if (category.ToLower().Equals("portfolio"))
            {
                PortfolioInclusion.Click();
                PageHelper.WaitForElement(Driver, PorfolioInclusionPeerReviewedYes);
                PorfolioInclusionPeerReviewedYes.Click();
                PorfolioInclusionEthicsApprovalYes.Click();
                PortfolioInclusionInfluenceClinicalPracticeYes.Click();
                PortfolioInclusionIntendToPublishResultsYes.Click();
                PortfolioInclusionIndustryIndependentSponsorYes.Click();
                Driver.ExecuteJavaScript(@"$('#PortfolioInclusion_HrecApprovalDate').val('08/07/2017')");
            }
            else
            {
                Driver.ExecuteJavaScript(@"$('#PortfolioInclusion_HrecApprovalDate').val('01/07/2017')");
            }
        }

        public void FillUpReportingGroup()
        {
            SelectAddToMyTrialsList();
            SelectaActiveSite();
        }

        public void SubmitTrial()
        {
            SubmitTrialButton.Click();
            try
            {
                if (SubmitAnywayButton.Text.Equals("Submit Anyway"))
                {
                    SubmitAnywayButton.Click();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void FillallTheTrialDetails(string title, string sponsor, string design, string category)
        {
            FillUpTrialDetails(title, sponsor);
            FillUpBioMarkerDetails();
            FillUpTrialType(design);
            FillUpPortfolioInclusion(category);
            FillUpReportingGroup();
        }

        public void CancelTrial()
        {
            CancelButton.Click();
        }

        public void SaveTheEditedTrial()
        {
            ChangeNickName();
        }

        private void ChangeNickName()
        {
            Nickname.Clear();
            Nickname.SendKeys("Modified" + PageHelper.RandomString(8));
            EditTrialSaveButton.Click();
        }
    }
}
