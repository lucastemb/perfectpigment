using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float jumpForce = 5.0f;
    public bool isOnGround = true; 
    public Rigidbody playerRb;

    public CharacterController controller; 

    public float speed = 12f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        

        Vector3 move = transform.right * x + transform.forward * z; 

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround){
            playerRb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        }
    }
}
