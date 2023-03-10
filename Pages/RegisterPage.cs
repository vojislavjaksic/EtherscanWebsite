using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EtherscanWebsite.Pages
{
    class RegisterPage
    {
        readonly IWebDriver driver;

        public By page = By.Id("body");
        public By username = By.Id("ContentPlaceHolder1_txtUserName");
        public By email = By.Id("ContentPlaceHolder1_txtEmail");
        public By confemail = By.Name("ctl00$ContentPlaceHolder1$txtConfirmEmail");
        public By password = By.Id("ContentPlaceHolder1_txtPassword");
        public By confpassword = By.Name("ctl00$ContentPlaceHolder1$txtPassword2");
        public By agree = By.Id("ContentPlaceHolder1_MyCheckBox");
        public By captcha = By.ClassName("recaptcha-checkbox");
        public By submit = By.Id("ContentPlaceHolder1_btnRegister");
        public By invemail = By.Id("ContentPlaceHolder1_txtEmail-error");
        public By cookie = By.Id("btnCookie");
        public By passworderr = By.Id("ContentPlaceHolder1_txtPassword-error");
        public By usernameerror = By.Id("ContentPlaceHolder1_txtUserName-error");
        public By confemailerror = By.Id("ContentPlaceHolder1_txtConfirmEmail-error");
        public By confpassworderr = By.Id("ContentPlaceHolder1_txtPassword2-error");
        public By termserror = By.Id("ctl00$ContentPlaceHolder1$MyCheckBox-error");
        public By verifypage = By.Id("ctl00");

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page));

        }

    }
}
