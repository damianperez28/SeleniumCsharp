using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ParaBank.Source.Pages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank.Tests
{
    internal class TestRegister
    {
        public IWebDriver driver;
        [SetUp]

        public void InitScript()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test] public void RegisterSuccessfully() 
        {
            PageRegister pRegis = new PageRegister(driver);
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            pRegis.LlenarFormularioRegistro("julito", "sambrano", "mosto 20", "guatemala", "guatemalteca", 333, 32323, 111, "juancho", "123", "123");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Assert.True(driver.PageSource.Contains("Your account was created successfully."));
        }
        //[TearDown] public void TearDownScript() { driver.Close(); }
    }
}
