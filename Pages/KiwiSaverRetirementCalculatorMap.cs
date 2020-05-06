using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace WestpacTestAutomation.Pages
{
    class KiwiSaverRetirementCalculatorMap
    {
        private IWebDriver _browser;

        public KiwiSaverRetirementCalculatorMap(IWebDriver browser)
        {
            _browser = browser;
        }


        public IWebElement CurrentAgeHelpButton
        {
            get
            {
                Thread.Sleep(1000);
                var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(10));
                wait.Until(brw => brw.FindElement(By.XPath("//div[@help-id='CurrentAge']/button")).Displayed);
                return _browser.FindElement(By.XPath("//div[@help-id='CurrentAge']/button"));
            }
        }


        public IWebElement CalculatorIFrame
        {
            get
            {
                var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(10));
                wait.Until(brw => brw.FindElement(By.XPath("//div[@id='calculator-embed']/iframe")).Displayed);
                return _browser.FindElement(By.XPath("//div[@id='calculator-embed']/iframe"));
            }
        }


        public IWebElement CurrentAgeMessage
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='CurrentAge']//div[@class='message-row ng-scope']/div/p"));
            }
        }
    }
}
