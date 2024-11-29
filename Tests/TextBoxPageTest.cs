using NUnit.Framework;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;

namespace AutomationFramework.Tests
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Edge)]
    public class TextBoxPageTest : BaseTest
    {
        private BrowserType _browserType;

        public TextBoxPageTest(BrowserType browserType)
        {
            _browserType = browserType;
        }

        [SetUp]
        public void SetUp()
        {
            InitializeDriver(_browserType);
        }

        [Test, Description("Verify filling and submitting the Text Box form")]

        public void TestFillTextBoxForm()
        {
            var homePage = new HomePage(Driver);
            homePage.GoToElementsSection();

            // Navigate to Text Box section
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
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
