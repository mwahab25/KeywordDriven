using System.IO;
using NUnit.Framework;
using KeywordDriven.Config;
using KeywordDriven.Utils;
using KeywordDriven.Execution;
using System.Reflection;
using System;

namespace KeywordDriven.TestExplorer
{
    public class MainScript
    {
        [SetUp]
        public void TestSetUp()
        {
            string startupPath = Path.GetFullPath(@"..\..\..\");

            string TestDefintion = Path.Combine(startupPath, @"TestDefintion");
            string TestLogs = Path.Combine(startupPath, @"TestLogs");
            string TestResults = Path.Combine(startupPath, @"TestResults");
            string TestResources = Path.Combine(startupPath, @"TestResources");

            ExcelManager.SetExcel(TestDefintion + @"\TestCases.xlsx");
            ExtentReporter.SetExtentReporter(TestResults + @"\index.html");
            Log.SetLogger(TestLogs + @"\log.txt");

            DriverSetting.WebDriver("local", 20, 200, false);
            DriverSetting.AndroidDriver("Pixel_3a_API_30_x86", "emulator-5554", "11", TestResources + @"\apk-v5.1.4.apk");
        }

        [Test]
        public void TestCases()
        {       
            DriverScript.Execute_TestCases();   
        }

        [TearDown]
        public void TestTearDown()
        {
            ExtentReporter.Flush();
            ExcelManager.SaveCloseExcel();
        }
    }
}