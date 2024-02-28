using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcClass : Enemy
{
    // Start is called before the first frame update
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }

  
}
