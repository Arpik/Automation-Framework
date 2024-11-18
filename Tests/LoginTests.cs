using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;


namespace AutomationFramework.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.EnterUsername("testuser");
            loginPage.EnterPassword("testpassword");
            loginPage.ClickLoginButton();

            Assert.IsTrue(driver.Url.Contains("dashboard")); // Replace with actual validation.
        }
    }
}

