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
            System.Console.WriteLine(driver.GetType().ToString());

            //find out which driver is chosen
            if (driver.GetType().ToString().Contains("Chrome"))
            {
                driver.Navigate().GoToUrl("http://www.gmail.com");
                
            }

            else if (driver.GetType().ToString().Contains("InternetExplorer"))
            {
                driver.Navigate().GoToUrl("http://www.hotmail.com");
            }

            else if (driver.GetType().ToString().Contains("Firefox"))
            {
                driver.Navigate().GoToUrl("http://www.yahoo.com");
            }

            driver.Close();

        }
    }
}
