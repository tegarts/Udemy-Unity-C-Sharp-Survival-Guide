using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge123 : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>(); // Ini bisa diganti array aja karna size nya fixed
    public List<GameObject> objectsCreated = new List<GameObject>();

    private Vector2 range = new Vector2(-10, 10);

    public int spawnCount {get; set;}
    private void Start() 
    {
        
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if(spawnCount < 10)
        {
            GameObject randomObject = objects[Random.Range(0, objects.Count)];
            Vector3 randomPosition = new Vector3(Random.Range(range.x, range.y), Random.Range(range.x, range.y), 0);

            GameObject obj = Instantiate(randomObject, randomPosition, Quaternion.identity);

            objectsCreated.Add(obj);
            spawnCount++;
        }
        else
        {
            foreach(var obj in objectsCreated)
            {
                obj.GetComponent<Renderer>().material.color = Color.green;    
            }
            objectsCreated.Clear();
        }
        

    }
}
