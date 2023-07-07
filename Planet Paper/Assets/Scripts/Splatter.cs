using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    public ParticleSystem Droplet_PS;
    void Start()
    {
        Droplet_PS = GetComponent<ParticleSystem>();
    }

    void Update()
    {

    
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Droplet_PS.Play();
            Debug.Log(Droplet_PS);
        }
    }
}
