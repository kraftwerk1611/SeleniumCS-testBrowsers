using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

namespace SeleniumCS_testBrowsers
{
    class Hooks
    {
        static void Main()
        {
            IWebDriver driver = new FirefoxDriver();
            
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Close();

            //IWebDriver chromeDriver = new ChromeDriver();
            //chromeDriver.Navigate().GoToUrl("http://www.letskodeit.com");
            //driver.Close();
        }
    }
}
