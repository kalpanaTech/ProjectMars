﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.SpecflowPages.Helpers
{
    public class Driver
    {
        public static IWebDriver driver;

        public static IWebDriver InitializeDriver(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Unsupported browser selected: " + browser);
            }
            return driver;
        }

        public static void QuitDriver()
        {
            driver?.Quit();
        }
    }
}
