using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkHM.Source.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public IWebElement usernameElement => _driver.FindElement(By.Id("user-name"));

        public IWebElement passwordElement => _driver.FindElement(By.Id("password"));

        public IWebElement loginbutton => _driver.FindElement(By.Id("login-button"));
        public IWebElement errormessage => _driver.FindElement(By.Id("login_button_container"));

        public LoginPage(IWebDriver driver) 
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Login(string username,string password)
        {
            usernameElement.SendKeys(username);
            passwordElement.SendKeys(password);
            loginbutton.Click();
        }
        public void ErrorIsDisplayed()
        {
            Assert.That(errormessage.Displayed);
        }
    }
}
