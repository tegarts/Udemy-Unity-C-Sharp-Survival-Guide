using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public PrimitiveType type;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ColorHelper.SpawnObject(type);
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            ColorHelper.RandomColor2(this.gameObject, Color.red, true);
        }
    }
}
