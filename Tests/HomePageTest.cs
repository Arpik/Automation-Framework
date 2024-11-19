using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DemoQA.PageObjects;
using OpenQA.Selenium.Support.UI;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace DemoQA.Tests
{
    public class HomePageTest
    {
        private IWebDriver _driver;
        private HomePage _homePage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/");
            _homePage = new HomePage(_driver);
        }

        [AllureSeverity(SeverityLevel.critical)]
        [AllureDescription("This test validates a successful scenario for Element section.")]
        [Test]
        public void TestGoToElementsSection()
        {
            IWebElement element = _driver.FindElement(By.XPath("//h5[text()='Elements']"));
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.Click();
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }
}

