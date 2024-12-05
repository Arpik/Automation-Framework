using NUnit.Framework;
using AutomationFramework.Utilities;
using AutomationFramework.Pages;
using System;

namespace AutomationFramework.Tests
{
    [TestFixture]
    public class HomePageTests : BaseTest
    {
        // Get all BrowserType values dynamically
        private static readonly BrowserType[] Browsers = (BrowserType[])Enum.GetValues(typeof(BrowserType));

        [Test, TestCaseSource(nameof(Browsers))]
        public void TestGoToElementsSection(BrowserType browserType)
        {
            InitializeDriver(browserType); // Initialize the driver with the given browser type
            var homePage = new HomePage(Driver);

            ScrollToElement(homePage.ElementsSection);
            homePage.GoToElementsSection();
            Assert.That(Driver.Url.Contains("elements"), "Failed to navigate to the Elements section.");

            QuitDriver(); // Clean up after the test
        }
    }
}

