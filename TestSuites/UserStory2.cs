using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using WestpacTestAutomation.Flow;
using WestpacTestAutomation.Libraries;
using WestpacTestAutomation.Pages;

namespace WestpacTestAutomation.TestSuites
{
    class UserStory2
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
        public void Scenario1()
        {
            Navigation.NavigateToKiwiSaverRetirementCalculator(_browser);

            KiwiSaverRetirementCalculator kiwiSaverRetirementCalculatorObject = new KiwiSaverRetirementCalculator(_browser);
            kiwiSaverRetirementCalculatorObject.InputCurrentAge("30");
            kiwiSaverRetirementCalculatorObject.SelectEmploymentStatus("Employed");
            kiwiSaverRetirementCalculatorObject.InputSalaryPerYear("82000");
            kiwiSaverRetirementCalculatorObject.SelectKiwiSaverContribution("4%");
            kiwiSaverRetirementCalculatorObject.SelectPIR("17.5%");
            kiwiSaverRetirementCalculatorObject.SelectRiskProfile("High");

            kiwiSaverRetirementCalculatorObject.Validations().ViewProjectionsButtonIsEnabled();
        }


        [TearDown]
        public void TearDown()
        {
            _browser.Close();
        }
    }
}
