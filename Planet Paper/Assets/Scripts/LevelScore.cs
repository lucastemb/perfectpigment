using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text EnemyText;
    public float totalEnemies = 4;
    public float enemiesWiped = 0;

    void Start()
    {
        enemiesWiped = 0;
    }

    public void AddPoint(float enemiesWiped)
    {
        totalEnemies = (enemiesWiped / totalEnemies) * 100;
        Debug.Log(totalEnemies);
    }

    private void UpdatePoint()
    {
        EnemyText.text = "Enemy Percent: " + totalEnemies;
    }

    void Update()
    {
        UpdatePoint();
    }
}
