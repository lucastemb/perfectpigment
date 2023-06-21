using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text EnemyText;
    private static float totalEnemies = 4;
    private float sum = 0; 
    public static float enemiesWiped = 0;
    public static int stars = 1;
    public static int devTime = 30; 

    void Start()
    {
        enemiesWiped = 0;
    }



    void Update()
    {
        sum = (enemiesWiped / totalEnemies) * 100;
        EnemyText.text = "Enemy Percent: " + sum;
    }

    public static void numOfStars()
    {
        if (enemiesWiped == totalEnemies)
        {
            stars++;
        }
        /*if (Stopwatch.currentTime < devTime)
        {
            stars++;

        }*/

        Debug.Log(Stopwatch.currentTime);

    }


    
}
