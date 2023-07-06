using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public LevelScore enemiesWiped;
    public ParticleSystem Droplet_PS;
    
    void Start()
    {
        Droplet_PS = GetComponent<ParticleSystem>();
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
        Destroy(gameObject);
        LevelScore.enemiesWiped += 1;
        Droplet_PS.Play();
        //Debug.Log(Destroy(gameObject));
        }
        else{
        projectile.velocity = new Vector3(0f,0f,0f);
        Destroy(gameObject,0.75f);
        }
    }

}
