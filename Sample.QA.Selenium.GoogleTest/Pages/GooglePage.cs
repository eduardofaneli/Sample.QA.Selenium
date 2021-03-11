using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using Sample.QA.Selenium.IoC.Enumerators;
using Sample.QA.Selenium.IoC.Extensions;
using Sample.QA.Selenium.IoC.Factories;
using System;

namespace Sample.QA.Selenium.GoogleTest
{
    public class GooglePage
    {
        private readonly IConfiguration _configuration;
        private readonly Browser _browser;
        private readonly IWebDriver _driver;
        
        public GooglePage(IConfiguration configuration, Browser browser)
        {
            _configuration = configuration;
            _browser = browser;

            _driver = WebDriverFactory.CreateWebDriver(Browser.Chrome);           
        }

        public void LoadPage()
        {
            var url = _configuration.GetSection("Selenium:Url").Value;
            _driver.LoadPage(
                TimeSpan.FromSeconds(5),
                url);

        }

        public void Login()
        {
            var element = _driver.FindElement(By.LinkText("Fazer login"));                       
            element.Click();
        }

        public void Close()
        {            
            _driver.Quit();            
        }


    }
}
