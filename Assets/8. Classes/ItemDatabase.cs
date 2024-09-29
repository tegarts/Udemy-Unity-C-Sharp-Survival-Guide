using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    Item sword;
    Item hammer;

    public Item[] items;

    private void Start() 
    {
        sword =  new Item("Sword", 0, "This is a sword!");   

        hammer = CreateItem("Hammer", 1, "This is a hammer!");
    }

    public Item CreateItem(string name, int id, string description)
    {
        var item = new Item(name, id, description);

        return item;
    }
}
