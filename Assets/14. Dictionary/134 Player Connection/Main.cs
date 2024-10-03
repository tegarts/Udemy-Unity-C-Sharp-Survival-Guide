using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3
{
    public string name;
    public int id;

    public Player3(int id)
    {
        this.id = id;
    }
}


public class Main : MonoBehaviour
{
    public Dictionary<int, Player3> playerDictionary = new Dictionary<int, Player3>();

    Player3 p2;
    private void Start() 
    {
        Player3 p1 = new Player3(1);
        p1.name = "James";

        p2 = new Player3(200);
        p2.name = "John";

        Player3 p3 = new Player3(33);
        p3.name = "Asep";

        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);

    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[200]; // 200 bisa diganti p2.id, pokoknya global variabel
            Debug.Log("Player Name: " + player.name);
        }
    }
}
