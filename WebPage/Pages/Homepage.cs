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

namespace FrameworkHM.Source.Pages
{
    public class Homepage 
    {
        private IWebDriver _driver;
        private readonly WebDriverWait _wait;
        //TODO: make the xpaths dynaminc
        public IWebElement Addbutton => _driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));

        public IWebElement Cartbutton => _driver.FindElement(By.Id("shopping_cart_container"));

        public IWebElement BackPackPrice => _driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[1]/div[2]/div[2]/div"));

        public IWebElement BikePrice => _driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[2]/div[2]/div[2]/div"));

        public IWebElement ShirtPrice => _driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[3]/div[2]/div[2]/div"));

        public IWebElement FleecePrice => _driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[4]/div[2]/div[2]/div"));

        public IWebElement OnesiePrice => _driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[5]/div[2]/div[2]/div"));

        public IWebElement RedShirtPrice => _driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[6]/div[2]/div[2]/div"));

        
        public Homepage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public void AddToCart()
        {
            Addbutton.Click();
        }
        
        public string GetPriceWebpage(int Index)
        {

            List<string> PriceList = new List<string>();

            string price1 = BackPackPrice.Text;
            PriceList.Add(price1);

            string price2 = BikePrice.Text;
            PriceList.Add(price2);

            string price3 = ShirtPrice.Text;
            PriceList.Add(price3);

            string price4 = FleecePrice.Text;
            PriceList.Add(price4);

            string price5 = OnesiePrice.Text;
            PriceList.Add(price5);

            string price6 = RedShirtPrice.Text;
            PriceList.Add(price6);

            var Price = PriceList[Index];
            return Price;

        }
    }
}
