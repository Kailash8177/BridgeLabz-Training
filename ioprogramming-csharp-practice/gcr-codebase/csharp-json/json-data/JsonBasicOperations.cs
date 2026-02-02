using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using JsonDataHandlingAssignment.Models;

    public class JsonBasicOperations
    {
        // 1. Create Student JSON
        public static void CreateStudentJson()
        {
            Student student = new Student
            {
                Name = "Amit",
                Age = 22,
                Subjects = new List<string> { "Math", "Physics", "CS" }
            };

            string json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine(json);
        }

        // 2. Convert Car object to JSON
        public static void ConvertCarToJson()
        {
            Car car = new Car { Brand = "BMW", Year = 2023 };
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }

        // 3. Read JSON & extract fields
        public static void ReadJsonAndExtract()
        {
            string json = File.ReadAllText("Data/user.json");
            JObject obj = JObject.Parse(json);

            Console.WriteLine(obj["name"]);
            Console.WriteLine(obj["email"]);
        }

        // 4. Merge two JSON objects
        public static void MergeJsonObjects()
        {
            JObject obj1 = JObject.Parse(@"{ 'name':'Amit' }");
            JObject obj2 = JObject.Parse(@"{ 'age':25 }");

            obj1.Merge(obj2);
            Console.WriteLine(obj1);
        }

        // 5. Validate JSON using Schema
        public static void ValidateJson()
        {
            string schemaJson = @"{
              'type':'object',
              'properties':{
                'email':{'type':'string','format':'email'}
              }
            }";

            JSchema schema = JSchema.Parse(schemaJson);
            JObject obj = JObject.Parse(@"{ 'email':'test@gmail.com' }");

            Console.WriteLine(obj.IsValid(schema));
        }

        // 6. Convert list to JSON array
        public static void ListToJsonArray()
        {
            List<Car> cars = new List<Car>
            {
                new Car{ Brand="BMW", Year=2022 },
                new Car{ Brand="Audi", Year=2021 }
            };

            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
            Console.WriteLine(json);
        }
    }

