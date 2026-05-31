using Mirror;

public class ClientHelloSubscriber : NetworkBehaviour
{
    //Клиент 
    public override void OnStartClient()
    {
        NetworkClient.Send(
            new SubscribeHelloMessage());
    }
}