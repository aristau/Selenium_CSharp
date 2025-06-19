using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using SeleniumTests.Pages;
using SeleniumTests.Drivers;

namespace SeleniumTests.Steps
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        [BeforeScenario]
        public void Setup()
        {
            _driver = DriverFactory.CreateDriver();
            _loginPage = new LoginPage(_driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Quit(); //closes and disposes of driver
        }
			
        [Given(@"User navigates to the login page")]
        public void GivenUserNavigatesToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        }

        [When(@"User enters ""(.*)"" and ""(.*)""")]
        public void WhenUserEntersValidCredentials(string username, string password)
        {
            _loginPage.LoginAs(username, password);
        }

        [Then(@"User is directed to the dashboard page")]
        public void ThenUserLandsOnDashboardPage()
        {
            Assert.That(_driver.Url, Does.Contain("secure"));
        }

        // [When(@"User enters invalid credentials")]
        // public void WhenUserEntersInvalidCredentials(string username, string password)
        // {
        //     _scenarioContext.Pending();
        // }

        // [Then(@"An invalid username error message appears")]
        // public void ThenInvalidUserNameErrorShows()
        // {
        //     _scenarioContext.Pending();
        // }

        // [Then(@"An invalid password error message appears")]
        // public void ThenInvalidPasswordErrorShows()
        // {
        //     _scenarioContext.Pending();
        // }

    }
}