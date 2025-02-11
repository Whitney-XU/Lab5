﻿using System;

namespace Exercise5
{
    public class MyClass
    {
        public delegate void LogHandler(string message);
        public void Process(LogHandler logHandler)
        {
            if (logHandler != null)
            {
                logHandler("begin");
            }
            if (logHandler != null)
            {
                logHandler("End");
            }
        }
    }
    public class MyLogger
    {
        public void Logger(string s)
        {
            Console.WriteLine(s);
        }
    }
    public class TestApplicatin
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            MyLogger f1 = new MyLogger();
            MyClass myclass = new MyClass();
            MyClass.LogHandler myLogger = null;
            myLogger += new MyClass.LogHandler(Logger);
            myLogger += new MyClass.LogHandler(f1.Logger);
            myclass.Process(myLogger);
            return; 
        }
    }
}
