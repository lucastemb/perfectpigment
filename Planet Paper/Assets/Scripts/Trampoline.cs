using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    public float jumpHeight = 30f;
    void OnTriggerEnter(Collider col){
        if(col.gameObject.CompareTag("Player")){
            Debug.Log("hit");
            PlayerMovement2.velocity.y = Mathf.Sqrt(jumpHeight * -2f * PlayerMovement2.gravity);
        }
    }
}
