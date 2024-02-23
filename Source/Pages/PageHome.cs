using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank.Source.Pages
{
    internal class PageHome
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement inputUsername;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement inputPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='loginPanel']/form/div[3]/input")]
        private IWebElement buttonLogIn;




        public PageHome(IWebDriver driver)
        {
            this.driver= driver;
            PageFactory.InitElements(driver, this);


        }

        public void LlenarCamposLogin(string user, string password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            inputUsername.SendKeys(user);
            inputPassword.SendKeys(password);
            buttonLogIn.Click();
            

        }
    }
}
