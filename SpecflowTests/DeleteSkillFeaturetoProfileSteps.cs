using System;
using TechTalk.SpecFlow;

namespace SpecflowTests
{
    [Binding]
    public class DeleteSkillFeaturetoProfileSteps
    {
        [Given(@"I have Clicked on the Skill Tab under ProfilePage")]
        public void GivenIHaveClickedOnTheSkillTabUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Can Delete Skill under Profile Page")]
        public void WhenICanDeleteSkillUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"that deleted skill should be removed from my profile Listings")]
        public void ThenThatDeletedSkillShouldBeRemovedFromMyProfileListings()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
