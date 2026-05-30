using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class NetworkMessageService : NetworkBehaviour
{
    public string message = "HelloMessage";


}


public interface IMassage
{
    void Conclusion(string text);
}