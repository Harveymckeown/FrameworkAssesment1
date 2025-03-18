using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FrameworkAssesment1.Utilities;

namespace FrameworkHM.Source.Pages
{
    public class CheckoutPageComplete
    {
        private IWebDriver Driver = DriverManager.GetDriver();
        public void Finished()
        {
            Assert.That(Driver.Url.Contains("checkout-complete"));
        }
    }
}
