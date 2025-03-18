using FrameworkAssesment1.Utilities;
using FrameworkHM.Source.Pages;
using OpenQA.Selenium;
using NUnit.Framework; 
using System;
using FrameworkProject.StepDefinitions;

namespace FrameworkAssesment1.StepDefinitions
{
    [Binding]
    internal class CartStepDefinitions
    {
        [When(@"I add an item to my cart")]
        public void WhenIAddAnItemToMyCart()
        {         
                Homepage homepage = new Homepage();
                CartPage cartPage = new CartPage();

                homepage.AddToCart();
                homepage.OpenCart(); 
                cartPage.Checkout();
        }
    }
}
