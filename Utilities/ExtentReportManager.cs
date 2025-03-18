using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace FrameworkAssesment1.Utilities
{
    public static class ExtentReportManager
    {
        private static ExtentReports _extent;
        private static ExtentSparkReporter _sparkReporter;

        public static ExtentReports GetInstance()
        {
            if (_extent == null)
            {
                _sparkReporter = new ExtentSparkReporter("ExtentReport.html");
                _extent = new ExtentReports();
                _extent.AttachReporter(_sparkReporter);
            }
            return _extent;
        }
    }
}