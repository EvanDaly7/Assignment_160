using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fruit
{
    public string name;
    public string color;
    public float weight;

    public Fruit(string name, string c, float w)
    {
        this.name = name;
        color = c;
        weight = w;
    }

    public Fruit()
    {
        name = "mandarin";
        color = "orange";
        weight = 1.0f;
    }

    public Fruit(string name)
    {
        this.name = name;
        color = "blue";
        weight = 2.7f;
    }

    public Fruit(float w)
    {
        name = "watermelon";
        color = "red";
        this.weight = w;

    }
}
