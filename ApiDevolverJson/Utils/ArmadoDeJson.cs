using ApiDevolverJson.Models;
using System.Text.Json;

namespace ApiDevolverJson.Utils
{
    public class ArmadoDeJson
    {
        public string DevolverJson()
        {
            var persona = new Persona
            {
                Id = 1,
                Name = "Pablo",
                DNI = "37830335"
            };

            var valorEnJson = JsonSerializer.Serialize(persona).ToString();

            return valorEnJson;
        }
    }
}
