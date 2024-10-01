using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.CreateObject();
        }    
        else if(Input.GetKeyDown(KeyCode.E))
        {
            UtilityHelper.SetPositionToZero(this.gameObject);
        }
    }
}
