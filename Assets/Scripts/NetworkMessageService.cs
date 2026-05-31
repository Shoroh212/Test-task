using Mirror;
using UnityEngine;
using Zenject;

public class NetworkMessageService : NetworkBehaviour
{
    [Inject]
    private IMassage _output;

    //клиент

    public override void OnStartServer()
    {
        NetworkServer.RegisterHandler<SubscribeHelloMessage>
        (
            OnClientSubscribe
        );
    }

    private void OnClientSubscribe
    (
        NetworkConnectionToClient conn,
        SubscribeHelloMessage msg
    )
    {

        HelloSubscriptionStorage.Subscribe(conn);

        conn.Send(new HelloMassage
        {
            Text = "Hello Client!"
        });
    }

  
    public override void OnStartClient()
    {
        NetworkClient.RegisterHandler<HelloMassage>
        (
            OnHelloMessage
        );
    }

    private void OnHelloMessage(HelloMassage msg)
    {
        _output.Conclusion(msg.Text);
    }

 

    public void SubscribeToHelloMessage()
    {
        if (!NetworkClient.isConnected) // если не подписан не удаляем 
            return;

        NetworkClient.Send(
            new SubscribeHelloMessage());
    }
}