using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{

    public Car()
    {
        Debug.Log("vytvoril som auto");
    }
    public Car(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        Debug.Log("vytvoril som auto " + this.brand);
    }
}
