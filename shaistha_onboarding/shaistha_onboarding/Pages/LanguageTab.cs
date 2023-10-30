using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using shaistha_onboarding.Utilities;
using NUnit.Framework;
using System.Runtime.InteropServices;
using Gherkin;
using TechTalk.SpecFlow.Events;

namespace shaistha_onboarding.Pages
{
    public class LanguageTab : Wait
    {
        public void Languages(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);

            IWebElement addNewLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageButton.Click();

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguageTextbox.SendKeys("Malayalam");

            SelectElement languageLevelDropdownList = new SelectElement(driver.FindElement(By.Name("level")));
            languageLevelDropdownList.SelectByValue("Basic");

            IWebElement addLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguageButton.Click();

        }

        public void AlertWindow(IWebDriver driver)
        {
            string expectedMessage = "Hindi has been added to your languages";
            string text = driver.SwitchTo().Alert().Text;
            Assert.That(expectedMessage == text , " Language is added successfully");
         
        }
    }
    
}
