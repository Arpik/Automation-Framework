using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using AutomationFramework.Utilities;

namespace AutomationFramework.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver;

        /// <summary>
        /// Initializes the WebDriver instance based on the specified browser type.
        /// </summary>
        /// <param name="browserType">The browser type to use for the test.</param>
        protected void InitializeDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                case BrowserType.Edge:
                    Driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException($"Unsupported browser type: {browserType}");
            }

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        /// <summary>
        /// Closes the WebDriver instance and cleans up resources.
        /// </summary>
        protected void QuitDriver()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
        }
    }
}
