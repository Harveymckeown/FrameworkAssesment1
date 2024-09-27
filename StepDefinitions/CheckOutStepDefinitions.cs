using FrameworkHM.Source.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAssesment1.StepDefinitions
{
    [Binding]

    internal class CheckOutStepDefinitions
    {
        private IWebDriver driver;

        [Then(@"I add my (.*),(.*) and (.*)")]
        public void ThenIAddMyDetails(string name, string lastname, string postcode)
        {
            CheckoutPage1 checkout = new CheckoutPage1(driver);
            checkout.EnterDetails(name, lastname, postcode);
        }


        [Then(@"i purchice item")]
        public void ThenIPurchiceItem()
        {
            CheckoutPage2 checkout2 = new CheckoutPage2(driver);
            checkout2.Finish();
        }

        [Then(@"i have Bought the Item")]
        public void ThenIHaveBoughtTheItem()
        {
            CheckoutPageComplete completepage = new CheckoutPageComplete(driver);
            completepage.Finished();
        }
    }
}
