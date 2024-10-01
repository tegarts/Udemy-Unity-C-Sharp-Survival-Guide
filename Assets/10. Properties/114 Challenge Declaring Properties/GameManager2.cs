using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLagi
{
    GameManager2 gm = new GameManager2();

    public TestLagi()
    {
        //gm.speed = 10.0f; // Error: speed is read-only
        gm.uname = "test";
    }
}

public class GameManager2 : MonoBehaviour
{
    public float speed {get; private set;}
    public string uname {get; set;}

    private void Start() 
    {
        speed = 5.0f;
        uname = "Player";
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed = 10.0f;
            uname = "Player2";
        }    
    }
}
