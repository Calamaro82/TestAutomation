using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

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
                var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(10));
                wait.Until(brw => brw.FindElement(By.Id("ubermenu-item-cta-kiwisaver-calculators-ps")).Displayed);
                return _browser.FindElement(By.Id("ubermenu-item-cta-kiwisaver-calculators-ps"));
            }
        }
    }
}
