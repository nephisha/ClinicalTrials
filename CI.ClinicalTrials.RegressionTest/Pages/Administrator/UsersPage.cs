using System;
using System.Collections;
using System.Collections.Generic;
using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages.Administrator
{
    public class UsersPage : PageBase
    {
        private string uName;
        private string uniqueEmail;
        
        [FindsBy(How = How.Id, Using = "regCreateNewUser")]
        private IWebElement CreateNewUser { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")]
        private IWebElement UserSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='check-box']")]
        private IWebElement AccountEnabled { get; set; }

        [FindsBy(How = How.ClassName, Using = "sorting_1")]
        private IWebElement UserSearchResult_UserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='dataTable']/tbody/tr[1]/td[4]")]
        private IWebElement UserSearchResult_Role { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement EmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "Enabled")]
        private IWebElement UserEnabled { get; set; }

        [FindsBy(How = How.Id, Using = "Description")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Id, Using = "Title")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "Surname")]
        private IWebElement Surname { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        private IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "IsAdministrator")]
        private IWebElement ClinicalTrialAdminUser { get; set; }

        [FindsBy(How = How.Id, Using = "IsCTUUser")]
        private IWebElement ClinicalTrialUnitUser { get; set; }

        [FindsBy(How = How.Id, Using = "CTUs")]
        private IWebElement CT_Units { get; set; }

        [FindsBy(How = How.Id, Using = "IsLHDUser")]
        private IWebElement LocalHealthDistrictUser { get; set; }

        [FindsBy(How = How.Id, Using = "LHDs")]
        private IWebElement LH_Districts { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveUserButton")]
        private IWebElement CreateAndEmailUserButton { get; set; }

        [FindsBy(How = How.Id, Using = "regSaveUserButton")]
        private IWebElement SaveUserButton { get; set; }

        [FindsBy(How = How.Id, Using = "regEditUser")]
        private IWebElement EditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-mini'][3]")]
        private IWebElement LoginAs { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        private IWebElement BackToListButton { get; set; }

        public void ClickonCreateNewUser()
        {
            CreateNewUser.Click();
        }

        public void FillInUserDetailsAndClickCreate(string user)
        {
            uName = "Regression"+ user + PageHelper.RandomNumber(3);
            UserName.SendKeys(uName);
            uniqueEmail = PageHelper.RandomEmailAddress();
            EmailAddress.SendKeys(uniqueEmail);
            Description.SendKeys(PageHelper.RandomString(15));
            Title.SendKeys("Dr");
            FirstName.SendKeys("Test");
            Surname.SendKeys("User");
            PhoneNumber.SendKeys(PageHelper.RandomNumber(10));

            if (user.ToLower().Contains("ctu"))
            {
                ClinicalTrialUnitUser.Click();
                PageHelper.PickAllValuesFromDropdown(CT_Units);
            }
            else if (user.ToLower().Contains("admin"))
            {
                ClinicalTrialAdminUser.Click();
            }
            else if (user.ToLower().Contains("lhd"))
            {
                LocalHealthDistrictUser.Click();
                PageHelper.PickAllValuesFromDropdown(LH_Districts);
            }

            CreateAndEmailUserButton.Click();
            BackToListButton.Click();
        }

        public void SearchAndVerifyTheCreatedUser(string user)
        {
            UserSearch.SendKeys(uName);
            UserSearchResult_UserName.Text.Should().BeEquivalentTo(uName);
            UserSearchResult_Role.Text.Should().Contain(user, "Searched User Role doesn't match up");
        }

        public void SearchAndEditTheCreatedUser(string fromUser, string toUser, string editedEmail)
        {
            UserSearch.SendKeys(uName);
            EditButton.Click();
            EmailAddress.Clear();
            EmailAddress.SendKeys(editedEmail);

            if (fromUser.ToLower().Contains("ctu"))
            {
                ClinicalTrialUnitUser.Click();
            }
            else if (fromUser.ToLower().Contains("admin"))
            {
                ClinicalTrialAdminUser.Click();
            }
            else if (fromUser.ToLower().Contains("lhd"))
            {
                LocalHealthDistrictUser.Click();
            }

            if (toUser.ToLower().Contains("ctu"))
            {
                ClinicalTrialUnitUser.Click();
                PageHelper.PickAllValuesFromDropdown(CT_Units);
            }
            else if (toUser.ToLower().Contains("admin"))
            {
                ClinicalTrialAdminUser.Click();
            }
            else if (toUser.ToLower().Contains("lhd"))
            {
                LocalHealthDistrictUser.Click();
                PageHelper.PickAllValuesFromDropdown(LH_Districts);
            }
            SaveUserButton.Click();
            BackToListButton.Click();
        }

        public void SearchAndLoginAsTheEditedUser()
        {
            UserSearch.SendKeys(uName);
            LoginAs.Click();
        }

        public void DisableTheUser()
        {
            try
            {
                if (AccountEnabled.GetAttribute("checked").Contains("false"))
                {
                    return;
                }
                EditButton.Click();
                UserEnabled.Click();
                SaveUserButton.Click();
                BackToListButton.Click();
            }
            catch (Exception)
            {
                EditButton.Click();
                UserEnabled.Click();
                SaveUserButton.Click();
                BackToListButton.Click();
            }
        }

        public Tuple<string, string> GetCreatedUserDetails()
        {
            return Tuple.Create(uName, uniqueEmail);
        }

        public void SearchTheExistingUser(string username)
        {
            UserSearch.SendKeys(username);
            UserSearchResult_UserName.Text.Should().BeEquivalentTo(username);
        }
    }
}


