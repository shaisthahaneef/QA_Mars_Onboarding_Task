using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using shaistha_onboarding.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaistha_onboarding.Pages
{
    public class SkillsTab: Wait
    {
        public void Skills(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath" , "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            IWebElement addNewSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkills.Click();

            IWebElement addSkillsTextbox = driver.FindElement(By.Name("name"));
            addSkillsTextbox.SendKeys("Testing");

            SelectElement skillLevelDropdownList = new SelectElement(driver.FindElement(By.Name("level")));
            skillLevelDropdownList.SelectByValue("Beginner");

            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillButton.Click();
        }
    }
}
