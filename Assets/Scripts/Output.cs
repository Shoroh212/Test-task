using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Output : MonoBehaviour, IMassage
{
    public void Conclusion(string text)
    {
        Debug.Log(text);
    }
}