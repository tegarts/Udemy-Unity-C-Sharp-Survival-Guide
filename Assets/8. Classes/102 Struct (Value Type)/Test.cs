using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The different between class and struct is that struct is a value type and class is a reference type, we can't change or modify the value of struct
// Best use case for struct is when we want to create a small data structure that doesn't need to be modified
public class Stuff
{
    public string names;

    public Stuff(string name)
    {
        this.names = name;
    }
}

public struct Stuff2
{
    public string name;

    public Stuff2(string name)
    {
        this.name = name;
    }
}

public class Test : MonoBehaviour
{
    Stuff box = new Stuff("Box");
    Stuff2 circle;
    void Start()
    {
        circle.name = "Circle";

        Debug.Log("Before: " + circle.name);
        ChangeValue(circle);
        Debug.Log("After: " + circle.name);
    }

    void ChangeValue(Stuff2 structStuff)
    {
        structStuff.name = "Changed"; // We can't change the value of struct
    }

    void ChangeValue(Stuff classStuff)
    {
        classStuff.names = "Changed";
    }
}
