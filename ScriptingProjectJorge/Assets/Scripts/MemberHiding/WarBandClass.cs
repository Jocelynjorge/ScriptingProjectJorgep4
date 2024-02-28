using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandClass : MonoBehaviour
{

    void Start()
    {
        HumanoidClass human = new HumanoidClass();
        HumanoidClass enemy = new EnemyClass();
        OrcClass Orc = new OrcClass();





        human.yell();
        enemy.yell();
        Orc.Yell();
    }
}
