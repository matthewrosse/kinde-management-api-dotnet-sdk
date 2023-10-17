using System.Text.Json;
using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Converters;

internal sealed class CommaSeparatedCollectionJsonConverter : JsonConverter<ICollection<string>>
{
    public override ICollection<string>? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
        => reader
            .GetString()?
            .Split(',')
            .ToList();

    public override void Write(Utf8JsonWriter writer, ICollection<string> value, JsonSerializerOptions options)
        => writer.WriteStringValue(string.Join(',', value));
}