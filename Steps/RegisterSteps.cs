using System;
using System.Threading;
using EtherscanWebsite.Helpers;
using EtherscanWebsite.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EtherscanWebsite.Steps
{
    [Binding]
    public class RegisterSteps: Base
    {
        Utilities ut = new Utilities(Driver);

        public  Credientials credientials;
        

        public RegisterSteps(Credientials credientials)
        {
            this.credientials = credientials;
            
        }


        [When(@"fills the all required fields")]
        public void WhenFillsTheAllRequiredFields()
        {
            RegisterPage rp = new RegisterPage(Driver);
            ut.EnterTextInElement(rp.username, ut.GenerateRandomName());
            credientials.EmailConfirm = ut.GenerateRandomEmail();
            ut.EnterTextInElement(rp.email, credientials.EmailConfirm);
       
          

            ut.EnterTextInElement(rp.confemail, credientials.EmailConfirm);
            credientials.PasswordConfirm = ut.GenerateRandomPassword();
            ut.EnterTextInElement(rp.password, credientials.PasswordConfirm);
            ut.EnterTextInElement(rp.confpassword, credientials.PasswordConfirm);
            ut.ClickOnElement(rp.agree);
            ut.ClickOnElement(rp.cookie);
            By iframe = By.XPath("//*[@title='reCAPTCHA']");
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));
            ut.ClickOnElement(rp.captcha);
            Thread.Sleep(5000); //when tackling the captcha code I have opted-in to implemented a break, that will ensure the user to manualy solve the captcha puzzle before continuing the test process.


        }
        
        [Then(@"the he should be able to create an account")]
        public void ThenTheHeShouldBeAbleToCreateAnAccount()
        {
            Driver.SwitchTo().DefaultContent();
            RegisterPage rp = new RegisterPage(Driver);
            ut.ClickOnElement(rp.submit);
            
        }
        [Then(@"the user should be able to see '(.*)' message")]
        public void ThenTheUserShouldBeAbleToSeeMessage(string message)
        {
            RegisterPage rp = new RegisterPage(Driver);
            Assert.That(ut.ReturnTextFromElement(rp.verifypage), Does.Contain(message), "");
        }


    }
}
