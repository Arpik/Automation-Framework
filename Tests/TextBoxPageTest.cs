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

        [Test, TestCaseSource(nameof(Browsers)), Description("Verify filling and submitting the Text Box form for multiple browsers")]
        public void TestFillTextBoxForm(BrowserType browserType)
        {
            // Initialize browser
            InitializeDriver(browserType);

            // Navigate to Home Page and Elements Section
            var homePage = new HomePage(Driver);
            homePage.GoToElementsSection();

            // Navigate to Text Box Section and Fill the Form
            var textBoxPage = new TextBoxPage(Driver);
            textBoxPage.ClickOnTextBoxItem();
            textBoxPage.FillTextBoxForm(
                "Something Beautiful",
                "somethingbeautiful@example.com",
                "The best address to live / 1",
                "456 Elm St"
            );

            // Assertions
            Assert.That(textBoxPage.GetOutputName(), Contains.Substring("Something Beautiful"), "Name output is incorrect.");
            Assert.That(textBoxPage.GetOutputEmail(), Contains.Substring("somethingbeautiful@example.com"), "Email output is incorrect.");

            // Quit the driver
            QuitDriver();
        }
    }
}