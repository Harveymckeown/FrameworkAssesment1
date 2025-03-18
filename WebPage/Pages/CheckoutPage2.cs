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
    public class CheckoutPage2
    {
        public IWebElement FinishButton => new ElementHelper().WaitForElement(By.Id("finish"));

        public void Finish()
        {
            FinishButton.Click();
        }
    }
}
