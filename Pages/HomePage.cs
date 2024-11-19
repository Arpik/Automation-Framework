using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace DemoQA.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        // Constructor
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Locators
        private IWebElement ElementsSection => _driver.FindElement(By.XPath("//h5[text()='Elements']"));
        private IWebElement FormsSection => _driver.FindElement(By.XPath("//h5[text()='Forms']"));

        // Actions
        public void GoToElementsSection()
        {
            ElementsSection.Click();
        }

        public void GoToFormsSection()
        {
            FormsSection.Click();
        }
    }
}
