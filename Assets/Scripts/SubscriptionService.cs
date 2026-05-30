using Mirror;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SubscriptionService : MonoBehaviour
{
   public IMassage _massage;

   
    [Inject]
    void Construct(IMassage massage)
    {
       this._massage = massage;
    }
    public  void Start()
    {
        _massage.Conclusion("Hello Message!");
       
    }
}
