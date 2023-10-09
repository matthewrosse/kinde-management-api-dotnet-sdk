using System.Text.Json.Serialization;
using Kinde.ApiClient.Contracts.V1.Models;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record ErrorResponse(
    [property: JsonPropertyName("errors")] IReadOnlyCollection<Error> Errors
);