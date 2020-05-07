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


        public void SelectKiwiSaverContribution(string contribution)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            ClickFrameElement(_pageMap.KiwiSaverContributionRadioButton(contribution));
            _browser.SwitchTo().DefaultContent();
        }


        public void SelectRiskProfile(string riskProfile)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            ClickFrameElement(_pageMap.RiskProfile(riskProfile));
            _browser.SwitchTo().DefaultContent();
        }


        public void InputCurrentAge(string ageString)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            ClickFrameElement(_pageMap.CurrentAgeInput);
            _pageMap.CurrentAgeInput.SendKeys(ageString);
            _browser.SwitchTo().DefaultContent();
        }


        public void SelectPIR(string PIR)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            ClickFrameElement(_pageMap.PIRSelector);
            ClickFrameElement(_pageMap.PIROption(PIR));
            _browser.SwitchTo().DefaultContent();
        }


        public void SelectEmploymentStatus(string employmentStatus)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            ClickFrameElement(_pageMap.EmploymentStatusSelector);
            ClickFrameElement(_pageMap.EmploymentStatusOption(employmentStatus));
            _browser.SwitchTo().DefaultContent();
        }


        public void InputSalaryPerYear(string salaryPerYearString)
        {
            _browser.SwitchTo().Frame(_pageMap.CalculatorIFrame);
            ClickFrameElement(_pageMap.SalaryPerYearInput);
            _pageMap.SalaryPerYearInput.SendKeys(salaryPerYearString);
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
