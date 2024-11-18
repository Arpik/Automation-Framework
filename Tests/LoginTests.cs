using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using NUnit.Framework;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
// using Allure.NUnit.Attributes;


namespace AutomationFramework.Tests
{
    [AllureNUnit]
    [AllureSuite("Login Tests")]
    public class LoginTests : BaseTest
    {
        [Test]
        [AllureSeverity(SeverityLevel.critical)]
        public void SuccessfulLoginTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.EnterUsername("testuser");
            loginPage.EnterPassword("testpassword");
            loginPage.ClickLoginButton();

            Assert.That(driver.Url.Contains("dashboard")); // Replace with actual validation.
        }
    }
}

