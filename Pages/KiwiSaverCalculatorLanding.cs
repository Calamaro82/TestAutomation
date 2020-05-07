using OpenQA.Selenium;

namespace WestpacTestAutomation.Pages
{
    class KiwiSaverCalculatorLanding
    {
        private IWebDriver _browser;
        private KiwiSaverCalculatorLandingMap _pageMap;


        public KiwiSaverCalculatorLanding(IWebDriver browser)
        {
            _browser = browser;
            _pageMap = new KiwiSaverCalculatorLandingMap(browser);
        }

        public void ClickGetStartedButton()
        {
            _pageMap.RetirementCalculatorGetStartedButton.Click();
        }
    }
}
