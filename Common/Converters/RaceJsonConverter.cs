using Common.Base;
using Common.Factories;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GMHelper.Converters
{
    public class RaceJsonConverter : JsonConverter<Race>
    {
        public override Race ReadJson(JsonReader reader, Type objectType, Race existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            // Deserialize the Race property based on the "Type" property
            string raceType = jsonObject["Name"].ToObject<string>();
            string stats = jsonObject["Stats"].ToString();
            int id = jsonObject["Id"].ToObject<int>();

            var statsObj = JsonConvert.DeserializeObject<Stats>(stats);

            var race = RaceFactory.CreateByName(raceType);   
            race.Stats = statsObj;
            race.Id = id;
            return race;
        }

        public override void WriteJson(JsonWriter writer, Race value, JsonSerializer serializer)
        {
            // Serialize the Race property
            serializer.Serialize(writer, value, value.GetType());
        }
    }
}