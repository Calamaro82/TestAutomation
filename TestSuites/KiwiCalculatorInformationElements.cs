using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using WestpacTestAutomation.Libraries;
using WestpacTestAutomation.Pages;
using WestpacTestAutomation.Flow;

namespace WestpacTestAutomation
{
    class KiwiCalculatorInformationElements
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
        public void AgeInformationText()
        {
            Navigation.NavigateToKiwiSaverRetirementCalculator(_browser);

            KiwiSaverRetirementCalculator kiwiSaverRetirementCalculatorObject = new KiwiSaverRetirementCalculator(_browser);
            kiwiSaverRetirementCalculatorObject.ClickCurrentAgeHelpButton();
            kiwiSaverRetirementCalculatorObject.Validations().AgeInfoMessageIs("This calculator has an age limit of 64 years old as you need to be under the age of 65 to join KiwiSaver.");
        }


        [TearDown]
        public void TearDown()
        {
            _browser.Close();
        }
    }
}
