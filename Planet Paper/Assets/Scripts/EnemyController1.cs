using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController1 : MonoBehaviour
{

    public float lookRadius = 10f;
    public GameObject bulletPrefab; 
    Animator playeranimator;
    public float bulletSpeed = 12f;
    
    Transform target;
    NavMeshAgent agent;

    public float attackRadius = 8f;
    private bool hasAttacked;
   
    void Start()
    {
        playeranimator = GetComponent<Animator>();
        target = PlayerManager.instance.player.transform;   
        agent = GetComponent<NavMeshAgent>(); 
    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        transform.LookAt(target);
        transform.Rotate(0,90,0);
        if (distance < lookRadius) ChasePlayer();
        if (distance < attackRadius) AttackPlayer();
        if (distance > lookRadius) Idle();
        // if (Mathf.RoundToInt(agent.velocity.magnitude) == 0) {
        //     playeranimator.SetInteger("legs", 5);
        //     playeranimator.SetInteger("arms",24);
        // }

        
    }

    private void ChasePlayer(){
            playeranimator.SetInteger("legs",1);
            playeranimator.SetInteger("arms",24);
            agent.SetDestination(target.position);
    
    }

    private void AttackPlayer(){
        playeranimator.SetInteger("arms", 27);
        playeranimator.SetInteger("legs", 1);
        if (!hasAttacked){
            Vector3 bulletSpawnPoint = new Vector3(transform.position.x, transform.position.y+1f, transform.position.z);
            Rigidbody rb = Instantiate(bulletPrefab, bulletSpawnPoint, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(-transform.right * 12f, ForceMode.Impulse);
            hasAttacked = true;
            Invoke(nameof(ResetAttack),0.5f);
            
        }
    }
    
    private void Idle(){
        playeranimator.SetInteger("arms",10);
        playeranimator.SetInteger("legs",5);
    }
    private void ResetAttack(){
        hasAttacked = false;
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
