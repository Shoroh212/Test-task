using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public struct HelloMassage : NetworkMessage
{
    public string Text;
}

public struct SubscribeHelloMessage : NetworkMessage
{
}