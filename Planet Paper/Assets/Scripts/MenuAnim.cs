using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAnim : MonoBehaviour
{

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {  
            anim.SetBool("idle", true);
            StartCoroutine(LoadLevel.startGame());
        }
        else
        {
            anim.SetBool("idle", false);
        }
    }
    
}
