using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using NUnit.Framework;

namespace SeleniumCS_testBrowsers
{
    [Parallelizable ]
    [TestFixture]
    public class Hooks:Base
    {
        //public static IWebDriver driver { get; set; }//generic browser

        
        static void Main()
        {       

            ////##Debug: iterate through CL arguments
            //foreach (string arg in args)
            //{ Console.WriteLine(arg);
            //}//end foreach          
            

        }//end main

        [SetUp]
        public void InitializeTest()
        {
            //the get method retrieves the value passed as Name-Value pair after --params on command line
            var browser = TestContext.Parameters.Get("Browser");
            //System.Console.WriteLine("The browser is " + browser);
            
            //variables declaration

           string _browserType = browser.ToLower(); //convert to all lower case

            

            //method is called with browser type as argument
            ChooseDriverInstance(_browserType);


        }//end InitializeTest()
        
        private void ChooseDriverInstance(string browserType)
        {
            //find out which driver is chosen
            if (browserType == "chrome")
            {
                driver = new ChromeDriver();
                
                

            }

            else if (browserType == "ie")
            {
                driver = new InternetExplorerDriver();
                
                
            }

            else if (browserType == "firefox")
            {
                driver = new FirefoxDriver();
              
                
            }

        }//end ChooseDriverInstance()

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }//end CloseBrowser()
    }
}
