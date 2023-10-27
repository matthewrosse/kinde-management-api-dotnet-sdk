using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses.Common;

public record ErrorResponse(
    [property: JsonPropertyName("errors")] IReadOnlyCollection<Error> Errors
);