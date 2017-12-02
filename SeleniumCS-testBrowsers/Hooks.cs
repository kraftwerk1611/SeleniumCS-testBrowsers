using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using NUnit.Framework;

namespace SeleniumCS_testBrowsers
{
    public class Hooks:Base
    {
        //public static IWebDriver driver { get; set; }//generic browser

        [SetUp]
        static void Main(string[] args)
        {
            //variables declaration
            
            string _browserType = args[0]; //get the command line argument for browser type
            _browserType = _browserType.ToLower(); //convert to all lower case

            Console.WriteLine(_browserType );

            //method is called with browser type as argument
            ChooseDriverInstance(_browserType);

            ////##Debug: iterate through CL arguments
            //foreach (string arg in args)
            //{ Console.WriteLine(arg);
            //}//end foreach
            
            

        }//end main
        
        static void ChooseDriverInstance(string browserType)
        {
            //find out which driver is chosen
            if (browserType == "chrome")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://www.gmail.com");
                driver.Close();

            }

            else if (browserType == "internetexplorer")
            {
                driver = new InternetExplorerDriver();
                driver.Navigate().GoToUrl("http://www.hotmail.com");
                driver.Close();
            }

            else if (browserType == "firefox")
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("http://www.yahoo.com");
                driver.Close();
            }

        }//end ChooseDriverInstance()

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }//end CloseBrowser()
    }
}
