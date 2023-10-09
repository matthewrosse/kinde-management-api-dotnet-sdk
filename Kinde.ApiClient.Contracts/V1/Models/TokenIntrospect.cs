using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record TokenIntrospect(
    [property: JsonPropertyName("active")] bool Active,
    [property: JsonPropertyName("aud")] IReadOnlyCollection<string> Aud,
    [property: JsonPropertyName("client_id")]
    string ClientId,
    [property: JsonPropertyName("exp")] string Exp,
    [property: JsonPropertyName("iat")] string Iat
);