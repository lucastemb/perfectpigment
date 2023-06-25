using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{

    public static int currentLevel = 0; 
    public static void Load(string LevelName)
    {
        Time.timeScale = 1f;
        PauseMenu.gamePaused = false;
        SceneManager.LoadScene(LevelName);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("Score");

            
        }
    }

    public void incrementLevel(){
        currentLevel+=1;
        Load(LevelInfo.levels[LoadLevel.currentLevel].getName());
    }
}
