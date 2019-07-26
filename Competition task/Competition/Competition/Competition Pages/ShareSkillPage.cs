using System;
using System.Threading;
using OpenQA.Selenium;

namespace Competition
{
    internal class ShareSkillPage
    {
        private IWebDriver driver;
      

        public ShareSkillPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickShareSkill()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='ui basic green button'][text()='Share Skill']")).Click();
            Thread.Sleep(2000);

            //Enter Title
            driver.FindElement(By.XPath("//input[@name='title']")).SendKeys("TITLE");
            Thread.Sleep(2000);

            //Enter Description
            driver.FindElement(By.XPath("//textarea[@name='description']")).SendKeys("DESCRIPTION");
            Thread.Sleep(2000);

            //Enter Category
            driver.FindElement(By.XPath("//option[@value='5']")).Click();
            Thread.Sleep(2000);

            //Enter SubCategory
            driver.FindElement(By.XPath("//option[@value='2'][text()='Voice Over']")).Click();
            Thread.Sleep(2000);

            //Enter Tags
            IWebElement k= driver.FindElement(By.XPath("//input[@class='ReactTags__tagInputField'][@type='text']"));
            k.SendKeys("TAG");

            //Press Enter
            k.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            //Enter Service Type
            driver.FindElement(By.XPath("//input[@name='serviceType'][@type='radio'][@value='1']")).Click();
            Thread.Sleep(2000);


            //Enter Location Type
            driver.FindElement(By.XPath("//input[@name='locationType'][@value='0']")).Click();
            Thread.Sleep(2000);

            //Enter Start date
            driver.FindElement(By.XPath("//input[@name='startDate']")).SendKeys("01072019");
            Thread.Sleep(2000);


            //Enter End Date
            driver.FindElement(By.XPath("//input[@name='endDate']")).SendKeys("19072019");
            Thread.Sleep(2000);

            //Enable the days
            driver.FindElement(By.XPath("//input[@tabindex='0'][@index='0'][@name='Available']")).Click();
            driver.FindElement(By.XPath("//input[@tabindex='0'][@index='1'][@name='Available']")).Click();
            driver.FindElement(By.XPath("//input[@tabindex='0'][@index='2'][@name='Available']")).Click();
            driver.FindElement(By.XPath("//input[@tabindex='0'][@index='3'][@name='Available']")).Click();
            driver.FindElement(By.XPath("//input[@tabindex='0'][@index='4'][@name='Available']")).Click();
            driver.FindElement(By.XPath("//input[@tabindex='0'][@index='5'][@name='Available']")).Click();
            driver.FindElement(By.XPath("//input[@tabindex='0'][@index='6'][@name='Available']")).Click();


            //Enter Skill Trade
            driver.FindElement(By.XPath("//input[@name='skillTrades'][@value='false']")).Click();
            Thread.Sleep(2000);

            //Enter Skill-Exchange

           /* IWebElement l = driver.FindElement(By.XPath("(//div[@class='ReactTags__tagInput']/input)[2]"));
             l.SendKeys("TAGGS");
             Thread.Sleep(2000);
             l.SendKeys(Keys.Enter);
             Thread.Sleep(2000);


            //Click on PLUS button
          IWebElement m =  driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
            m.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window("File Upload");
          m.SendKeys("C:\\Users\\sra1\\Desktop\\Webdriver Commands.txt");*/


            //Click Hiddden Bullet
            driver.FindElement(By.XPath("//input[@name='isActive'][@value='false']")).Click();
            Thread.Sleep(2000);

            //Click Save button
            driver.FindElement(By.XPath("//input[@class='ui teal button'][@value='Save']")).Click();
            Thread.Sleep(2000);






        }
    }
}