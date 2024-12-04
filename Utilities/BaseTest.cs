using NUnit.Framework;
using OpenQA.Selenium;
using AutomationFramework.Utilities;
using AutomationFramework.Drivers;
using System;

namespace AutomationFramework.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        public void InitializeDriver(BrowserType browserType)
        {
            Driver = WebDriverFactory.CreateDriver(browserType);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        public void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void QuitDriver()
        {
            Driver.Quit();
        }
    }
}
