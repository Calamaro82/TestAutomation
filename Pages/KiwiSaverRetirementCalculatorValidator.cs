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


        public void AgeHelpIsDisplayed(string validationText)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            Assert.AreEqual(validationText, _pageMap.CurrentAgeMessage.Text);
            _browser.SwitchTo().DefaultContent();
        }
    }
}
