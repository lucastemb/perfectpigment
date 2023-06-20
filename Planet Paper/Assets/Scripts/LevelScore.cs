using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text EnemyText;
    private float totalEnemies = 4;
    public static float enemiesWiped = 0;

    void Start()
    {
        enemiesWiped = 0;
    }

    private void AddPoint()
    {
        //totalEnemies = (enemiesWiped / totalEnemies) * 100;
        Debug.Log(enemiesWiped);
    }

    void Update()
    {
        EnemyText.text = "Enemy Percent: " + totalEnemies;
    }
}
