using OpenQA.Selenium;

namespace SeleniumTests.Pages
{
    public class DashboardPage
    {
        private readonly IWebDriver _driver;

        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement _bannerMsg => _driver.FindElement(By.Id("flash"));
        private IWebElement _passwordInput => _driver.FindElement(By.Id("password"));
        private IWebElement _logoutBtn => _driver.FindElement(By.CssSelector("a[href='/logout']"));

        public void ClickLogout()
        {
            _logoutBtn.Click();
        }
    }
}
