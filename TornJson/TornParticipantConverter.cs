using System;
using Newtonsoft.Json;
using TornJson.CommonData;
using TornJson.FactionData;
using TornJson.TornData;

namespace TornJson
{
    public class TornParticipantConverter : JsonConverter<OrganizedCrimeParticipant>
    {
        public override void WriteJson(JsonWriter writer, OrganizedCrimeParticipant value, JsonSerializer serializer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            
            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }
            
            writer.WriteStartObject();
            writer.WritePropertyName(value.PlayerId.ToString(writer.Culture));
            serializer.Serialize(writer, value.Status);
            writer.WriteEndObject();
        }

        public override OrganizedCrimeParticipant ReadJson(JsonReader reader, Type objectType,
            OrganizedCrimeParticipant existingValue,
            bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            if (!hasExistingValue || existingValue == null)
            {
                existingValue = new OrganizedCrimeParticipant();
            }

            reader.Read();
            existingValue.PlayerId = int.Parse(reader.Value!.ToString(), reader.Culture);
            reader.Read();
            if (reader.TokenType == JsonToken.StartObject)
            {
                existingValue.Status = new Status();
                serializer.Populate(reader, existingValue.Status);
                reader.Read();
            }
            else if (reader.TokenType == JsonToken.Null)
            {
                reader.Read();
            }

            return existingValue;
        }
    }
}