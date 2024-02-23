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
    internal class PageRegister
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "customer.firstName")]
        private IWebElement inputFirsName;

        [FindsBy(How = How.Name, Using = "customer.lastName")]
        private IWebElement inputLastName;

        [FindsBy(How = How.Name, Using = "customer.address.street")]
        private IWebElement inputAdress;

        [FindsBy(How = How.Name, Using = "customer.address.city")]
        private IWebElement inputCity;

        [FindsBy(How = How.Name, Using = "customer.address.state")]
        private IWebElement inputState;

        [FindsBy(How = How.Name, Using = "customer.address.zipCode")]
        private IWebElement inputZipCode;

        [FindsBy(How = How.Name, Using = "customer.phoneNumber")]
        private IWebElement inputPhoneNumber;

        [FindsBy(How = How.Name, Using = "customer.ssn")]
        private IWebElement inputSSN;


        [FindsBy(How = How.Name, Using = "customer.username")]
        private IWebElement inputUserName;

        [FindsBy(How = How.Name, Using = "customer.password")]
        private IWebElement inputPassword;

        [FindsBy(How = How.Name, Using = "repeatedPassword")]
        private IWebElement inputConfirmPassword;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[13]/td[2]/input[1]")]
        private IWebElement buttonRegister;


        public PageRegister(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LlenarFormularioRegistro(string firstName, string lastName, string adress, string city, string state, int zipCode, int phoneNumber, int socialNumber, string userName, string password, string confirmPassword)
        {
            inputFirsName.SendKeys(firstName);
            inputLastName.SendKeys(lastName);
            inputAdress.SendKeys(adress);
            inputCity.SendKeys(city);
            inputState.SendKeys(state);
            inputZipCode.SendKeys(Convert.ToString(zipCode));
            inputPhoneNumber.SendKeys(Convert.ToString(phoneNumber));
            inputSSN.SendKeys(Convert.ToString(socialNumber));

            inputUserName.SendKeys(userName);
            inputPassword.SendKeys(password);
            inputConfirmPassword.SendKeys(confirmPassword);

            buttonRegister.Click();

            

        }
    }
}
