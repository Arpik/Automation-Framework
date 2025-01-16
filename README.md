# Automation Framework

🚀 Automation Framework for seamless testing of web and desktop applications, 
designed to provide scalability, reliability, and ease of use. 
Built with C#, NUnit, and Selenium WebDriver, this framework supports parallel test execution, 
JSON-based test data management, and dynamic browser configuration.



# Overview

This project is a highly extensible automation framework designed for:

* Web application testing.
* Desktop application testing.
* Streamlined test data management using JSON.
* Dynamic browser configuration for multi-browser testing.



# Features 

✔️ Supports cross-browser testing (Chrome, Firefox, Edge).

✔️ Parallel test execution for faster feedback.

✔️ JSON-based test data integration for flexibility.

✔️ Modular and reusable page object model (POM).

✔️ Easy integration with CI/CD pipelines using GitHub Actions.

✔️ Logging and reporting for better test insights.



# Technologies Used

- C#
- NUnit
- Selenium WebDriver
- JSON.NET (for test data management)
- GitHub Actions (for CI/CD)



# Parallel Execution

This framework supports parallel test execution for improved efficiency. 
Tests are distributed across multiple threads or browsers dynamically.

To enable parallelism, ensure the following:

- Use the [Parallelizable] attribute in your test classes.
- Configure the ParallelScope appropriately.



# Folder Structure

AutomationFramework/

- Drivers/               *WebDriver configurations*

- Pages/                 *Page Object Models*

- Tests/                 *Test files*

- TestData/              *JSON files for test data*

- Utilities/             *Helper classes and utilities*

- README.md/             *Project documentation*

