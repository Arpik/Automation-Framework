using AutomationFramework.DataGenerator;
using Bogus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
//using YourNamespace.DataGenerator;  // Make sure this using statement is added

namespace AutomationFramework.DataGenerator
{
    public class AIDataGenerator
    {
        public static void GenerateUserData(string fileName = "testData.json")
        {
            var faker = new Faker<UserData>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Gender, f => f.PickRandom(new[] { "Male", "Female", "Other" }))
                .RuleFor(u => u.Mobile, f => f.Phone.PhoneNumber("##########"))
                .RuleFor(u => u.DOB, f => f.Date.Past(30, DateTime.Now.AddYears(-18)).ToString("dd-MM-yyyy"))
                .RuleFor(u => u.Hobbies, f => f.Make(2, () => f.PickRandom(new[] { "Sports", "Reading", "Music" })))
                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .RuleFor(u => u.State, f => f.Address.State())
                .RuleFor(u => u.City, f => f.Address.City());

            // Generate the user data
            var userData = faker.Generate();

            // Serialize the data to JSON
            var json = JsonSerializer.Serialize(userData, new JsonSerializerOptions { WriteIndented = true });

            // Save the JSON data to a file
            File.WriteAllText(fileName, json);
        }
    }
}

