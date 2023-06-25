using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private string levelName; 
    private float numOfEnemies;
    private float devTime; 
    

    public Level(string levelName, float numOfEnemies, float devTime){
        this.levelName = levelName;
        this.numOfEnemies = numOfEnemies;
        this.devTime = devTime;
    }

    public string getName(){
        return levelName;
    }

    public float getEnemies(){
        return numOfEnemies;
    }

    public float getDevTime(){
        return devTime;
    }

}
