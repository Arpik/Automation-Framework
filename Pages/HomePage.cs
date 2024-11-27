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
        private IWebElement ElementsSection => _driver.FindElement(By.XPath("//h5[text()='Elements']"));
        private IWebElement FormsSection => _driver.FindElement(By.XPath("//h5[text()='Forms']"));

        // Actions
        public void GoToElementsSection()
        {
            // Scroll to the element to make it visible
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", ElementsSection);

            // Wait for the element to be clickable (replacing SeleniumExtras)
            WaitForElementToBeClickable(ElementsSection);

            // Click the element
            ElementsSection.Click();
        }

        public void GoToFormsSection()
        {
            // Scroll to the element to make it visible
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", FormsSection);

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

