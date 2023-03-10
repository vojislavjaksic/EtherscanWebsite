using System;
using EtherscanWebsite.Helpers;
using EtherscanWebsite.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EtherscanWebsite.Steps
{
    [Binding]
    public class InvalidEmailRegisterSteps: Base
    {
        Utilities ut = new Utilities(Driver);

        [When(@"fills the email field with '(.*)'")]
        public void WhenFillsTheEmailFieldWith(string Email)
        {
            RegisterPage rp = new RegisterPage(Driver);
            ut.EnterTextInElement(rp.username, ut.GenerateRandomName());
            ut.EnterTextInElement(rp.email, Email);
            
        }

        
        [Then(@"the he should get an '(.*)' message")]
        public void ThenTheHeShouldGetAnMessage(string message)
        {
            RegisterPage rp = new RegisterPage(Driver);
            Assert.That(ut.ReturnTextFromElement(rp.invemail), Does.Contain(message), "");
        }




    }
}
