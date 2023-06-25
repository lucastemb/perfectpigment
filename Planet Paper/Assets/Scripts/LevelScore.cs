using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text EnemyText;
    public float totalEnemies = LevelInfo.levels[LoadLevel.currentLevel].getEnemies();
    public float devTime = LevelInfo.levels[LoadLevel.currentLevel].getDevTime();

    private static float sum = 0; 
    public static float enemiesWiped = 0;

    void Start()
    {
        enemiesWiped = 0;
    }

    void Update()
    {
        Debug.Log(totalEnemies);
        sum = (enemiesWiped / totalEnemies) * 100;
        EnemyText.text = "Enemy Percent: " + sum;
    }
}
