using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumCS_testBrowsers
{
    
    [TestFixture]
    public class BrowserTests : Hooks
    {
        [Test]
        //[Parallelizable]
        public void testTodVachevSite()
        {
            driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }




        [Test]
        //[Parallelizable]
        public void testLetsKodeIt()
        {
            driver.Navigate().GoToUrl("http://letskodeit.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }




        [Test, Order(1)]
        public void testGoogle()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            driver.FindElement(By.Name("btnK")).Submit();
            System.Threading.Thread.Sleep(5000);
            Assert.That(driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }

        [Test, Order(2)]
        public void testExecuteAutomation()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("admin");
            driver.FindElement(By.Name("Login")).Submit();
            System.Threading.Thread.Sleep(2000);
            Assert.That(driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);


        }


    }
}

  
