using OpenQA.Selenium;
using System.Configuration;

namespace WestpacTestAutomation.Pages
{
    class WestpacLanding
    {
        private string _URL;
        private IWebDriver _browser;


        public WestpacLanding(IWebDriver browser, string environment)
        {
            _browser = browser;
            _URL = ConfigurationManager.AppSettings[environment.ToLower()];
        }


        public void Navigate()
        {
            _browser.Navigate().GoToUrl(_URL);
        }
    }
}
