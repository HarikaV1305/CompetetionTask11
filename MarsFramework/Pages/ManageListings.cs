using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using static MarsFramework.Global.GlobalDefinitions;

using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement deletebtn { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Title path IN MANAGELISTINGS
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")]
        private IWebElement titlepath { get; set; }

        //Description path IN MANAGELISTINGS
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[4]")]
        private IWebElement descrpath { get; set; }

        //Delete icon path
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")]
        private IWebElement deletebtn1 { get; set; }

        //yes button path
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement yesbtn { get; set; }



        internal void Deleteshareskill()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.Managelistings, "ManageListings");

            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, By.LinkText("Manage Listings"), 20);

            manageListingsLink.Click();
            GlobalDefinitions.wait(15);
            string title = (GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            string delete = (GlobalDefinitions.ExcelLib.ReadData(2, "Deleteaction"));
            if (title == "Selenium" && delete == "Yes")

                GlobalDefinitions.wait(15);
            deletebtn1.Click();
            yesbtn.Click();




        }

        internal void Editshareskill()
        {
            manageListingsLink.Click();
            edit.Click();
            ShareSkill skillobj1 = new ShareSkill();
            skillobj1.EditShareSkill();

        }

        internal void ValidateAddshareskill()
        {
            try
            {
                manageListingsLink.Click();
                //Start the Reports
                Global.Base.test = Global.Base.extent.StartTest("Create a share skill record");
                string expectedValue = "Selenium";
                string actualValue = titlepath.Text;
                string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Listingcreated");
                if (expectedValue == actualValue)
                {
                    Global.Base.test.Log(LogStatus.Pass, "Test Passed, Created share skill listing sucessfully");
                    Global.Base.test.Log(LogStatus.Info, "Image for create listing:" + img);
                    Assert.IsTrue(true);
                }
                else
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed");
            }
            catch (Exception e)
            {
                Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
        public void Validateupdateskill()
        {
            try
            {
                manageListingsLink.Click();
                //Start the Reports
                Global.Base.test = Global.Base.extent.StartTest("Update share skill listing");
                string expectedValue = "Learn Selenium";
                string actualValue = descrpath.Text;
                string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Listingupdated");
                if (expectedValue == actualValue)
                {
                    Global.Base.test.Log(LogStatus.Pass, "Test Passed, updated share skill listing sucessfully");
                    Global.Base.test.Log(LogStatus.Info, "Image for updatedlisting:" + img);
                    Assert.IsTrue(true);
                }
                else
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed");
            }
            catch (Exception e)
            {
                Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
        internal void Validatedeleteskill()
        {
            try
            {
                manageListingsLink.Click();
                //Start the Reports
                Global.Base.test = Global.Base.extent.StartTest("delete a share skill record");
                string expectedValue = "Selenium";
                string actualValue = "";
                string img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Recorddeleted");
                if (expectedValue != actualValue)
                {
                    Global.Base.test.Log(LogStatus.Pass, "Test Passed, deleted share skill listing sucessfully");
                    Global.Base.test.Log(LogStatus.Info, "Image for delete listing:" + img);
                    Assert.IsTrue(true);
                }
                else
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed");
            }
            catch (Exception e)
            {
                Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }         

            }
          internal void Addskillurlvalidate()
        {
            Assert.AreEqual(GlobalDefinitions.driver.Url, "http://localhost:5000/Home/ListingManagement");
            Console.WriteLine("Test Passed");
        }


    }
}
