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


        static void Main(string[] args)
        {
        }

            [SetUp]
            public void Initialize()

        {
            driver = new ChromeDriver();
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
        }

          
        
    }
}
