using OpenQA.Selenium.Chrome;
using shaistha_onboarding.Pages;
using shaistha_onboarding.Utilities;
using System;
using TechTalk.SpecFlow;

namespace shaistha_onboarding.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions:CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        LanguageTab languageTabPageObj = new LanguageTab();

        [Given(@"I logged into website successfully")]
        public void GivenILoggedIntoWebsiteSuccessfully()
        {
            driver = new ChromeDriver();


            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate language tab to add new language")]
        public void WhenINavigateLanguageTabToAddNewLanguage()
        {
            languageTabPageObj.Languages(driver);
        }

        [Then(@"the new language should be added successfully")]
        public void ThenTheNewLanguageShouldBeAddedSuccessfully()
        {
            
        }
    }
}
