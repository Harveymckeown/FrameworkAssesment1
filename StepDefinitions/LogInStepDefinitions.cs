using FrameworkHM.Source.Pages;
using FrameworkProject.StepDefinitions;
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
        LoginPage loginpage => new LoginPage();

        [When("I log in with (.*) and (.*)")]
        public void WhenILogIn(string username, string password)
        {
            loginpage.Login(username, password);
        }

        [Then(@"An error message will be displyed")]
        public void ThenAnErrorMessageWillBeDisplyed()
        {
            loginpage.ErrorIsDisplayed();
        }
    }
}
