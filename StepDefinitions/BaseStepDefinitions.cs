using CsvHelper;
using FrameworkHM.Source.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chromium;
using System.Diagnostics;
using FluentAssertions.Execution;
using CsvHelper.Configuration.Attributes;
using Gherkin.Ast;
using Gherkin.CucumberMessages.Types;
using OpenQA.Selenium.Support.Extensions;
using System.IO;
using FrameworkAssesment1.Utilities;

namespace FrameworkProject.StepDefinitions
{
    [Binding]
    public sealed class BaseStepDefinitions
    {
        SetUp setUp => new SetUp();
   
        [Given("Im on the Webpage using (.*)")]
        public void GivenImOnTheWebpage(string browser)
        {
            setUp.Browesr(browser);
        } 
    }
}
