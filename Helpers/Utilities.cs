using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace EtherscanWebsite.Helpers
{
    public class Utilities

    {
        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();
        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterTextInElement(By locator, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);

        }
        public void ClickOnElement(By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

       
        public string ReturnTextFromElement(By locator)
        {
            return driver.FindElement(locator).GetAttribute("textContent");
        }

        public string GenerateRandomName()
        {
            return string.Format("name{0}", RandomName.Next(1, 99));
        }

        public string GenerateRandomEmail()
        {
            return string.Format("email{0}@mailinator.com", RandomName.Next(10000, 100000));
        }

        public string GenerateRandomPassword()
        {
            return string.Format("password{0}", RandomName.Next(1, 99));
        }

        public IWebElement TextPresentInElement(string text)
        {
            By textelement = By.XPath("//*[contains(text(),'" + text + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textelement));
        }
    }
}
