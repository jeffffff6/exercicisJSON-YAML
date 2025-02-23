using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;
using YamlDotNet.Serialization;
using System;

namespace JsonToYamlApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonToYamlController : ControllerBase
    {
        [HttpPost]
        public IActionResult ConvertJsonToYaml([FromBody] JsonElement json)
        {
            try
            {
                // Convertir el JSON a YAML
                string yaml = ConvertJsonToYamlLogic(json);

                // Retornar el YAML como respuesta
                return Ok(yaml);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error al convertir el JSON a YAML", error = ex.Message });
            }
        }

        // Método que convierte el JSON a YAML
        private string ConvertJsonToYamlLogic(JsonElement json)
        {
            // Convertir el JSON a String
            var jsonString = json.ToString();

            // Crear los objetos de deserialización y serialización YAML
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(YamlDotNet.Serialization.NamingConventions.CamelCaseNamingConvention.Instance)
                .Build();

            var serializer = new SerializerBuilder()
                .WithNamingConvention(YamlDotNet.Serialization.NamingConventions.CamelCaseNamingConvention.Instance)
                .Build();

            // Deserializar el JSON en un objeto
            var jsonObject = JsonSerializer.Deserialize<object>(jsonString);

            // Convertir a YAML
            var yamlObject = deserializer.Deserialize(new StringReader(jsonString));
            return serializer.Serialize(yamlObject);
        }
    }
}
