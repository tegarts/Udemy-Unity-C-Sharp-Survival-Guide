using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public Items[] inventory = new Items[10];
    private ItemDB _itemDatabase;

    private void Start() 
    {
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();    
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _itemDatabase.AddItem(0, this);
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            _itemDatabase.RemoveItem(0, this);
        }
    }
}
