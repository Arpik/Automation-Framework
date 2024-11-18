using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement UsernameField => driver.FindElement(By.Id("username")); // Replace with actual locators.
        private IWebElement PasswordField => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("login"));

        public void EnterUsername(string username) => UsernameField.SendKeys(username);
        public void EnterPassword(string password) => PasswordField.SendKeys(password);
        public void ClickLoginButton() => LoginButton.Click();
    }
}

