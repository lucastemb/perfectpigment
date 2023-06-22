using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
   
    void Awake()
    {
        Destroy(gameObject, 3);
    }

    public void OnCollisionEnter(Collision col){
        if(col.gameObject.CompareTag("Player")){
            Debug.Log("Hit");
        }
    }

}
