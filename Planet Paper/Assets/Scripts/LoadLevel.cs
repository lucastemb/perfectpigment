using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{

    [SerializeField]
    public string currentLevel;
    public GameObject scoreboard;  
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
            //scoreboard.SetActive(true);

            
        }
    }

    public string returnString(){
        return currentLevel;
    }
}
