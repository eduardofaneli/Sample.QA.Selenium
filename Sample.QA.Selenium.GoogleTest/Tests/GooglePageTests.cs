using Microsoft.Extensions.Configuration;
using Sample.QA.Selenium.IoC.Enumerators;
using System.IO;
using Xunit;

namespace Sample.QA.Selenium.GoogleTest
{
    public class GooglePageTests
    {
        private IConfiguration _configuration;        

        public GooglePageTests()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");

            _configuration = builder.Build();
        }

        [Theory]
        [InlineData(Browser.Chrome, "eduardofaneli2@gmail.com", "xurupita123")]
        public void TestPage(Browser browser, string email, string password)
        {
            GooglePage page = new GooglePage(_configuration, browser);
                        
            page.LoadPage();
            page.Login();
            page.Close();
            Assert.True(true);
        }
    }
}
