using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using System;

namespace SeleniumCS_testBrowsers
{
    class Hooks
    {
        static void Main(string[] args)
        {
            //variables declaration
            IWebDriver driver; //generic browser
            string _browserType = args[0]; //get the command line argument for browser type
            _browserType = _browserType.ToLower(); //convert to all lower case

            Console.WriteLine(_browserType );

            ////##Debug: iterate through CL arguments
            //foreach (string arg in args)
            //{ Console.WriteLine(arg);
            //}//end foreach
            
           
            //find out which driver is chosen
            if (_browserType == "chrome")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://www.gmail.com");
                driver.Close();

            }

            else if (_browserType =="internetexplorer")
            {
                driver = new InternetExplorerDriver();
                driver.Navigate().GoToUrl("http://www.hotmail.com");
                driver.Close();
            }

            else if (_browserType=="firefox")
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("http://www.yahoo.com");
                driver.Close();
            }

            

        }
    }
}
