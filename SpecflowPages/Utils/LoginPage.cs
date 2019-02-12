using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
  public class LoginPage
    {
        public static void LoginStep()
        {
            Driver.NavigateUrl();
            Thread.Sleep(1000);

            //Enter Url
           // Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a[2]")).Click();
            Driver.driver.FindElement(By.XPath("//a[@class='item']")).Click();
           
            //Enter Username
           // Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[1]/form/div[1]/input")).SendKeys("jigneshpatel1987@gmail.com");
            Driver.driver.FindElement(By.Name("email")).SendKeys("jigneshpatel1987@gmail.com");


            //Enter password
            // Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[1]/form/div[2]/input")).SendKeys("Test@123");
            Driver.driver.FindElement(By.Name("password")).SendKeys("Test@123");
            Thread.Sleep(1000);
            //Click on Login Button
            //Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[1]/form/div[4]/div")).Click();
            Driver.driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();

            //string msg = "Add New Job";
            //string Actualmsg = Driver.driver.FindElement(By.XPath("//*[@id='addnewjob']")).Text;

            //if (msg == Actualmsg)
            //{
            //Console.WriteLine("Test Passed");
            //CommonMethods.ExtentReports();
            //Thread.Sleep(500);
            //test = CommonMethods.extent.StartTest("Login with valid data");
            //Thread.Sleep(1000);
            //CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
            //SaveScreenShotClass.SaveScreenshot(Driver.driver, "HomePage");
            //}
            //else
            //{
            //Console.WriteLine("Test Failed");
            //CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            //}
        }

    }
}
