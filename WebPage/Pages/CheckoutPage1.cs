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
    public class CheckoutPage1
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public IWebElement firstName => _driver.FindElement(By.Id("first-name"));

        public IWebElement lastName => _driver.FindElement(By.Id("last-name"));

        public IWebElement postCode => _driver.FindElement(By.Id("postal-code"));

        public IWebElement continueButton => _driver.FindElement(By.Id("continue"));

        public CheckoutPage1(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public void EnterDetails(string firstname, string lastname, string postcode)
        {
            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);
            postCode.SendKeys(postcode);
            continueButton.Click();
            
        }
    }
}
