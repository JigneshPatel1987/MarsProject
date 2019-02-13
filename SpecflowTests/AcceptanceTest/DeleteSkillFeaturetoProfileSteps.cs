using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class DeleteSkillFeaturetoProfileSteps
    {
        [Given(@"I have Clicked on the Skill Tab under Profile page")]
        public void GivenIHaveClickedOnTheSkillTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }

        [When(@"I can Delete Skill under Profile page")]
        public void WhenICanDeleteSkillUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Skill Tab
            Driver.driver.FindElement(By.XPath("//a[contains(.,'Skills')]")).Click();

            //Wait
            Thread.Sleep(1500);

            //Click on Delete Icon
            Driver.driver.FindElement(By.XPath("/ html / body / div[1] / div / section[2] / div / div / div / div[3] / form / div[3] / div / div[2] / div / table / tbody[1] / tr / td[3] / span[2]")).Click();

        }

        [Then(@"that deleted skill should be removed from my profile Listing")]
        public void ThenThatDeletedSkillShouldBeRemovedFromMyProfileListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}
