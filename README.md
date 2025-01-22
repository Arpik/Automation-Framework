# AI-Integrated Automation Framework

## Project Overview
The **AI-Integrated Automation Framework** is a test automation framework developed in **C#/.NET**. It combines the power of **Selenium** and **NUnit** for automating web applications, while also integrating AI-driven capabilities for intelligent test data generation. This framework is designed to enhance testing accuracy, scalability, and maintainability by producing realistic, context-aware test data.

---

## Features
- **AI-Powered Test Data Generation:**
  - Automatically generates realistic and diverse test data using AI algorithms.
  - Context-aware data generation for different testing scenarios.

- **Selenium Integration:**
  - Supports web application automation for multiple browsers.
  - Provides easy-to-use page object model (POM) implementations.

- **NUnit Integration:**
  - Enables test organization and execution.
  - Generates detailed reports for test results.

- **Modular Design:**
  - Well-structured and scalable for easy maintenance.
  - Supports adding and managing multiple test cases seamlessly.

- **Efficient Data Handling:**
  - Uses `System.Text.Json` for lightweight and efficient data serialization.

---

## Installation
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/ai-integrated-automation-framework.git
   ```

2. **Open the Project in Visual Studio:**
   - Navigate to the project directory.
   - Open the `.sln` file in Visual Studio.

3. **Install Required NuGet Packages:**
   - Open the **NuGet Package Manager**.
   - Install the following dependencies:
     - Selenium.WebDriver
     - NUnit
     - System.Text.Json

4. **Build the Solution:**
   - Go to **Build** → **Rebuild Solution** in Visual Studio.

---

## Usage
1. **Add Test Cases:**
   - Write your test cases in the `Tests` folder using NUnit.

2. **Run Tests:**
   - Open the **Test Explorer** in Visual Studio.
   - Select and execute test cases or the entire suite.

3. **Generate Test Data:**
   - Customize the AI-driven test data generator in the `AIDataGenerator.cs` file under the `DataGenerator` folder.

4. **View Results:**
   - Access detailed test execution results and reports.

---

## Folder Structure
```
├── DataGenerator
│   ├── AIDataGenerator.cs  # AI-powered test data generation logic
│   ├── UserData.cs         # Data model for user test data
├── Pages
│   ├── [PageObjects].cs   # Page Object Model classes for web and desktop apps
├── Tests
│   ├── [YourTestCases].cs # NUnit test cases
├── JSON
│   ├── [TestData].json    # Sample test data files
├── Drivers
│   ├── [BrowserDrivers]   # WebDriver binaries
├── README.md              # Project documentation
```

---

## Technologies Used
- **Programming Language:** C#/.NET
- **Automation Tools:** Selenium, NUnit
- **AI Integration:** AI-based test data generation
- **Data Serialization:** System.Text.Json
