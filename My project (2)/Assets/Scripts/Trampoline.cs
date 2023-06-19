using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider col){
        if(col.gameObject.CompareTag("Player")){
            Debug.Log("hit");
            PlayerMovement2.velocity.y = Mathf.Sqrt(14f * -2f * PlayerMovement2.gravity);
        }
    }
}
