using NUnit.Framework;
using AutomationFramework.Utilities;
using AutomationFramework.Pages;
using System;
using OpenQA.Selenium;
using static AutomationFramework.Utilities.LoadTestDataFromJson;
using System.Collections.Generic;
using YourProject.TestData.Models;
using AutomationFramework.Drivers;

namespace AutomationFramework.Tests
{

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class TextBoxTests : BaseTest
    {
        // Get all BrowserType values dynamically
        private static readonly BrowserType[] Browsers = (BrowserType[])Enum.GetValues(typeof(BrowserType));

        // Load test data from JSON file
        private static readonly IEnumerable<TextBoxTestData> TestData = TestDataLoader.LoadTestDataFromJson("TextBoxTestData.json");

        [Test, TestCaseSource(nameof(Browsers))]
        public void TestSubmitTextBoxForm(BrowserType browserType)
        {
            foreach (var data in TestData)
            {
                // Initialize the driver for the specified browser
                InitializeDriver(browserType);

                // Navigate to Home Page and Elements Section
                var homePage = new HomePage(Driver);
                ScrollToElement(homePage.ElementsSection);
                homePage.GoToElementsSection();

                // Navigate to Text Box Section
                var textBoxPage = new TextBoxPage(Driver);
                textBoxPage.ClickOnTextBoxItem();

                // Fill the TextBox form with data from JSON
                textBoxPage.FillTextBoxForm(data.FullName, data.Email, data.CurrentAddress, data.PermanentAddress);

                // Submit the form
                ScrollToElement(textBoxPage.SubmitButton);
                textBoxPage.ClickOnSubmitButton();

                // Perform Assertions based on the validity of the data

                // Assert.That(textBoxPage.GetOutputName(), Contains.Substring(data.FullName), "The name output is incorrect.");
                // Assert.That(textBoxPage.GetOutputEmail(), Contains.Substring(data.Email), "The email output is incorrect.");
                //Assert.That(textBoxPage.GetOutputCurrentAddress(), Contains.Substring(data.CurrentAddress), "The current address output is incorrect.");
                //Assert.That(textBoxPage.GetOutputPermanentAddress(), Contains.Substring(data.PermanentAddress), "The permanent address output is incorrect.");


                // Quit the driver after each test case
                QuitDriver();
            }
        }
    }
}