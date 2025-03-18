using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FrameworkAssesment1.Utilities
{
    internal static class DriverManager
    {

        private static IWebDriver driver;

        private static string browser = TestContext.Parameters["Browser"].ToString().ToLower().Trim();

        private static string location = TestContext.Parameters["Location"].ToString().ToLower().Trim();

        private static string URL = TestContext.Parameters["Url"].ToString().ToLower().Trim();

        public static void CreateDriver()
        {
            int retryCount = 3;
            while (retryCount > 0)
            {
                try
                {
                    if (location == "docker")
                    {
                        Uri hubUrl = new Uri("http://localhost:4444/wd/hub");

                        if (browser == "edge")
                        {
                            EdgeOptions edgeOptions = new EdgeOptions();
                            edgeOptions.AddArgument("--no-sandbox");
                            edgeOptions.AddArgument("--disable-dev-shm-usage");


                            driver = new RemoteWebDriver(hubUrl, edgeOptions.ToCapabilities(), TimeSpan.FromMinutes(3));
                        }
                        else if (browser == "chrome")
                        {
                            ChromeOptions chromeOptions = new ChromeOptions();
                            chromeOptions.AddArgument("--no-sandbox");
                            chromeOptions.AddArgument("--disable-dev-shm-usage");

                            driver = new RemoteWebDriver(hubUrl, chromeOptions.ToCapabilities(), TimeSpan.FromMinutes(3));
                        }
                        else if (browser == "firefox")
                        {
                            FirefoxOptions firefoxOptions = new FirefoxOptions();
                            firefoxOptions.AddArgument("--no-sandbox");
                            firefoxOptions.AddArgument("--disable-dev-shm-usage");


                            driver = new RemoteWebDriver(hubUrl, firefoxOptions.ToCapabilities(), TimeSpan.FromMinutes(3));
                        }
                        else
                        {
                            throw new Exception("The Browser you've choosen isn't supported");
                        }

                        driver.Navigate().GoToUrl(URL);
                    }
                }
                catch (WebDriverException ex)
                {
                    retryCount--;
                    if (retryCount == 0)
                    {
                        throw new Exception("Failed to create WebDriver after multiple attempts", ex);
                    }
                }
            }
            if (location == "locally") {

                if (browser == "edge")
                {
                    EdgeOptions options = new EdgeOptions();
                    options.AddArgument("--headless");
                    options.AddArgument("--no-sandbox");
                    options.AddArgument("--disable-dev-shm-usage");
                    driver = new EdgeDriver(options)
                    {
                        Url = URL
                    };
                }
                else if (browser == "chrome")
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--headless");
                    options.AddArgument("--no-sandbox");
                    options.AddArgument("--disable-dev-shm-usage");
                    driver = new ChromeDriver(options)
                    {
                        Url = URL
                    };
                }
                else if (browser == "firefox")
                {
                    FirefoxOptions options = new FirefoxOptions();
                    options.AddArgument("--headless");
                    options.AddArgument("--no-sandbox");
                    options.AddArgument("--disable-dev-shm-usage");
                    driver = new FirefoxDriver(options)
                    {
                        Url = URL
                    };
                }
                else
                {
                    throw new Exception("The Browser you've choosen isn't supported");
                }
                driver.Manage().Window.Maximize();
            }
        }
        public static IWebDriver GetDriver()
        {
            return driver;
        }
    }
}