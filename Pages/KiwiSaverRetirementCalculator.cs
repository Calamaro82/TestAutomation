using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

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
            ClickFrameElement(_pageMap.CurrentAgeHelpButton);
            _browser.SwitchTo().DefaultContent();
        }


        private void ClickFrameElement(IWebElement frameElement)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(frameElement);
            wait.Timeout = TimeSpan.FromSeconds(4);

            Func<IWebElement, bool> FrameElementClickable = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                try
                {
                    ele.Click();
                    return true;
                }
                catch (ElementClickInterceptedException e)
                {
                    return false;
                }
            });

            wait.Until(FrameElementClickable);
        }
    }
}
