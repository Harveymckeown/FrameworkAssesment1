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
        private IWebDriver driver = DriverManager.GetDriver();

        public void TakeScreenShot(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null)
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string screenshotDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "TestResults");

                if (!Directory.Exists(screenshotDirectory))
                {
                    Directory.CreateDirectory(screenshotDirectory);
                }

                string sanitizedScenarioName = scenarioContext.ScenarioInfo.Title.Replace(" ", "_").Replace(":", "_");
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string screenshotPath = Path.Combine(screenshotDirectory, $"screenshot_{sanitizedScenarioName}_{timestamp}.png");

                screenshot.SaveAsFile(screenshotPath);

                TestContext.AddTestAttachment(screenshotPath, "My Screenshot");
            }
        }
    }
}
