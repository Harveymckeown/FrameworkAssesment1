using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using FrameworkAssesment1.Utilities;

namespace DesktopFrameworkAssesment.Utility
{
    internal class ElementHelper
    {
        private IWebDriver driver = DriverManager.GetDriver();
     
        public IWebElement WaitForElement(By by, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv => drv.FindElement(by));
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> WaitForElements(By by, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv => drv.FindElements(by));
        }
    }
}
