using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardText : MonoBehaviour
{
    public Text level, devTime, finalTime, enemies; 
    public GameObject city, desert, tropic;
    void Start()
    {
        city.SetActive(false);
        desert.SetActive(false);
        tropic.SetActive(false);
        level.text = "LEVEL " + (LoadLevel.currentLevel + 1).ToString();
        devTime.text = "DEV TIME: " +   (LevelInfo.levels[LoadLevel.currentLevel].getDevTime()).ToString();
        finalTime.text = "FINAL TIME: " + Stopwatch.currentTime.ToString();
        enemies.text = "ENEMIES: " + LevelScore.enemiesWiped.ToString() + "/" + LevelInfo.levels[LoadLevel.currentLevel].getEnemies().ToString();  
        if(LoadLevel.currentLevel == 0){
            city.SetActive(true);
        }
        else if(LoadLevel.currentLevel == 1){
            desert.SetActive(true);
        }
        else {
            tropic.SetActive(true);
        }
    }
}
