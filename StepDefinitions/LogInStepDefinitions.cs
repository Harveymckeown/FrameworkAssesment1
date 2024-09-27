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
    internal class LogInStepDefinitions
    {
        private IWebDriver driver;

        [When("I log in with (.*) and (.*)")]
        public void WhenILogIn(string username, string password)
        {
            var loginpage = new LoginPage(driver);
            loginpage.Login(username, password);
        }

        [Then(@"An error message will be displyed")]
        public void ThenAnErrorMessageWillBeDisplyed()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.ErrorIsDisplayed();
        }
    }
}
