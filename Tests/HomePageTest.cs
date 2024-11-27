using NUnit.Framework;
using OpenQA.Selenium;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;

namespace AutomationFramework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Edge)]
    public class HomePageTests : BaseTest
    {
        private BrowserType _browserType;

        public HomePageTests(BrowserType browserType)
        {
            _browserType = browserType;
        }

        [SetUp]
        public void SetUp()
        {
            InitializeDriver(_browserType);
        }

        [Test, Description("Verify navigation to the Elements section")]
        public void TestGoToElementsSection()
        {
            var homePage = new HomePage(Driver);
            // Assert.That(homePage.IsElementsSectionDisplayed(), "Elements section is not displayed on the Home Page.");

            homePage.GoToElementsSection();
            Assert.That(Driver.Url.Contains("elements"), "Failed to navigate to the Elements section.");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
