using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using AutomationFramework.Utilities;
using System;

namespace AutomationFramework.Drivers
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeDriver();

                case BrowserType.Firefox:
                    return new FirefoxDriver();

                case BrowserType.Edge:
                    return new EdgeDriver();

                default:
                    throw new ArgumentException("Invalid browser type");
            }
        }
    }
}
