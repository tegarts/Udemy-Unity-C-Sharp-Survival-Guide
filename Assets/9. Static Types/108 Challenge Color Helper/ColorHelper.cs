using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorHelper
{
    public static Color[] colors = new Color[]
    {
        Color.red,
        Color.blue,
        Color.green,
        Color.yellow,
        Color.cyan,
        Color.magenta,
        Color.white,
        Color.black
    };
    public static void SpawnObject(PrimitiveType type)
    {
        GameObject.CreatePrimitive(type);
    }

    public static void RandomColor(GameObject obj)
    {
        Renderer renderer = obj.GetComponent<Renderer>();
        renderer.material.color = colors[Random.Range(0, colors.Length)];
    }

    public static void RandomColor2(GameObject obj, Color color, bool randomColors = false)
    {
        if(randomColors == true)
        {
            color = new Color(Random.value, Random.value, Random.value);
        }
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}
