using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using System.Threading;
using WestpacTestAutomation.Libraries;
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
            TopNavigationBar topNavigationBarObject = new TopNavigationBar(_browser);
            topNavigationBarObject.HoverKiwiSaverOption();
            topNavigationBarObject.ClickKiwiSaverCalculatorButton();

            KiwiSaverCalculatorLanding kiwiSaverCalculatorLandingObject = new KiwiSaverCalculatorLanding(_browser);
            kiwiSaverCalculatorLandingObject.ClickGetStartedButton();

            KiwiSaverRetirementCalculator kiwiSaverRetirementCalculatorObject = new KiwiSaverRetirementCalculator(_browser);
            kiwiSaverRetirementCalculatorObject.ClickCurrentAgeHelpButton();
            kiwiSaverRetirementCalculatorObject.Validations().AgeHelpIsDisplayed("This calculator has an age limit of 64 years old as you need to be under the age of 65 to join KiwiSaver.");
        }


        [TearDown]
        public void TearDown()
        {
            _browser.Close();
        }
    }
}
