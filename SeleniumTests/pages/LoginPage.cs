using OpenQA.Selenium;

namespace SeleniumTests.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement _usernameInput => _driver.FindElement(By.Id("username"));
        private IWebElement _passwordInput => _driver.FindElement(By.Id("password"));
        private IWebElement _loginBtn => _driver.FindElement(By.CssSelector("button[type='Submit']"));
        private IWebElement _errorBanner => _driver.FindElement(By.Id("flash"));

        public void EnterUsername(string username)
        {
            _usernameInput.Clear();
            _usernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _passwordInput.Clear();
            _passwordInput.SendKeys(password);
        }

        public void ClickLogin()
        {
            _loginBtn.Click();
        }

        public void LoginAs(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }
    }
}
