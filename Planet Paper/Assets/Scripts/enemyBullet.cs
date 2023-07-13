using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    void Awake()
    {
        Destroy(gameObject, 3);
    }
    private LoadLevel loadInstance;
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.CompareTag("Player")){

            //Get current level from LoadLevel class and restart level if player is hit
            LoadLevel.Load(LevelInfo.levels[LoadLevel.currentLevel].getName());
            LevelScore.enemiesWiped=0;
            
        }
        else if (!col.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
        }
    }
}
