using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace EtherscanWebsite.Helpers
{
    [Binding]
    public class Base
    {
        public static IWebDriver Driver { get; set; }
        //test

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            var url = "https://etherscan.io/register";
            Driver.Url = url;
        }
        [AfterScenario]
        public static void AfterScenario()
         {
            Driver.Quit();

        }
    }
}