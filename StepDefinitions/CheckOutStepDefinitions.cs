using FrameworkAssesment1.Utilities;
using FrameworkHM.Source.Pages;
using FrameworkProject.StepDefinitions;
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
        CheckoutPage1 checkoutPage1 = new CheckoutPage1();
        CheckoutPage2 checkoutPage2 = new CheckoutPage2();
        CheckoutPageComplete checkoutPageComplete = new CheckoutPageComplete();

        [When(@"I add my (.*),(.*) and (.*)")]
        public void ThenIAddMyDetails(string name, string lastname, string postcode)
        {
            checkoutPage1.EnterDetails(name, lastname, postcode);
        }

        [When(@"I purchice item")]
        public void ThenIPurchaseItem()
        {
            checkoutPage2.Finish();
        }

        [Then(@"I have Bought the Item")]
        public void ThenIHaveBoughtTheItem()
        {
            checkoutPageComplete.Finished();
        }
    }

}
