using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumCS_testBrowsers
{
    [TestFixture]
    public class FirefoxTesting:Hooks 
    {
        [Test]
        public void testFirefox()
        {
            driver.Navigate().GoToUrl("http://testing.todvachev.com/");
        }

    }//end testFirefox class

    [TestFixture]
    public class ChromeTesting : Hooks
    {
        [Test]
        public void testChrome()
        {
            driver.Navigate().GoToUrl("http://letskodeit.com");
        }

    }//end ChromeTesting class

    [TestFixture]
    public class IETesting : Hooks
    {
        [Test]
        public void testIE()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

    }//end IETesting class
}
