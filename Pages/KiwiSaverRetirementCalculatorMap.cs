using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WestpacTestAutomation.Pages
{
    class KiwiSaverRetirementCalculatorMap
    {
        private IWebDriver _browser;


        public KiwiSaverRetirementCalculatorMap(IWebDriver browser)
        {
            _browser = browser;
        }


        public IWebElement CurrentAgeInput
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='CurrentAge']//input"));
            }
        }


        public IWebElement SalaryPerYearInput
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='AnnualIncome']//input"));
            }
        }


        public IWebElement VoluntaryContributionInput
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='VoluntaryContributions']//input"));
            }
        }


        public IWebElement KiwiSaverBalanceInput
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='KiwiSaverBalance']//input"));
            }
        }


        public IWebElement ContributionFrequencySelector
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='VoluntaryContributions']//div[@class='control-well'][@ng-click]"));
            }
        }


        public IWebElement ContributionFrequencyOption(string contributionFrequencyOption)
        {
            return _browser.FindElement(By.XPath(string.Format("//div[@help-id='VoluntaryContributions']//span[text()='{0}']", contributionFrequencyOption)));
        }


        public IWebElement EmploymentStatusSelector
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='EmploymentStatus']//div[@class='control-well']"));
            }
        }


        public IWebElement EmploymentStatusOption(string employmentOption)
        {
            return _browser.FindElement(By.XPath(string.Format("//div[@help-id='EmploymentStatus']//span[text()='{0}']", employmentOption)));
        }


        public IWebElement PIRSelector
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='PIRRate']//div[@class='control-well']"));
            }
        }


        public IWebElement PIROption(string PIR)
        {
            return _browser.FindElement(By.XPath(string.Format("//div[@help-id='PIRRate']//span[text()='{0}']", PIR)));
        }


        public IWebElement KiwiSaverContributionRadioButton(string contributionOption)
        {
            return _browser.FindElement(By.XPath(string.Format("//div[@help-id='KiwiSaverMemberContribution']//span[text()='{0}']", contributionOption)));
        }


        public IWebElement RiskProfile(string riskProfileOption)
        {
            return _browser.FindElement(By.XPath(string.Format("//div[@help-id='RiskProfile']//span[text()='{0}']", riskProfileOption)));
        }


        public IWebElement CurrentAgeHelpButton
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@help-id='CurrentAge']/button"));
            }
        }


        public IWebElement ViewProjectionsButton
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@class='field-group-set']/button"));
            }
        }


        public IWebElement CalculatorIFrame
        {
            get
            {
                var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(10));
                wait.Until(brw => brw.FindElement(By.XPath("//div[@id='calculator-embed']/iframe")));
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


        public IWebElement ResultsPanel
        {
            get
            {
                return _browser.FindElement(By.XPath("//div[@ng-show='ctrl.view.resultsPanelRevealed']"));
            }
        }
    }
}
