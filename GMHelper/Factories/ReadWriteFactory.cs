using Common.Base;
using GMHelper.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace GMHelper.Factories
{
    public static class ReadWriteFactory
    {
        public static Character? ReadCharacter(string filepath)
        {
            string json;

            if (File.Exists(filepath))
            {

                using (StreamReader reader = new StreamReader(filepath))
                {
                    json = reader.ReadToEnd();
                }
                JObject jsonObject = JObject.Parse(json);
                JToken raceToken = jsonObject["Race"];

                JToken nameToken = raceToken["Name"].Value<string>();

                // Create an instance of JsonSerializerSettings
                JsonSerializerSettings settings = new JsonSerializerSettings();

                // Add your custom converter to the Converters collection
                settings.Converters.Add(new RaceJsonConverter());

                Character? c = JsonConvert.DeserializeObject<Character>(json, settings);
                return c;
            }
            else
            {
                return null;
            }

        }
    }
}
