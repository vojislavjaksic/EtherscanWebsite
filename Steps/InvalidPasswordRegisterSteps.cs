using System;
using EtherscanWebsite.Helpers;
using EtherscanWebsite.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EtherscanWebsite.Steps
{
    [Binding]
    public class InvalidPasswordRegisterSteps: Base
    {
        Utilities ut = new Utilities(Driver);

        [When(@"user fills the email field with '(.*)' and fills password field with '(.*)' password")]
        public void WhenUserFillsTheEmailFieldWithAndFillsPasswordFieldWithPassword(string email, string password)
        {
            RegisterPage rp = new RegisterPage(Driver);
            ut.EnterTextInElement(rp.username, ut.GenerateRandomName());
            ut.EnterTextInElement(rp.email, email);
            ut.EnterTextInElement(rp.confemail, email);
            ut.EnterTextInElement(rp.password, password);
        }

        [Then(@"the he should able get an '(.*)' message")]
        public void ThenTheHeShouldAbleGetAnMessage(string message)
        {
            RegisterPage rp = new RegisterPage(Driver);
            Assert.That(ut.ReturnTextFromElement(rp.passworderr), Does.Contain(message), "");

        }
    }
}
