using DesktopFrameworkAssesment.Utility;
using FluentAssertions;
using FrameworkAssesment1.Utilities;
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
        public IWebElement UsernameElement => new ElementHelper().WaitForElement(By.Id("user-name"));
        public IWebElement PasswordElement => new ElementHelper().WaitForElement(By.Id("password"));
        public IWebElement Loginbutton => new ElementHelper().WaitForElement(By.Id("login-button"));
        public IWebElement Errormessage => new ElementHelper().WaitForElement(By.Id("login_button_container"));

        public void Login(string username,string password)
        {
            UsernameElement.Click();
            UsernameElement.SendKeys(username);
            PasswordElement.Click();
            PasswordElement.SendKeys(password);
            Loginbutton.Click();
        }
        public void ErrorIsDisplayed()
        {
            Assert.That(Errormessage.Displayed);
        }
    }
}
