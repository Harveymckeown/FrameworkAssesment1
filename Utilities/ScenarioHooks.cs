using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAssesment1.Utilities
{
    [Binding]
    internal class ScenarioHooks
    {
        private IWebDriver driver;

        [AfterScenario]
        public void AfterScenario(ScenarioContext ScenarioContext)
        {
            ScreenShot screenShot = new ScreenShot();
            screenShot.TakeScreenShot(ScenarioContext);

            driver.Close();
        }
    }
}
