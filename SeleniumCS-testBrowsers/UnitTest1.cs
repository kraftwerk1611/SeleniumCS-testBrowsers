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
        }

    }//end  class
}

  
