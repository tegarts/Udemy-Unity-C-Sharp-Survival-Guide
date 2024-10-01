using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Items> itemDatabase = new List<Items>();

    public void AddItem(int ItemID, Players player)
    {
        foreach(var items in itemDatabase)
        {
            if(items.itemID == ItemID)
            {
                player.inventory[0] = items;
                Debug.Log("ID match");
                return;
            }
        }

        Debug.Log("ID not match");
    }

    public void RemoveItem(int ItemID, Players player)
    {
        foreach(var items in itemDatabase)
        {
            if(items.itemID == ItemID)
            {
                player.inventory[0] = null;
                Debug.Log("ID match");
                return;
            }
        }

        Debug.Log("ID not match");
    }
}
