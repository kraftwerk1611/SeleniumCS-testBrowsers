using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumCS_testBrowsers
{
    [Parallelizable]
    [TestFixture]
    public class TodVachevSiteTesting : Hooks
    {
        [Test]
        public void testTodVachevSite()
        {
            driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }

    }//end testFirefox class

    [Parallelizable]
    [TestFixture]
    public class LetsKodeItTesting : Hooks
    {
        [Test]
        public void testLetsKodeIt()
        {
            driver.Navigate().GoToUrl("http://letskodeit.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }

    }//end  class

    [Parallelizable]
    [TestFixture]
    public class GoogleTesting : Hooks
    {
        [Test]
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

    }//end  class
}

  
