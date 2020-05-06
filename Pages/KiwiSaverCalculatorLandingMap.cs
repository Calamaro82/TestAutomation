using OpenQA.Selenium;

namespace WestpacTestAutomation.Pages
{
    class KiwiSaverCalculatorLandingMap
    {
        private IWebDriver _browser;

        public KiwiSaverCalculatorLandingMap(IWebDriver browser)
        {
            _browser = browser;
        }


        public IWebElement RetirementCalculatorGetStartedButton
        {
            get
            {
                return _browser.FindElement(By.XPath("//a[@class='btn'][@href='/kiwisaver/calculators/kiwisaver-calculator/']"));
            }
        }
    }
}
