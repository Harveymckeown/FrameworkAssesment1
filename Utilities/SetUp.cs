using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAssesment1.Utilities
{
    internal class SetUp
    {
        private IWebDriver driver;
        public void Browesr(string browser)
        {
            if (browser == "Edge")
            {
                driver = new EdgeDriver
                {
                    Url = "https://www.saucedemo.com/"
                };
                driver.Manage().Window.Maximize();
            }
            if (browser == "chrome")
            {
                driver = new ChromeDriver
                {
                    Url = "https://www.saucedemo.com/"
                };
                driver.Manage().Window.Maximize();
            }
        }
    }
}
