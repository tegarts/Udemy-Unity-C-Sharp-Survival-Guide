using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            if (value == true)
            {
                Debug.Log("Oh no, the game is over!");
            }

            isGameOver = value;
        }
    }

    public bool IsStartGame {get; protected set;} // Auto properties

    private void Start() 
    {
        isGameOver = false;    
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;
        }    
    }
}
