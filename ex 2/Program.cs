using System;
using System.IO;
using System.Text.Json;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace JSONtoYML
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonRuta = "data.json"; // Path to the JSON file
            string yamlRuta = "data.yaml"; // Path to the YAML file

            string jsonString = File.ReadAllText(jsonRuta);
            string yamlString = JsonToYaml(jsonString);
            File.WriteAllText(yamlRuta, yamlString);

            Console.WriteLine("Yaml creat correctament: " + yamlRuta);
        }

        static string JsonToYaml(string jsonString)
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var jsonObject = JsonSerializer.Deserialize<object>(jsonString);
            var yamlObject = deserializer.Deserialize(new StringReader(jsonString));
            return serializer.Serialize(yamlObject);
        }
    }
}

