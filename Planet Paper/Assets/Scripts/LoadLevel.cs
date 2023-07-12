using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{

    public static int currentLevel = 3; 
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
        Stats.stars = 1;
        Stats.computed=false;
        Load(LevelInfo.levels[LoadLevel.currentLevel].getName());
    }

    //Main Menu game start delay for animation
    public static IEnumerator startGame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("City");
    }
}
