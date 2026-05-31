using System.Collections.Generic;
using Mirror;
using Unity;
public static class HelloSubscriptionStorage
{
    private static readonly HashSet<NetworkConnectionToClient>
        Subscribers = new();

    public static void Subscribe(
        NetworkConnectionToClient connection)

    {
        Subscribers.Add(connection);
    }

    public static IEnumerable<NetworkConnectionToClient>
        GetSubscribers()
    {
        return Subscribers;
    }

    public static void Remove(
        NetworkConnectionToClient connection)
    {
        Subscribers.Remove(connection);
    }
}