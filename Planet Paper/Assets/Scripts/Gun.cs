using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private AudioSource gunshot;
    [SerializeField] private AudioSource enemyDown;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 15f;

    void Update()
    {
        if (PauseMenu.gamePaused == false)
        {
        if(Input.GetMouseButtonDown(0)){
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.up * bulletSpeed;
            gunshot.Play();

        }
        //Since object (bullet) destroys itself, we have to check if that bullet hit and then we can play the sound
        if (Bullet.hit == true){
                enemyDown.Play();
                Bullet.hit=false;
        }
        }
        
    }
}


