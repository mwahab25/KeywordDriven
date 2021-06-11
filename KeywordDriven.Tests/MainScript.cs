using System.IO;
using NUnit.Framework;
using KeywordDriven.Config;
using KeywordDriven.Utils;
using KeywordDriven.Execution;

namespace KeywordDriven.Tests
{
    public class MainScript
    {
        [SetUp]
        public void TestSetUp()
        {
            ExcelManager.SetExcel(Path.GetFullPath(@"../../../") + @"Creation\TestCases.xlsx");
            ExtentReporter.SetExtentReporter(Path.GetFullPath(@"../../../") + @"TestResults\index.html");

            DriverSetting.WebDriver("local", 20, 200, false);
            DriverSetting.AndroidDriver("PhoneOreo8.1", "emulator-5554", "8.1", "");
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