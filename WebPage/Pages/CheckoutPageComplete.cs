using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FrameworkHM.Source.Pages
{
    public class CheckoutPageComplete
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;


        public CheckoutPageComplete(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public void Finished()
        {
            Assert.That(_driver.Url.Contains("checkout-complete"));
        }
    }
}
