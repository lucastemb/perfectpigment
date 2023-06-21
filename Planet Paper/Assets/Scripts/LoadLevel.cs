using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{

    public GameObject scoreboard;  
    public void Load(string LevelName)
    {
        Time.timeScale = 1f;
        PauseMenu.gamePaused = false;
        SceneManager.LoadScene(LevelName);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            //SceneManager.LoadScene("Level02");
            scoreboard.SetActive(true);

            
        }
    }
}
