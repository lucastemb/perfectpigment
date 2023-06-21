using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject enemy; 
    public LevelScore enemiesWiped;
    
    void Awake()
    {
        Destroy(gameObject, 3);
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        LevelScore.enemiesWiped += 1;
        
        }
    }

}
