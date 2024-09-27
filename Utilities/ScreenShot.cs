using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAssesment1.Utilities
{
    internal class ScreenShot
    {
        private IWebDriver driver;
        public void TakeScreenShot(ScenarioContext scenarioContext) 
        {
            if (scenarioContext.TestError != null)
            {
                Screenshot screenshot = driver.TakeScreenshot();
                string screenshotDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, @"Screenshots");
                if (!Directory.Exists(screenshotDirectory))
                {
                    Directory.CreateDirectory(screenshotDirectory);
                }
                string screenshotPath = Path.Combine(screenshotDirectory, "screenshot "+ scenarioContext.ToString() + DateTime.Now + ".png");
                screenshot.SaveAsFile(screenshotPath);
            }
        }
    }
}
