using System;
using Excel = Microsoft.Office.Interop.Excel;
using KeywordDriven.Config;

namespace KeywordDriven.Utils
{
    public class ExcelManager
    {
        private static Excel.Application ExcelApp;
        private static Excel.Workbook ExcelWBook;
        private static Excel.Worksheet ExcelWSheet;

        /// <summary>
        /// Open specific Excel workbook
        /// </summary>
        public static void SetExcel(String path)
        {
            ExcelApp = new Excel.Application
            {
                Visible = false
            };
            ExcelWBook = ExcelApp.Workbooks.Open(path);
        }

        public static void SaveCloseExcel()
        {
            ExcelWBook.Save();
            ExcelWBook.Close(0);
            ExcelApp.Quit();
        }

        /// <summary>
        /// Get cell data from specific Excel sheet
        /// </summary>
        internal static string GetCellData(int rowNum, int colNum, String sheetName)
        {
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            string cellValue = (ExcelWSheet.Cells[rowNum + 1, colNum + 1] as Excel.Range).Text as string;
            return cellValue;
        }

        /// <summary>
        /// Get used rows count from specific Excel sheet
        /// </summary>
        internal static int GetRowCount(String sheetName)
        {
            int number;
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            number = ExcelWSheet.UsedRange.Rows.Count + 1;
            return number;
        }

        /// <summary>
        /// Get specific cell contains based on test case from specific Excel sheet
        /// </summary>
        internal static int GetRowContains(String testCaseName, int colNum, String sheetName)
        {
            int rowNum = 0;
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            int rowCount = GetRowCount(sheetName);

            for (; rowNum < rowCount; rowNum++)
            {
                if (GetCellData(rowNum, colNum, sheetName).Equals(testCaseName))
                {
                    break;
                }
            }
            return rowNum;
        }

        internal static string GetKeyValue(String KeyName, int colNum, String sheetName)
        {
            int rowNum = 0;
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            int rowCount = GetRowCount(sheetName);

            for (; rowNum < rowCount; rowNum++)
            {
                if (GetCellData(rowNum, colNum, sheetName).Equals(KeyName))
                {
                    break;
                }
            }
            return GetCellData(rowNum, colNum+1, sheetName);
        }

        /// <summary>
        /// Get number of steps of test case from specific Excel sheet
        /// </summary>
        internal static int GetTestStepsCount(String sheetName, String testCaseID, int testCaseStart)
        {
            for (int i = testCaseStart; i <= ExcelManager.GetRowCount(sheetName); i++)
            {
                if (!testCaseID.Equals(ExcelManager.GetCellData(i, Constants.Col_TestCaseID, sheetName)))
                {
                    int number = i;
                    return number;
                }
            }
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            int number1 = ExcelWSheet.UsedRange.Rows.Count + 1;
            return number1;
        }

        /// <summary>
        /// Set data into cell in specific Excel sheet
        /// </summary>
       internal static void SetCellData(String Result, int rowNum, int colNum, String sheetName)
        {
            ExcelWSheet = ExcelWBook.Sheets[sheetName] as Excel.Worksheet;
            (ExcelWSheet.Cells[rowNum + 1, colNum + 1] as Excel.Range).Value = Result;
        }
    }
}
