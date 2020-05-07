using OpenQA.Selenium;
using WestpacTestAutomation.Pages;

namespace WestpacTestAutomation.Flow
{
    public static class Navigation
    {
        public static void NavigateToKiwiSaverRetirementCalculator(IWebDriver browser)
        {
            TopNavigationBar topNavigationBarObject = new TopNavigationBar(browser);
            topNavigationBarObject.HoverKiwiSaverOption();
            topNavigationBarObject.ClickKiwiSaverCalculatorButton();

            KiwiSaverCalculatorLanding kiwiSaverCalculatorLandingObject = new KiwiSaverCalculatorLanding(browser);
            kiwiSaverCalculatorLandingObject.ClickGetStartedButton();
        }
    }
}
