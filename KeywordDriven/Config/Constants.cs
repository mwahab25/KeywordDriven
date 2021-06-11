namespace KeywordDriven.Config
{
    class Constants
    {
        //Data Excel sheets
        public static string Sheet_PagesObjects = "Pages Objects";
        public static string Sheet_TestCases = "Test Cases";
        public static string Sheet_TestSteps = "Test Steps";
        public static string Sheet_Locators = "Locators";

        //Data Test Steps Sheet Column Numbers
        public static int Col_TestCaseID = 0;
        public static int Col_TestStepID = 1;
        public static int Col_TestStepDesc = 2;
        public static int Col_PageObject = 4;
        public static int Col_ActionKeyword = 5;
        public static int Col_DataSet = 6;
        public static int Col_TestStepResult = 7;

        //Data Test Cases Sheet Column Numbers 
        public static int Col_ID = 0;
        public static int Col_Title = 1;
        public static int Col_Description = 2;
        public static int Col_RunMode = 3;
        public static int Col_Result = 4;

        //Data Locators Sheet Column Numbers
        public static int Col_Loc_PageObject = 0;
        public static int Col_Locator = 1;
    }

    public class DriverSetting
    {
        internal static string _devicename;
        internal static string _udid;
        internal static string _platformversion;
        internal static string _apppath;

        internal static string _drivertype = "local";
        internal static double _timeout = 20;
        internal static double _navigationtimeout = 200;
        internal static bool _headless = false;

        public static void WebDriver(string drivertype, double timeout, double navigationtimeout, bool headless)
        {
            _drivertype = drivertype;
            _timeout = timeout;
            _navigationtimeout = navigationtimeout;
            _headless = headless;

        }
        public static void AndroidDriver(string devicename, string udid, string platformversion, string apppath)
        {
            _devicename = devicename;
            _udid = udid;
            _platformversion = platformversion;
            _apppath = apppath;
        }
    }
}
