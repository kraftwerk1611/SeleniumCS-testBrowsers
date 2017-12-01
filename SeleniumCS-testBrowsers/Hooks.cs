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
            //IWebDriver driver = new FirefoxDriver();

            //driver.Navigate().GoToUrl("http://www.google.com");
            //driver.Close();

            ////Following code opens chrome browser
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.letskodeit.com");
            //driver.Close();

            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Close();


        }
    }
}
