using DesktopFrameworkAssesment.Utility;
using FrameworkAssesment1.Utilities;
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

        public IWebElement CheckoutElement => new ElementHelper().WaitForElement(By.Id("checkout"));

        public void Checkout()
        {
            CheckoutElement.Click();
        }
    }
}
