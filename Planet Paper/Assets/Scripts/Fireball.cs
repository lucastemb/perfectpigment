using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    void Awake()
    {
        Destroy(gameObject, 3);
    }
    private LoadLevel loadInstance;
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.CompareTag("Player")){

            //Get current level from LoadLevel class and restart level if player is hit
            loadInstance = FindObjectOfType<LoadLevel>();
            string levelValue = loadInstance.currentLevel; 
            LoadLevel.Load(levelValue);
        }
        else if (!col.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
        }
    }
    

}
