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

        internal static void CreateTest(String sTestCaseID, String sTestCaseTitle)
        {
            //testcase = extent.CreateTest("TestCase: " + sTestCaseID, "Title: " + sTestCaseTitle);
            testcase = extent.CreateTest(sTestCaseID,sTestCaseTitle);
        }

        internal static void CreateNode(String sTestStepNo)
        {
            node = testcase.CreateNode(sTestStepNo);
        }

        internal static void StartTestCase(String sTestCaseName)
        {
            testcase.Info("Start TestCase " + sTestCaseName);
        }

        internal static void EndTestCase(String sTestCaseName)
        {
            testcase.Info("End TestCase " + sTestCaseName);
        }

        internal static void Info(String message)
        {
            testcase.Info(message);
        }

        internal static void Pass(String message)
        {
            testcase.Pass(message);
        }

        internal static void Fail(String message)
        {
            testcase.Fail(message);
        }

        internal static void Error(String message)
        {
            testcase.Error(message);
        }

        internal static void Warn(String message)
        {
            testcase.Warning(message);
        }

        internal static void AddScreenShot(String path)
        {
            testcase.AddScreenCaptureFromPath(path);
        }
        
        internal static void NodeInfo(String message)
        {
            node.Info(message);
        }

        internal static void NodePass(String message)
        {
            node.Pass(message);
        }

        internal static void NodeFail(String message)
        {
            node.Fail(message);
        }

        internal static void NodeError(String message)
        {
            node.Error(message);
        }

        internal static void NodeWarn(String message)
        {
            node.Warning(message);
        }

        internal static void NodeAddScreenShot(String path)
        {
            node.AddScreenCaptureFromPath(path);
        }
    }
}
