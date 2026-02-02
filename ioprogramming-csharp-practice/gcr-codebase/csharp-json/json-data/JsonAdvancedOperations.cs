using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;


    public class JsonAdvancedOperations
    {
        // 7. Filter users age > 25
        public static void FilterUsersByAge()
        {
            string json = File.ReadAllText("Data/users.json");
            JArray users = JArray.Parse(json);

            foreach (var user in users)
            {
                if ((int)user["age"] > 25)
                {
                    Console.WriteLine(user["name"]);
                }
            }
        }

        // 8. Print all keys and values
        public static void PrintAllKeys()
        {
            JObject obj = JObject.Parse(File.ReadAllText("Data/sample.json"));
            foreach (var prop in obj.Properties())
            {
                Console.WriteLine($"{prop.Name} : {prop.Value}");
            }
        }

        // 9. Convert JSON to XML
        public static void JsonToXml()
        {
            string json = File.ReadAllText("Data/sample.json");
            XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "Root");
            doc.Save("output.xml");
        }

        // 10. Convert CSV to JSON
        public static void CsvToJson()
        {
            var lines = File.ReadAllLines("Data/data.csv");
            var headers = lines[0].Split(',');

            var list = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var obj = new Dictionary<string, string>();

                for (int j = 0; j < headers.Length; j++)
                {
                    obj[headers[j]] = values[j];
                }

                list.Add(obj);
            }

            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
