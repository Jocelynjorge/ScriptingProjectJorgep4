using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AppleClass2 myApple= new AppleClass2();

        myApple.SayHello();
        myApple.Chop();

        FruitClass2 myFruit = new FruitClass2();
        myFruit.SayHello();
        myFruit.Chop(); 
    }

  
}
