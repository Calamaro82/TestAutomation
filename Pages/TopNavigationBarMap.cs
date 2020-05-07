using OpenQA.Selenium;

namespace WestpacTestAutomation.Pages
{
    class TopNavigationBarMap
    {
        private IWebDriver _browser;

        public TopNavigationBarMap(IWebDriver browser)
        {
            _browser = browser;
        }


        public IWebElement KiwiSaverOption
        {
            get
            {
                return _browser.FindElement(By.Id("ubermenu-section-link-kiwisaver-ps"));
            }
        }


        public IWebElement KiwiSaverCalculatorButton
        {
            get
            {
                return _browser.FindElement(By.Id("ubermenu-item-cta-kiwisaver-calculators-ps"));
            }
        }
    }
}
