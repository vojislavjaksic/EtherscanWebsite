using System;
using System.Threading;
using EtherscanWebsite.Helpers;
using EtherscanWebsite.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace EtherscanWebsite.Steps
{
    [Binding]
    public class BlankRegisterSteps: Base
    {
        Utilities ut = new Utilities(Driver);

        [When(@"user clicks on register button with all mandatory fields left blank")]
        public void WhenUserClicksOnRegisterButtonWithAllMandatoryFieldsLeftBlank()
        {
            RegisterPage rp = new RegisterPage(Driver);
                        
            IWebElement element = Driver.FindElement(rp.submit);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
           
            Thread.Sleep(1000);
            ut.ClickOnElement(rp.cookie);            
            ut.ClickOnElement(rp.submit);


        }
        
       
        [Then(@"the he should get an error message '(.*)'")]
        public void ThenTheHeShouldGetAnErrorMessage(string message)
        {
            RegisterPage rp = new RegisterPage(Driver);
            Assert.That(ut.ReturnTextFromElement(rp.termserror), Does.Contain(message), "");

        }

    }
}
