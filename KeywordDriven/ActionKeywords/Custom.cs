using System;
using System.IO;
using Tesseract;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KeywordDriven.ActionKeywords
{
    internal partial class Keywords
    {
        public static string captchatext;
        private static Bitmap GetCaptchaImage(By by)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            IWebElement captchaImage = driver.FindElement(by);

            Point point = captchaImage.Location;
            int width = captchaImage.Size.Width + 50;
            int height = captchaImage.Size.Height;

            Rectangle section = new Rectangle(point, new Size(width, height));
            Bitmap source = new Bitmap(new MemoryStream(screenshot.AsByteArray));

            Bitmap finalCaptchImage = CropImage(source, section);
            return finalCaptchImage;
        }
        private static Bitmap CropImage(Bitmap source, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            return bmp;
        }
        private static void SaveCaptchaImage(string filePath)
        {
            var remElement = driver.FindElement(By.XPath("//div[@id='divCaptcha']/img"));
            Point location = remElement.Location;

            var screenshot = (driver as ChromeDriver).GetScreenshot();
            using (MemoryStream stream = new MemoryStream(screenshot.AsByteArray))
            {
                using (Bitmap bitmap = new Bitmap(stream))
                {
                    RectangleF part = new RectangleF(location.X, location.Y, remElement.Size.Width, remElement.Size.Height);
                    using (Bitmap bn = bitmap.Clone(part, bitmap.PixelFormat))
                    {
                        bn.Save(filePath + "CaptchImage.png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
        }

        #region Public methods
        public static void GetCaptcha(String obj, String data)
        {
            string[] locator = obj.Split('_');
            By by = LocateValue(locator[1], GetKey(obj));

            string filePath = @"./";

            Bitmap bn = GetCaptchaImage(by);
            bn.Save(filePath + "CaptchImage.png", System.Drawing.Imaging.ImageFormat.Png);

            //reading text from images
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                Page ocrPage = engine.Process(Pix.LoadFromFile(filePath + "CaptchImage.png"), PageSegMode.AutoOnly);
                captchatext = ocrPage.GetText();
                Console.WriteLine(captchatext);
            }
        }
        public static void InputCaptcha(String obj, String data)
        {       
            Input(obj, captchatext);
        }
        #endregion
    }
}
