namespace KeywordDriven.Config
{
    class ExcelSetting
    {
        //Excel sheets Data
        public static string Sheet_PagesObjects = "Pages Objects";
        public static string Sheet_TestCases = "Test Cases";
        public static string Sheet_TestSteps = "Test Steps";
        public static string Sheet_Locators = "Locators";

        //Test Steps Sheet Column Numbers
        public static int Col_TestCaseID = 0;
        public static int Col_TestStepID = 1;
        public static int Col_TestStepDesc = 2;
        public static int Col_PageObject = 4;
        public static int Col_ActionKeyword = 5;
        public static int Col_DataSet = 6;
        public static int Col_TestStepResult = 7;

        //Test Cases Sheet Column Numbers 
        public static int Col_ID = 0;
        public static int Col_Title = 1;
        public static int Col_Description = 2;
        public static int Col_RunMode = 3;
        public static int Col_Result = 4;

        //Locators Sheet Column Numbers
        public static int Col_Loc_PageObject = 0;
        public static int Col_Locator = 1;
    }
}
