## Specflow NUnit - C# Framework

**C# Framework to automate tests using Selenium WebDriver**

Test Framework was designed in C# following BDD style to propose a common way how people should create Acceptance tests.

**It provides following features:**
- Ready for parallel tests execution
- Possibility to use MSTest, NUnit or xUNIT framework --[NUnit framework is implemented]
- Specflow ready
- Written entirely in C#
- Allows to use Chrome, Firefox, Safari or Internet Explorer
- Automatically waits when locating element for specified time and conditions
- Page Object Pattern
- Possibility to take full desktop or browser screen shot on failures

Specflow Feature:

```csharp
Feature: Administration
	In order to restrict the access to various features
	As an Administrator
	I want to create users with multiple roles

@Users @Regression
Scenario Outline: 27340 - Create new User
	Given I login to Clinical Trial Application as Administrator
	When I create new <UserType> user from the user menu option
	Then I should see the <User> user created successfully

	Examples:
	| UserType | User                  |
	| CTU      | Clinical Trials Unit  |
	| LHD      | Local Health District |

@Users @Regression
Scenario: 27347 - Create new Sponsor
	Given I login to Clinical Trial Application as Administrator
	When I create new sponsor from the menu option
	Then I should see the sponsor created successfully

```

NUnit Example Page Object:

```csharp
namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class LoginPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log On']")]
        private IWebElement Submit { get; set; }

        /// <summary>
        /// Launches the browser with the given URL.
        /// </summary>
        public void LaunchTheApplication()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["RegressionTest.URL"]);
        }

        /// <summary>
        /// Logins to application.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pwd">The password.</param>
        public void LoginToApplication(string user, string pwd)
        {
            UserName.SendKeys(user);
            Password.SendKeys(pwd);
            Submit.Click();
        }
```
