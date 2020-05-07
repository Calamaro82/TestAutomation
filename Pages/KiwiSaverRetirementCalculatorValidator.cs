using NUnit.Framework;
using OpenQA.Selenium;

namespace WestpacTestAutomation.Pages
{
    class KiwiSaverRetirementCalculatorValidator
    {
        private IWebDriver _browser;
        private KiwiSaverRetirementCalculatorMap _pageMap;


        public KiwiSaverRetirementCalculatorValidator(IWebDriver browser)
        {
            _browser = browser;
            _pageMap = new KiwiSaverRetirementCalculatorMap(browser);
        }


        public void AgeInfoMessageIs(string validationText)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            Assert.AreEqual(validationText, _pageMap.CurrentAgeMessage.Text);
            _browser.SwitchTo().DefaultContent();
        }


        public void ProjectionResultIsVisible()
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            Assert.IsTrue(_pageMap.ResultsPanelTitle.Displayed);
            _browser.SwitchTo().DefaultContent();
        }
    }
}
