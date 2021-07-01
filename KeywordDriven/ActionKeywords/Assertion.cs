using KeywordDriven.Execution;
using KeywordDriven.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace KeywordDriven.ActionKeywords
{
    internal partial class Keywords
    {
        private static string GetElementTextByTypeDriver(By by, String type)
        {
            String txt = "";
            switch (type)
            {
                case "text":
                    txt = driver.FindElement(by).Text;
                    break;
                case "textContent":
                    txt = driver.FindElement(by).GetAttribute("textContent");
                    break;
                case "value":
                    txt = driver.FindElement(by).GetAttribute("value");
                    break;
                default:
                    break;
            }
            return txt;
        }

        private static string GetElementTextByTypeappiumDriver(By by, String type)
        {
            String txt = "";
            switch (type)
            {
                case "text":
                    txt = appiumdriver.FindElement(by).Text;
                    break;
                case "textContent":
                    txt = appiumdriver.FindElement(by).GetAttribute("textContent");
                    break;
                case "value":
                    txt = appiumdriver.FindElement(by).GetAttribute("value");
                    break;
                default:
                    break;
            }
            return txt;
        }

        private static string GetTextByDriver(By by)
        {
            string elementTxt = "";
            string[] types = { "text", "textContent", "value" };
            for (int i = 0; i < types.Length; i++)
            {
                if (!GetElementTextByTypeDriver(by, types[i]).Trim().Equals(""))
                {
                    elementTxt = GetElementTextByTypeDriver(by, types[i]).Trim();
                    break;
                }
            }
            Console.WriteLine(elementTxt);
            return elementTxt;
        }

        private static string GetTextByappiumDriver(By by)
        {
            string elementTxt = "";
            string[] types = { "text", "textContent", "value" };
            for (int i = 0; i < types.Length; i++)
            {
                if (!GetElementTextByTypeappiumDriver(by, types[i]).Trim().Equals(""))
                {
                    elementTxt = GetElementTextByTypeappiumDriver(by, types[i]).Trim();
                    break;
                }
            }
            Console.WriteLine(elementTxt);
            return elementTxt;
        }

        public static void AssetPass(String obj, String data)
        {

        }

        public static void AssetFail(String obj, String data)
        {
            
        }

        public static void AssetEqual(String obj, String data)
        {

        }

        public static void AssetNull(String obj, String data)
        {

        }

        public static void AssetElementExists(String obj, String data)
        {

        }

        public static void AssetElementContains(String obj, String data)
        {
            Log.Info($"AssertElement \"{obj}\" Contains \"{data}\"");
            ExtentReporter.NodeInfo($"AssertElement \"{obj}\" Contains \"{data}\"");
            try
            {
                string[] locator = obj.Split('_');
                By by = LocateValue(locator[1], GetKey(obj));

                if (locator[0] == "Mobile")
                {
                    WaitUntil(by, appiumdriver);

                    bool result = GetTextByappiumDriver(by).Contains(data);

                    Assert.AreEqual(result, true);
                    WaitSeconds("", "2");
                    DriverScript.iOutcome = 1;
                }
                else
                {
                    WaitUntil(by, driver);

                    bool result = GetTextByDriver(by).Contains(data);

                    Assert.AreEqual(result, true);
                    WaitSeconds("", "2");
                    DriverScript.iOutcome = 1;
                }
            }
            catch (AssertFailedException e)
            {
                Log.Error($"AssertElementContains Assert Fail| Exception: {e.Message}");
                ExtentReporter.NodeFail($"AssertElementContains Assert Fail| Exception: {e.Message}");
                DriverScript.iOutcome = 2;
            }
            catch (Exception e)
            {
                Log.Error($"Failed AssertElementContains | Exception: {e.Message}");
                ExtentReporter.NodeError($"Failed AssertElementContains | Exception: {e.Message}");
                DriverScript.iOutcome = 3;
            }
        }

        public static void AssertURLExists(String obj, String data)
        {

        }

        public static void AssertURLContains(String obj, String data)
        {

        }

        public static void AssetFileExists(String obj, String data)
        {
            
        }
    }
}
