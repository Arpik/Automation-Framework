using NUnit.Framework;
using AutomationFramework.Utilities;
using AutomationFramework.Pages;
using System;

namespace AutomationFramework.Tests
{
    [TestFixture]
    public class TextBoxPageTests : BaseTest
    {
        private static readonly BrowserType[] Browsers = (BrowserType[])Enum.GetValues(typeof(BrowserType));

        [Test, TestCaseSource(nameof(Browsers))]
        public void TestFillTextBoxForm(BrowserType browserType)
        {
            InitializeDriver(browserType);
            var textBoxPage = new TextBoxPage(Driver);

            textBoxPage.FillTextBoxForm("John Doe", "john.doe@example.com", "123 Main St", "456 Elm St");
            // Assert.That(textBoxPage.IsFormSubmittedSuccessfully(), "TextBox form submission failed.");

            QuitDriver(); // Clean up after the test
        }
    }
}
