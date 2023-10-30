using shaistha_onboarding.Pages;
using shaistha_onboarding.Utilities;
using System;
using TechTalk.SpecFlow;

namespace shaistha_onboarding.StepDefinitions
{
    [Binding]
    public class SkillsFeatureStepDefinitions:CommonDriver
    {
        SkillsTab skillsTabPageObj = new SkillsTab();

        [When(@"I navigate to skills tab to add new skills")]
        public void WhenINavigateToSkillsTabToAddNewSkills()
        {
            skillsTabPageObj.Skills(driver);
        }

        [Then(@"the new skills should be added successfully")]
        public void ThenTheNewSkillsShouldBeAddedSuccessfully()
        {
           
        }
    }
}
