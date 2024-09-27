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
    public class CheckoutPage2
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public IWebElement finish => _driver.FindElement(By.Id("finish"));


        public CheckoutPage2(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public void Finish()
        {
            finish.Click();
        }
    }
}
