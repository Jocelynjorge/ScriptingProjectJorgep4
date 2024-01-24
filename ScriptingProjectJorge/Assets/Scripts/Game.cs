using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private void Start()
    {
        Player myplayer = new Player();

        myplayer.Experience = 5;
        int x = myplayer.Experience;
    }
}
