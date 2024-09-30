using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public int playerId;
    public string playerName;

    public static int connectedPlayers;

    public PlayerData()
    {
        connectedPlayers++;
    }
}

public class Player : MonoBehaviour
{
    private void Start() {
        PlayerData p1 = new PlayerData();
        PlayerData p2 = new PlayerData();
        PlayerData p3 = new PlayerData();

        Debug.Log("Connected Players: " + PlayerData.connectedPlayers);
    }
}
