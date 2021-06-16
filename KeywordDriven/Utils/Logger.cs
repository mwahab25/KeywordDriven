﻿using System;
using System.IO;

namespace KeywordDriven.Utils
{
    public class Log
    {
        private static string _filepath;

        private static object _setLoggerLock = new object();

        public static void SetLogger(string filepath)
        {
            lock (_setLoggerLock)
            {
                _filepath = filepath;

                using (var log = File.CreateText(_filepath))
                {
                    log.WriteLine($"Starting timestamp: {DateTime.Now.ToLocalTime()}");
                }
            }
        }

        private static void WriteLine(string text)
        {
            using (var log = File.AppendText(_filepath))
            {
                log.WriteLine(text);
            }
        }

        private static void Write(string text)
        {
            using (var log = File.AppendText(_filepath))
            {
                log.Write(text);
            }
        }
      
        /// <summary>
        /// Info Start Test Case
        /// </summary>
        internal static void StartTestCase(String sTestCaseName)
        {
            Info("Start TestCase " + sTestCaseName);
        }

        /// <summary>
        /// Info End Test Case
        /// </summary>
        internal static void EndTestCase(String sTestCaseName)
        {
            Info("End TestCase " + sTestCaseName);
            WriteLine($"-------------------------");
        }

        /// <summary>
        /// Info test step
        /// </summary>
        internal static void Info(string message)
        {
            WriteLine($"[INFO]: {message}");
        }

        /// <summary>
        /// Test step
        /// </summary>
        internal static void Step(string message)
        {
            WriteLine($"    [STEP]: {message}");
        }

        /// <summary>
        /// Warning test step
        /// </summary>
        internal static void Warning(string message)
        {
            WriteLine($"[WARNING]: {message}");
        }

        /// <summary>
        /// Error test step
        /// </summary>
        internal static void Error(string message)
        {
            WriteLine($"[ERROR]: {message}");
        }

        /// <summary>
        /// Fatal test step
        /// </summary>
        internal static void Fatal(string message)
        {
            WriteLine($"[FATAL]: {message}");
        }

        /// <summary>
        /// Debug test step
        /// </summary>
        internal static void Debug(string message)
        {
            WriteLine($"[DEBUG]: {message}");
        }
    }
}
