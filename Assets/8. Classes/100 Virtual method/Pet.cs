using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected string petName;
    protected virtual void Speak()
    {
        Debug.Log("Default Speak");
    }

    private void Start() 
    {
        Speak();
    }
}
