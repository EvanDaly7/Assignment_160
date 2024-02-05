using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitSalad;

    // Start is called before the first frame update
    void Start()
    {
        fruitSalad = new List<Fruit>(); //defining the list of fruits

        Fruit fruit = new Fruit("apple", "green", 1.2f);
        
        fruitSalad.Add(fruit);

        CreateFruitSalad();
        DisplayFruitSalad();
    }

    private void DisplayFruitSalad()
    {
        for (int i = 0; i < fruitSalad.Count; i++)
        {
            print(fruitSalad[i].color + " " + fruitSalad[i].name + " weighing " + fruitSalad[i].weight + " units.");
        }
    }

    private void CreateFruitSalad()
    {
        fruitSalad.Add(new Fruit());

        fruitSalad.Add(new Fruit("strawberry"));

        fruitSalad.Add(new Fruit(7.9f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
