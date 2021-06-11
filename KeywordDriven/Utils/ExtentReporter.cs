using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace KeywordDriven.Utils
{
    public class ExtentReporter
    {
        private static ExtentReports extent;
        private static ExtentTest testcase;
        private static ExtentTest node;

        /// <summary>
        /// Set Extent Reporter
        /// </summary>
        public static void SetExtentReporter(string reportpath)
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(reportpath);
            htmlReporter.Config.Theme = Theme.Standard;
            extent.AttachReporter(htmlReporter);
        }

        public static void Flush()
        {
            extent.Flush();
        }

        /// <summary>
        /// Create testcase details
        /// </summary>
        internal static void CreateTest(String sTestCaseID, String sTestCaseTitle)
        {
            testcase = extent.CreateTest("TestCase: " + sTestCaseID, "Title: " + sTestCaseTitle);
        }

        /// <summary>
        /// Create test step node
        /// </summary>
        internal static void CreateNode(String sTestStepNo)
        {
            node = testcase.CreateNode(sTestStepNo);
        }

        /// <summary>
        /// Start testcase note
        /// </summary>
        internal static void StartTestCase(String sTestCaseName)
        {
            testcase.Info("Start TestCase " + sTestCaseName);
        }

        /// <summary>
        /// End testcase note
        /// </summary>
        internal static void EndTestCase(String sTestCaseName)
        {
            testcase.Info("End TestCase " + sTestCaseName);
        }

        /// <summary>
        /// Info testcase step
        /// </summary>
        internal static void Info(String message)
        {
            testcase.Info(message);
        }

        /// <summary>
        /// Pass test step
        /// </summary>
        internal static void Pass(String message)
        {
            testcase.Pass(message);
        }

        /// <summary>
        /// Fail test step
        /// </summary>
        internal static void Fail(String message)
        {
            testcase.Fail(message);
        }

        /// <summary>
        /// Error test step
        /// </summary>
        internal static void Error(String message)
        {
            testcase.Error(message);
        }

        /// <summary>
        /// Warning test step
        /// </summary>
        internal static void Warn(String message)
        {
            testcase.Warning(message);
        }

        /// <summary>
        /// Add ScreenShot to test step
        /// </summary>
        internal static void AddScreenShot(String path)
        {
            testcase.AddScreenCaptureFromPath(path);
        }

        /// <summary>
        /// Info test step node
        /// </summary>
        internal static void NodeInfo(String message)
        {
            node.Info(message);
        }

        /// <summary>
        /// Pass testcase step node
        /// </summary>
        internal static void NodePass(String message)
        {
            node.Pass(message);
        }

        /// <summary>
        /// Fail test step node
        /// </summary>
        internal static void NodeFail(String message)
        {
            node.Fail(message);
        }

        /// <summary>
        /// Error test step node
        /// </summary>
        internal static void NodeError(String message)
        {
            node.Error(message);
        }

        /// <summary>
        /// Warning test step node
        /// </summary>
        internal static void NodeWarn(String message)
        {
            node.Warning(message);
        }

        /// <summary>
        /// Add ScreenShot to test step node
        /// </summary>
        internal static void NodeAddScreenShot(String path)
        {
            node.AddScreenCaptureFromPath(path);
        }
    }
}
