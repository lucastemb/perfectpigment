using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableManager : MonoBehaviour
{
    public float enemy;
    public static float numOfEnemies = 0f;
    

    void Update()
    {
        
        Debug.Log(CalculateEnemiesKilled());

        
    }

    private float CalculateEnemiesKilled(){
        return((numOfEnemies/enemy));
    }

}
