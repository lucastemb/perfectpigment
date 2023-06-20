using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text EnemyText;
    public float totalEnemies;
    public static float enemiesWiped = 0;
    public static float percentage;

    void Start()
    {
        enemiesWiped = 0;
        //GameObject.FindGameObjectsWithTag("Enemy");
        
    }

    void Update()
    {
        percentage = (enemiesWiped / totalEnemies) * 100;
        EnemyText.text = "Enemy Percent: " + percentage;
        Debug.Log(percentage);
    }
}
