using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && PlayerMovement2.cheeseburger == true)
        {
            footstepsSound.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                footstepsSound.enabled = false;
                jumpSound.enabled =true;
            }
            else {
                footstepsSound.enabled = true;
                jumpSound.enabled= false;

            }
        }
        else if (Input.GetKey(KeyCode.Space))
            {
                footstepsSound.enabled = false;
                jumpSound.enabled =true;
            }
        else {
            footstepsSound.enabled = false;
            jumpSound.enabled = false; 
        }
    }
}
