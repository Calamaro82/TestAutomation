using OpenQA.Selenium;

namespace WestpacTestAutomation.Pages
{
    class KiwiSaverRetirementCalculator
    {
        private IWebDriver _browser;
        private KiwiSaverRetirementCalculatorMap _pageMap;


        public KiwiSaverRetirementCalculator(IWebDriver browser)
        {
            _browser = browser;
            _pageMap = new KiwiSaverRetirementCalculatorMap(browser);
        }


        public KiwiSaverRetirementCalculatorValidator Validations()
        {
            return new KiwiSaverRetirementCalculatorValidator(_browser);
        }


        public void ClickCurrentAgeHelpButton()
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            _pageMap.CurrentAgeHelpButton.Click();
            _browser.SwitchTo().DefaultContent();
        }
    }
}
