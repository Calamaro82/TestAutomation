using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using WestpacTestAutomation.Library;
using WestpacTestAutomation.Pages;

namespace WestpacTestAutomation
{
    class KiwiCalculator
    {
        IWebDriver _browser;


        [SetUp]
        public void Setup()
        {
            string _env = TestContext.Parameters.Get("env", "prod");
            WestpacLibraries.VerifySettingExist(ConfigurationManager.AppSettings[_env], "Web App Url");
            _browser = new FirefoxDriver();

            WestpacLanding westpacLandingObject = new WestpacLanding(_browser, _env);
            westpacLandingObject.Navigate();
        }


        [Test]
        public void NewTest()
        {
            Console.WriteLine("doggo");
        }


        [TearDown]
        public void TearDown()
        {
            _browser.Close();
        }
    }
}
