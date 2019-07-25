using System;
using System.Threading;
using OpenQA.Selenium;

namespace Competition
{
    internal class ManageListingsPage
    {
        private IWebDriver driver;

        public ManageListingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ActiveManageListings()
        {

            //Click on ManageListing
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='item'][@href='/Home/ListingManagement']")).Click();


            //Activate the listing
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@name='isActive'][@type='checkbox']")).Click();

            //Deactivate the Listing
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@name='isActive'][@type='checkbox']")).Click();

            //Click on Eye-icon
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//i[@class='eye icon']")).Click();

            //Click on ManageListing
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='item'][@href='/Home/ListingManagement']")).Click();

            //Edit the Manage Listing
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//i[@class='outline write icon']")).Click();

            //Click on ManageListing
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='item'][@href='/Home/ListingManagement']")).Click();

            //Delete the Manage Listing
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//i[@class='remove icon']")).Click();

            Thread.Sleep(2000);






        }




    }
}