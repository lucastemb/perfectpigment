using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static bool hit = false;
    public LevelScore enemiesWiped;
    ParticleSystem Droplet_PS;
    
    void Start()
    {
        //Droplet_PS = GetComponent<ParticleSystem>();
    }

    void Awake()
    {
        Destroy(gameObject, 3);
    }


    public void OnCollisionEnter(Collision collision)
    {
        Rigidbody projectile = GetComponent<Rigidbody>();
        if (collision.gameObject.CompareTag("Enemy"))
        {
        Destroy(collision.gameObject);
        hit=true;
        LevelScore.enemiesWiped += 1;
        //Droplet_PS.Play();
        }
        Destroy(gameObject);
    }

}
