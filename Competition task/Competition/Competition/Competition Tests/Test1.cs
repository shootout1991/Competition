using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Competition
{
    public class Program
    {

        //Create the reference for our browser
        IWebDriver driver;
        ExtentReports extent;
        ExtentTest test;

        static void Main(string[] args)
        {
        }

            [SetUp]
            public void Initialize()

        {
            //Generate Extent Reports
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\sra1\Desktop\Internhip\Competition task\Competition\Competition\Extent Reports\ExtentReport.html");
            extent.AttachReporter(htmlReporter);


            test =  extent.CreateTest("Test1").Info("Test Started");
            driver = new ChromeDriver();

            //Maximize the screen
            driver.Manage().Window.Maximize();
            test.Log(Status.Info,"Chrome Browser Launched");


            //Navigate to Mars Page
            driver.Navigate().GoToUrl("http://www.skillswap.pro/");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
            
            
        }

            [Test]

            public void AddShareSkill()
        {
    
            ShareSkillPage h = new ShareSkillPage(driver);
            h.ClickShareSkill();
           


        }

             [Test]

               public void ManageListings()
        {
            ManageListingsPage k = new ManageListingsPage(driver);
            k.ActiveManageListings();
        }


            [TearDown]

            public void CleanUp()
        {

            driver.Close();

            extent.Flush();
        }

          
        
    }
}
