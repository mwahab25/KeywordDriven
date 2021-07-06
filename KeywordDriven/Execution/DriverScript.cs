using System;
using System.Reflection;
using KeywordDriven.Config;
using KeywordDriven.Utils;
using KeywordDriven.ActionKeywords;

namespace KeywordDriven.Execution
{
    public class DriverScript
    {
        static Keywords actionKeywords;
        static String sActionKeyword;
        static String sPageObject;
        static MethodInfo[] method;
        static int iTestStep;
        static int iTestLastStep;
        static String sTestCaseID;
        static String sTestCaseTitle;
        static String sTestCaseDesc;
        static String sTestStepDesc;
        static String sRunMode;
        static String sData;
        internal static int iOutcome; // 1-Pass 2-Fail 3-Error
        internal static int iOutcomePass;  //1-Pass
        internal static int iOutcomeFail;  //2-Fail
        internal static int iOutcomeError; //3-Error

        static DriverScript()
        {
            actionKeywords = new Keywords();
            method = actionKeywords.GetType().GetMethods();
        }

        public static void Execute_TestCases()
        {
            int iTotalTestCases = ExcelManager.GetRowCount(Constants.Sheet_TestCases);
            for (int iTestcase = 1; iTestcase < iTotalTestCases; iTestcase++)
            {
                iOutcome = 1;
                sTestCaseID = ExcelManager.GetCellData(iTestcase, Constants.Col_ID, Constants.Sheet_TestCases);
                sTestCaseTitle = ExcelManager.GetCellData(iTestcase, Constants.Col_Title, Constants.Sheet_TestCases);
                sTestCaseDesc = ExcelManager.GetCellData(iTestcase, Constants.Col_Description, Constants.Sheet_TestCases);
                sRunMode = ExcelManager.GetCellData(iTestcase, Constants.Col_RunMode, Constants.Sheet_TestCases);

                if (sRunMode.Equals("Yes"))
                {
                    Log.StartTestCase(sTestCaseID);
                    ExtentReporter.CreateTest(sTestCaseID + "_" + sTestCaseTitle, sTestCaseDesc);
                    ExtentReporter.StartTestCase(sTestCaseID + "_" + sTestCaseTitle);
                    iTestStep = ExcelManager.GetRowContains(sTestCaseID, Constants.Col_TestCaseID, Constants.Sheet_TestSteps);
                    iTestLastStep = ExcelManager.GetTestStepsCount(Constants.Sheet_TestSteps, sTestCaseID, iTestStep);
                    iOutcome = 1;
                    for (; iTestStep < iTestLastStep; iTestStep++)
                    {
                        sActionKeyword = ExcelManager.GetCellData(iTestStep, Constants.Col_ActionKeyword, Constants.Sheet_TestSteps);
                        sPageObject = ExcelManager.GetCellData(iTestStep, Constants.Col_PageObject, Constants.Sheet_TestSteps);
                        sData = ExcelManager.GetCellData(iTestStep, Constants.Col_DataSet, Constants.Sheet_TestSteps);
                        sTestStepDesc = ExcelManager.GetCellData(iTestStep, Constants.Col_TestStepDesc, Constants.Sheet_TestSteps);
                        ExtentReporter.CreateNode(sTestStepDesc);
                        Execute_Actions();

                        if (iOutcome == 3)
                        {
                            ExcelManager.SetCellData(Outcome.Error.ToString(), iTestcase, Constants.Col_Result, Constants.Sheet_TestCases);
                            Log.EndTestCase(sTestCaseID);
                            ExtentReporter.Error("TestCase " + sTestCaseID + "_" + sTestCaseTitle + " Error");
                            ExtentReporter.EndTestCase(sTestCaseID + "_" + sTestCaseTitle);
                            //Assert.Fail();
                            break;
                        }
                    }

                    if (iOutcome == 1)
                    {
                        ExcelManager.SetCellData(Outcome.Pass.ToString(), iTestcase, Constants.Col_Result, Constants.Sheet_TestCases);
                        Log.EndTestCase(sTestCaseID);
                        ExtentReporter.Pass("TestCase " + sTestCaseID + "_" + sTestCaseTitle + " Passed");
                        ExtentReporter.EndTestCase(sTestCaseID + "_" + sTestCaseTitle);
                    }
                    else if (iOutcome == 2)
                    {
                        ExcelManager.SetCellData(Outcome.Fail.ToString(), iTestcase, Constants.Col_Result, Constants.Sheet_TestCases);
                        Log.EndTestCase(sTestCaseID);
                        ExtentReporter.Fail("TestCase " + sTestCaseID + "_" + sTestCaseTitle + " Failed");
                        ExtentReporter.EndTestCase(sTestCaseID + "_" + sTestCaseTitle);
                    }
                }
            }
        }

        static void Execute_Actions()
        {
            for (int i = 0; i < method.Length; i++)
            {

                if (method[i].Name.Equals(sActionKeyword))
                {
                    method[i].Invoke(actionKeywords, new object[] { sPageObject, sData });

                    if (iOutcome == 1)
                    {
                        ExcelManager.SetCellData(Outcome.Pass.ToString(), iTestStep, Constants.Col_TestStepResult, Constants.Sheet_TestSteps);
                        ExtentReporter.Pass(sTestStepDesc);
                        break;
                    }
                    else if (iOutcome == 2)
                    {
                        ExcelManager.SetCellData(Outcome.Fail.ToString(), iTestStep, Constants.Col_TestStepResult, Constants.Sheet_TestSteps);
                        ExtentReporter.Fail(sTestStepDesc);
                        //ActionKeywords.CloseBrowser("", "");
                        break;
                    }
                    else if (iOutcome == 3)
                    {
                        ExcelManager.SetCellData(Outcome.Error.ToString(), iTestStep, Constants.Col_TestStepResult, Constants.Sheet_TestSteps);
                        ExtentReporter.Error(sTestStepDesc);
                        //ActionKeywords.CloseBrowser("", "");
                        break;
                    }
                }
            }
        }
    }
}
