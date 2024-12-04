using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework.Pages
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
        public IWebElement ElementsSection => _driver.FindElement(By.XPath("//h5[text()='Elements']"));
        public IWebElement FormsSection => _driver.FindElement(By.XPath("//h5[text()='Forms']"));

        // Actions
        public void GoToElementsSection()
        {
            // Wait for the element to be clickable (replacing SeleniumExtras)
            WaitForElementToBeClickable(ElementsSection);

            // Click the element
            ElementsSection.Click();
        }

        public void GoToFormsSection()
        {
            // Wait for the element to be clickable
            WaitForElementToBeClickable(FormsSection);

            // Click the element
            FormsSection.Click();
        }

        // Custom Wait Method
        private void WaitForElementToBeClickable(IWebElement element, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver =>
            {
                try
                {
                    return element.Displayed && element.Enabled;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }
    }
}

