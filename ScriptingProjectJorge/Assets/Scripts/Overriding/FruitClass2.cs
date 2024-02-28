using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass2 : MonoBehaviour 
{
  public FruitClass2()
    {
        Debug.Log("1st Fruit Constructor Called");
    }
public virtual void Chop()
{
        Debug.Log("Fruit has been chopped");
    
}

    public virtual void SayHello()
    {
        Debug.Log("Hello , I am fruit");
    }
}
