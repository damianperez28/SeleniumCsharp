using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ParaBank.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParaBank.Tests
{
    internal class TestsHome
    {
        public IWebDriver driver;
        [SetUp]
        
        public void InitScript()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test] 
        public void LoginFallido()
        {

        }

        [Test]
        public void LoginExitoso()
        {
            PageHome pHome = new PageHome(driver);
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            pHome.LlenarCamposLogin("john", "demo");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Assert.True(driver.Url.Contains("overview.htm"));
            
        }

        [TearDown] public void TearDownScript() { driver.Close(); }
    }
}
