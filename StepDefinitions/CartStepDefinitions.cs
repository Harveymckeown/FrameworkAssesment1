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

    internal class CartStepDefinitions
    {
        private IWebDriver driver;

        [When(@"I add an item to my cart")]
        public void WhenIAddAnItemToMyCart()
        {
            var homepage = new Homepage(driver);
            var cartpage = new CartPage(driver);
            homepage.AddToCart();
            homepage.Cartbutton.Click();
            cartpage.Checkout();
        }
    }
}
