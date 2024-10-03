using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    public Dictionary<string, int> people = new Dictionary<string, int>();

    public Dictionary<int, string> books = new Dictionary<int, string>();

    private void Start() 
    {
        people.Add("James", 22);
        people.Add("John", 53);
        people.Add("Asep", 31);

        int johnAge = people["John"];
        Debug.Log("John's age is " + johnAge);    

        books.Add(0, "Harry Potter");
        books.Add(1, "The Lord of The Rings");

        foreach(string book in books.Values)
        {
            Debug.Log("Book: " + book);
        }
    }
}
