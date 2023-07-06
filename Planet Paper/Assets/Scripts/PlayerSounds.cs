using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    public AudioSource walking, jump;
   
    void Start()
    {
        
    }


    void Update()
    {
        Debug.Log(PlayerMovement2.jumping);
        if(!(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))){
            walking.Play();
        }
        if(PlayerMovement2.jumping == true){
            jump.Play();
        }
        
    }
}
