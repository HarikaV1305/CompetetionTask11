using AutoItX3Lib;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //path for radio btn "Hourly"
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/label")]
        private IWebElement Hourlybasisservice { get; set; }
        //path for "oneoffservice"
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/label")]
        private IWebElement oneoffservicetype { get; set; }
        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //onsite
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement onsiteradiobtn { get; set; }
        //online
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/label")]
        private IWebElement onlineradiobtn { get; set; }
        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Skill-exchange radio btn
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/label")]
        private IWebElement Skillexradiobtn { get; set; }

        //Credit radio btn
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/label")]
        private IWebElement creditradiobtn { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }


        //Upload image from your desktop 
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement uploadimage { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
        //active radio btn
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/label")]
        private IWebElement Activeradiobtn { get; set; }
        //Hidden radio btn
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/label")]
        private IWebElement Hiddenradiobtn { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void EnterShareSkill()
        {
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, By.LinkText("Share Skill"), 40);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            ShareSkillButton.Click();
            string title = (GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            string description = (GlobalDefinitions.ExcelLib.ReadData(2, "Description"));//Description
            string category = (GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            string subCategory = (GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            string tags = (GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            string serviceType = (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType"));
            string locationType = (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType"));
            string startdate = (GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            string enddate = (GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            string selectday = (GlobalDefinitions.ExcelLib.ReadData(2, "Selectday"));
            string starttime = (GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            string endtime = (GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));
            string skillTrade = (GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade"));
            string skillExchange = (GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
            string credit = (GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
            string active = (GlobalDefinitions.ExcelLib.ReadData(2, "Active"));

            Title.SendKeys(title);
            Description.SendKeys(description);
            CategoryDropDown.SendKeys(category);
            SubCategoryDropDown.SendKeys(subCategory);
            Tags.SendKeys(tags);
            Tags.SendKeys(Keys.Enter);
            GlobalDefinitions.wait(20);
            if (serviceType == "One-off service")
                oneoffservicetype.Click();
            
            if (locationType == "On-site")
                onsiteradiobtn.Click();
            
            EndDateDropDown.SendKeys(enddate);
            if (selectday == "Mon")
                Days.Click();
           
            StartTimeDropDown.SendKeys(starttime);
            EndTimeDropDown.SendKeys(endtime);
            GlobalDefinitions.wait(20);
            if (skillTrade == "Skill-Exchange")
            {
                Skillexradiobtn.Click();
                SkillExchange.SendKeys(skillExchange);
                SkillExchange.SendKeys(Keys.Enter);
            }
            else if (skillTrade == "credit")
            {
                creditradiobtn.SendKeys(credit);
            }


            uploadimage.Click();
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");//activate the window
            Thread.Sleep(1000);
            autoIt.Send(@"C:\Users\OEM\Desktop\Image1.jpg");
            autoIt.Send("{ENTER}");

            if (active == "Hidden")
                Hiddenradiobtn.Click();
            Save.Click();
        }
        internal void EditShareSkill()
        {
            
            Description.Clear();
            Description.SendKeys("Learn Selenium");
            Save.Click();
        }





























    } 

    }

