using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleClass2: FruitClass2
{
    public AppleClass2()
    {
        Debug.Log("1st Apple constructor Called");

    }

    public virtual void Chop ()
    {
       
        Debug.Log("The apple has been changed");
    }

    public virtual void SayHello()
    {
       
        Debug.Log("hello i am an apple");
    }
}
  
