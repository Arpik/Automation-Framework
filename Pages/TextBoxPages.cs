using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class TextBoxPage
    {
        private readonly IWebDriver _driver;

        // Constructor
        public TextBoxPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Locators
        private IWebElement TextBoxItem => _driver.FindElement(By.Id("item-0"));
        private IWebElement FullNameInput => _driver.FindElement(By.Id("userName"));
        private IWebElement EmailInput => _driver.FindElement(By.Id("userEmail"));
        private IWebElement CurrentAddressInput => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement PermanentAddressInput => _driver.FindElement(By.Id("permanentAddress"));
        private IWebElement SubmitButton => _driver.FindElement(By.Id("submit"));
        private IWebElement OutputName => _driver.FindElement(By.Id("name"));
        private IWebElement OutputEmail => _driver.FindElement(By.Id("email"));

        // Actions
        public void ClickOnTextBoxItem()
        {
            TextBoxItem.Click();
        }

        public void FillTextBoxForm(string fullName, string email, string currentAddress, string permanentAddress)
        {
            FullNameInput.Clear();
            FullNameInput.SendKeys(fullName);

            EmailInput.Clear();
            EmailInput.SendKeys(email);

            CurrentAddressInput.Clear();
            CurrentAddressInput.SendKeys(currentAddress);

            PermanentAddressInput.Clear();
            PermanentAddressInput.SendKeys(permanentAddress);

            SubmitButton.Click();
        }

        public string GetOutputName() => OutputName.Text;
        public string GetOutputEmail() => OutputEmail.Text;
    }
}

