using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WestpacTestAutomation.Pages
{
    class TopNavigationBar
    {
        private IWebDriver _browser;
        private TopNavigationBarMap _pageMap;

        public TopNavigationBar(IWebDriver browser)
        {
            _browser = browser;
            _pageMap = new TopNavigationBarMap(browser);
        }


        public void HoverKiwiSaverOption()
        {
            Actions action = new Actions(_browser);
            action.MoveToElement(_pageMap.KiwiSaverOption).Build().Perform();
        }


        public void ClickKiwiSaverCalculatorButton()
        {
            var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(10));
            wait.Until(brw => _pageMap.KiwiSaverCalculatorButton.Displayed);
            _pageMap.KiwiSaverCalculatorButton.Click();
        }
    }
}
