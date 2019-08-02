using System;
using System.Threading;
using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace Competition
{
    internal class LoginPage
    {
        IWebDriver driver;
       

        public LoginPage(IWebDriver driver)
        {   
            this.driver = driver;
        }

        IWebElement username => driver.FindElement(By.XPath("//input[@type='text'][@name='email']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@type='password'][@name='password']"));

        IWebElement Login => driver.FindElement(By.XPath("//button[@class='fluid ui teal button'][text()='Login']"));


        internal void LoginSuccess()
        {

            //Click on Sign-In button
            driver.FindElement(By.XPath("//a[@class='item'][text()='Sign In']")).Click();
            


            //Enter Username
            username.SendKeys("sravanramba7991@gmail.com");

          

            //Enter password
            password.SendKeys("sravan@1991");
            Thread.Sleep(1000);

            //Click on Login Button
            Login.Click();
        }
    }
}