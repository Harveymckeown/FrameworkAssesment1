using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace FrameworkAssesment1.Utilities
{
    [Binding]
    internal class ScenarioHooks
    {
        private IObjectContainer _container;
        private IWebDriver _driver = DriverManager.GetDriver();
        private static ExtentReports _extent = ExtentReportManager.GetInstance();
        private ExtentTest _scenario;

        public ScenarioHooks(IObjectContainer objectContainer)
        {
            _container = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            _scenario = _extent.CreateTest<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null)
            {
                _scenario.Fail(scenarioContext.TestError.Message);
            }
            else
            {
                _scenario.Pass("Test passed");
            }

            ScreenShot screenShot = new ScreenShot();
            screenShot.TakeScreenShot(scenarioContext);

            _extent.Flush();
        }
    }
}