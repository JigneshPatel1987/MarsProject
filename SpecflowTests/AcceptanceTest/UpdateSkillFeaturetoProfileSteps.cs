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
    public class UpdateSkillFeaturetoProfileSteps
    {
        [Given(@"I have Clicked on the Skill Tab under Profile Page")]
        public void GivenIHaveClickedOnTheSkillTabUnderProfilePage()
        {
           

            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]")).Click();
            
        }

        [When(@"I can Update Skill under Profle Page")]
        public void WhenICanUpdateSkillUnderProflePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Skill Tab
            Driver.driver.FindElement(By.XPath("//a[contains(.,'Skills')]")).Click();
            

            //Wait
            Thread.Sleep(1500);

            //Click on Update Icon
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='outline write icon']")).Click();

            //div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='outline write icon']

            //Update Skill
            Driver.driver.FindElement(By.XPath("//input[@name='name']")).Clear();
            Driver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("Hindi");
            //if (Driver.driver.FindElement(By.XPath("//input[@name='name']")).Text == "English")
            //{
            //    Driver.driver.FindElement(By.XPath("//input[@name='name']")).Clear();
            //    Driver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("Hindi");
            //}

            ////Click on Skill Level
            //Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            ////Choose the Skill level

            //IWebElement skill = Driver.driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[text()='Expert']"))[4];
            //skill.Click();

            //Wait
            //Thread.Sleep(1500);

            //Click on Update button
            Driver.driver.FindElement(By.XPath("//input[@value='Update']")).Click();

        }

        [Then(@"that Updated skill should be displayed on my Profile Listings")]
        public void ThenThatUpdatedSkillShouldBeDisplayedOnMyProfileListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "Hindi";
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
