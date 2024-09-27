using FrameworkHM.Source.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAssesment1.StepDefinitions
{
    [Binding]


    internal class HomeStepDefinitions
    {
        private IWebDriver driver;

        [Then(@"Compare prices")]
        public void ThenComparePrices()
        {
            var Homepage = new Homepage(driver);
            int Num = 0;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "Prices.Csv");
            StreamReader reader = null;

            if (File.Exists(path))
            {
                using (reader = new StreamReader(File.OpenRead(path)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //TODO: var changes
                        var Item = line.Split(';');
                        var Price = Item[1];
                        var PriceWebsite = Homepage.GetPriceWebpage(Num);
                        Assert.That(Price, Is.EqualTo(PriceWebsite));
                        Num++;
                    }
                }              
            }
            else
            {
                Console.WriteLine("File does not Exsist");
            }
        }

    }
}
