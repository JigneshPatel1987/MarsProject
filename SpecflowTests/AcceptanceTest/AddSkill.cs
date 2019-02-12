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
    public class AddSkillFeaturetoProfileSteps
    {
        [Given(@"I have Clicked on the skill Tab under Profile Page")]
        public void GivenIHaveClickedOnTheSkillTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

        }

        [When(@"I add a new Skill")]
        public void WhenIAddANewSkill()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Skill Tab
            Driver.driver.FindElement(By.XPath("//a[contains(.,'Skills')]")).Click();

            //Wait
            Thread.Sleep(1500);

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

            //Add Skill
            Driver.driver.FindElement(By.XPath("//div[@class='five wide field']/input[1]")).SendKeys("English");

            //Click on Skill Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Choose the Skill level
            IWebElement skill = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option"))[1];

            skill.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button ']")).Click();

        }


        [Then(@"that skill should be displayed on my Profile Listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyProfileListings()
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
