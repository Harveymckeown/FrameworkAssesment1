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
    public class CheckoutPage1
    {

        public IWebElement FirstName => new ElementHelper().WaitForElement(By.Id("first-name"));

        public IWebElement LastName => new ElementHelper().WaitForElement(By.Id("last-name"));

        public IWebElement PostCode => new ElementHelper().WaitForElement(By.Id("postal-code"));

        public IWebElement ContinueButton => new ElementHelper().WaitForElement(By.Id("continue"));

        public void EnterDetails(string firstname, string lastname, string postcode)
        {
            FirstName.SendKeys(firstname);
            LastName.SendKeys(lastname);
            PostCode.SendKeys(postcode);
            ContinueButton.Click();
            
        }
    }
}
