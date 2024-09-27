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
    public class CartPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public IWebElement checkout => _driver.FindElement(By.Id("checkout"));

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public void Checkout()
        {
            checkout.Click();
        }
    }
}
