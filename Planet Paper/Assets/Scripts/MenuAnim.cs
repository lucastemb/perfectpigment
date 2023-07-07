using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAnim : MonoBehaviour
{

    private Animator anim;
    public AudioSource crumpleplay;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {  
            anim.SetBool("idle", true);
            crumpleplay.Play();
            StartCoroutine(LoadLevel.startGame());
        }
        else
        {
            anim.SetBool("idle", false);
        }

        //if(anim.SetBool("idle", true))
        //{  
        //    crumpleplay.Play();
        //}
    }
    
}
