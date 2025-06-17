using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class GoogleTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void SearchInGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Selenium C#");
            searchBox.Submit();

            Assert.That(driver.Title, Does.Contain("Google"));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
