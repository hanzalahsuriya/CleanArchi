using System.Text.Json.Serialization;

namespace Contracts.Subscriptions;

public record CreateSubscriptionRequest(SubscriptionType SubscriptionType, Guid AdminId);

public record SubscriptionResponse(Guid Id, SubscriptionType SubscriptionType);

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SubscriptionType
{
    Free,
    Starter,
    Pro
}