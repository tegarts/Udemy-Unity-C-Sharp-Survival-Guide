using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDictionaryDB : MonoBehaviour
{
    public List<ItemDictionary> itemList = new List<ItemDictionary>();
    public Dictionary<int, ItemDictionary> ItemDict = new Dictionary<int, ItemDictionary>();

    private void Start() 
    {
        ItemDictionary sword = new ItemDictionary();
        sword.name = "Sword";
        sword.id = 0;

        ItemDictionary shield = new ItemDictionary();
        shield.name = "Shield";
        shield.id = 1;

        ItemDictionary bread = new ItemDictionary
        {
            name = "Bread",
            id = 2
        };

        itemList.Add(sword);
        ItemDict.Add(0, sword);
        ItemDict.Add(1, shield);
        ItemDict.Add(2, bread);

        foreach(ItemDictionary item in ItemDict.Values)
        {
            Debug.Log("Item Name: " + item.name);
        }

        foreach(KeyValuePair<int, ItemDictionary> item in ItemDict)
        {
            Debug.Log("Item ID: " + item.Key + " Item Name: " + item.Value.name);
        }

        // Buat handle error kalo mau cari key index ke-sekian
        if(ItemDict.ContainsKey(60))
        {
            Debug.Log("We found the key");
            var randomItem = ItemDict[60];
        }
        else
        {
            Debug.Log("Key not found");
        }
    }
}
