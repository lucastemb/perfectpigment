using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement2 : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public static float gravity = -50f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public static Vector3 velocity;
    public bool isGrounded;
    public static bool jumping;


    void Update()
    {   
        if(transform.position.y < -9.0f && (LevelInfo.levels[LoadLevel.currentLevel].getName()=="City" || LevelInfo.levels[LoadLevel.currentLevel].getName()=="Tropic Biome")){
            LoadLevel.Load(LevelInfo.levels[LoadLevel.currentLevel].getName());
        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        jumping=isGrounded;

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -10f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            cheeseburger = true; 
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Tropic Biome");
        }
    }

    private void OnDrawGizmos(){
        Vector3 position = groundCheck.position;
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(position, groundDistance);
    }
}

