using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProject.TestData.Models;

namespace AutomationFramework.Utilities
{
    internal class LoadTestDataFromJson
    {
        public static class TestDataLoader
        {
            public static IEnumerable<TextBoxTestData> LoadTestDataFromJson(string fileName)
            {
                string filePath = Path.Combine("TestData", "JSON", fileName);
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"Test data file '{fileName}' not found.");
                }

                var jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<TextBoxTestData>>(jsonData);
            }
        }
    }
}
