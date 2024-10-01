using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListRemoveName : MonoBehaviour
{
    public List<string> names = new List<string>();

    private void Start() 
    {
        names.Add("Asep");
        names.Add("Joko");
        names.Add("Budi");
        names.Add("Ujang");
        names.Add("Saiful");   

        PrintName();
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RemoveName();
            PrintName();
        }
    }

    void RemoveName()
    {
        int random = Random.Range(0, names.Count);

        names.Remove(names[random]);

        Debug.Log("Remove Name:" + names[random]);
    }

    void PrintName()
    {
        foreach (var name in names)
        {
            Debug.Log(name);
        } 
    }
}
