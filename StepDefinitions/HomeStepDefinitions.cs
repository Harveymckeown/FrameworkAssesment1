using FrameworkAssesment1.Utilities;
using FrameworkHM.Source.Pages;
using FrameworkProject.StepDefinitions;
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
        Homepage _homePage = new Homepage();
        [Then(@"Compare prices")]
        public void ThenComparePrices()
        {
            int num = 0;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cvs", "Prices.csv");

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist");
                return;
            }

            using (StreamReader reader = new StreamReader(File.OpenRead(path)))
            {
                string line;
                List<decimal> filePrices = new List<decimal>();
                List<string> priceWebsite = _homePage.FindPrices();

                while ((line = reader.ReadLine()) != null)
                {
                    string[] item = line.Split(';');
                    if (item.Length < 2) continue;

                    if (decimal.TryParse(item[1].Trim().Replace("$", ""), out decimal filePrice) &&
                        decimal.TryParse(priceWebsite[num].Trim().Replace("$", ""), out decimal webPrice))
                    {
                        filePrices.Add(filePrice);
                        Assert.That(webPrice, Is.EqualTo(filePrice));
                        Console.WriteLine(webPrice.ToString());
                        Console.WriteLine(filePrice.ToString());
                    }
                    num++;
                }
            }
        }
    }
}