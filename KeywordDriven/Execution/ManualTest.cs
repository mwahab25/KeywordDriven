using System;
using System.Reflection;
using KeywordDriven.Config;
using KeywordDriven.Utils;
using KeywordDriven.ActionKeywords;
using System.Threading;

namespace KeywordDriven.Execution
{
    public class ManualTest
    {
        static int iTestStep;
        static int iTestLastStep;
        static String sTestCaseID;
        static String sTestCaseTitle;
        static String sTestCaseDesc;
        static String sTestStepDesc;
        static String sRunMode;
        static String sResult;
        internal static int iOutcome; // 1-Pass 2-Fail 3-Error

        public static void Execute_TestCases()
        {
            int iTotalTestCases = ExcelManager.GetRowCount(ExcelSetting.Sheet_TestCases);
            for (int iTestcase = 1; iTestcase < iTotalTestCases; iTestcase++)
            {
                iOutcome = 3;

                sTestCaseID = ExcelManager.GetCellData(iTestcase, ExcelSetting.Col_TestCases_ID, ExcelSetting.Sheet_TestCases);
                sTestCaseTitle = ExcelManager.GetCellData(iTestcase, ExcelSetting.Col_TestCases_Title, ExcelSetting.Sheet_TestCases);
                sTestCaseDesc = ExcelManager.GetCellData(iTestcase, ExcelSetting.Col_TestCases_Description, ExcelSetting.Sheet_TestCases);
                sRunMode = ExcelManager.GetCellData(iTestcase, ExcelSetting.Col_TestCases_RunMode, ExcelSetting.Sheet_TestCases);

                if (sRunMode.Equals("Yes"))
                {
                    Thread.Sleep(Convert.ToInt32(sTestCaseDesc));

                    Log.StartTestCase(sTestCaseID);
                    ExtentReporter.CreateTest(sTestCaseID + ":" + sTestCaseTitle, sTestCaseDesc);
                    ExtentReporter.StartTestCase(sTestCaseID);
                    iTestStep = ExcelManager.GetRowContains(sTestCaseID, ExcelSetting.Col_TestSteps_TestCaseID, ExcelSetting.Sheet_TestSteps);
                    iTestLastStep = ExcelManager.GetTestStepsCount(ExcelSetting.Sheet_TestSteps, sTestCaseID, iTestStep);

                    for (; iTestStep < iTestLastStep; iTestStep++)
                    {
                        sResult = ExcelManager.GetCellData(iTestStep, ExcelSetting.Col_TestSteps_Result, ExcelSetting.Sheet_TestSteps);
                        sTestStepDesc = ExcelManager.GetCellData(iTestStep, ExcelSetting.Col_TestSteps_Description, ExcelSetting.Sheet_TestSteps);

                        
                        if (sResult == "Pass")
                        {
                            ExtentReporter.Pass(sTestStepDesc);
                            iOutcome = 1;
                        }
                        else if (sResult == "Fail")
                        {
                            ExtentReporter.Fail(sTestStepDesc);
                            iOutcome = 2;
                            break;
                        }
                        else
                        {
                            ExtentReporter.Error(sTestStepDesc);
                        }
                    }
                    if (iOutcome == 1)
                    {
                        ExtentReporter.Pass("TestCase " + sTestCaseID + " Passed");
                        ExtentReporter.EndTestCase(sTestCaseID);
                    }
                    else if (iOutcome == 2)
                    {
                        ExtentReporter.Fail("TestCase " + sTestCaseID + " Failed");
                        ExtentReporter.EndTestCase(sTestCaseID);
                    }       
                    else
                    {
                        ExtentReporter.Error("Error in TestCase " + sTestCaseID);
                        ExtentReporter.EndTestCase(sTestCaseID);
                    }
                }
            }
        }
    }
}
