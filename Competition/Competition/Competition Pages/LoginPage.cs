using System;
using System.Threading;
using OpenQA.Selenium;

namespace Competition
{
    internal class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement username => driver.FindElement(By.XPath("//input[@type='text'][@name='email']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@type='password'][@name='password']"));

        IWebElement Login => driver.FindElement(By.XPath("//button[@class='fluid ui teal button'][text()='Login']"));


        internal void LoginSuccess()
        {

            //Navigate to Mars Page
            driver.Navigate().GoToUrl("http://www.skillswap.pro/");

            //Maximize the screen
            driver.Manage().Window.Maximize();

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