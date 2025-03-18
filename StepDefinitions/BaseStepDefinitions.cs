using FrameworkAssesment1.Utilities;
using TechTalk.SpecFlow;

namespace FrameworkProject.StepDefinitions
{
    [Binding]
    public sealed class BaseStepDefinitions 
    {
        [Given(@"Im on the Webpage")]
        public void GivenImOnTheWebpage()
        {
            DriverManager.CreateDriver(); 
        }
    }
}
