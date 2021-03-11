using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Sample.QA.Selenium.IoC.Enumerators;
using System;
using System.IO;

namespace Sample.QA.Selenium.IoC.Factories
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(Browser browser/*, string pathDriver= ""*/)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Chrome:
                    webDriver = new ChromeDriver(Directory.GetCurrentDirectory());
                    break;
                case Browser.Firefox:
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                    webDriver = new FirefoxDriver(service);
                    break;                
            }            

            return webDriver;
        }
    }
}
