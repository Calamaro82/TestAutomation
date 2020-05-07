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


        public void ViewProjectionsButtonIsEnabled()
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            Assert.IsTrue(_pageMap.ViewProjectionsButton.Enabled);
            _browser.SwitchTo().DefaultContent();
        }
    }
}
