using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    ParticleSystem Droplet_PS;
    void Start()
    {
        Droplet_PS = GetComponent<ParticleSystem>();
    }

    void Update()
    {

    
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Droplet_PS.Play();
            Debug.Log(Droplet_PS);
        }
    }
}
