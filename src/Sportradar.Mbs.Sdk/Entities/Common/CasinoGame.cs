using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents a casino game.
/// </summary>
public class CasinoGame
{
    /// <summary>
    /// Gets or sets the provider of the casino game.
    /// </summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>
    /// Gets or sets the ID (or name) of the casino game.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}