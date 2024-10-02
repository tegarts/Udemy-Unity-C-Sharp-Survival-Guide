using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEnumDB : MonoBehaviour
{
    public List<ItemEnum> itemDB = new List<ItemEnum>();

    private void Start() {
        foreach (var item in itemDB)
        {
            item.Action();
        }
    }
}
