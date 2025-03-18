using CsvHelper.Configuration;
using CsvHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using FluentAssertions;
using static System.Net.Mime.MediaTypeNames;
using NUnit.Framework;
using FrameworkAssesment1.Utilities;
using DesktopFrameworkAssesment.Utility;

namespace FrameworkHM.Source.Pages
{
    public class Homepage 
    {

        public IWebElement Addbutton => new ElementHelper().WaitForElement(By.Id("add-to-cart-sauce-labs-backpack"));

        public IWebElement Cartbutton => new ElementHelper().WaitForElement(By.Id("shopping_cart_container"));

        public List<string> FindPrices()
        {
            List<string> itemTexts = new List<string>();

            IReadOnlyCollection<IWebElement> elements = new ElementHelper().WaitForElements(By.XPath("//*[@id='inventory_container']/div/div/div[2]/div[2]/div"));

            foreach (IWebElement element in elements)
            {
                itemTexts.Add(element.Text);
            }
            return itemTexts;
        }
        public void AddToCart()
        {
            Addbutton.Click();
        }
        public void OpenCart()
        {
            Cartbutton.Click();
        }
    }
}
