namespace Application.Services;

public interface ISubscriptionService
{
    Guid CreateSubscription(string subscriptionType, Guid adminId);
}

public class SubscriptionService : ISubscriptionService
{
    public Guid CreateSubscription(string subscriptionType, Guid adminId)
    {
        return Guid.NewGuid();
    }
}