using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float lookRadius = 10f;
    public GameObject bulletPrefab; 
    public float bulletSpeed = 12f;
    
    Transform target;
    NavMeshAgent agent;

    public float attackRadius = 8f;
    private bool hasAttacked;
   
    void Start()
    {
        target = PlayerManager.instance.player.transform;   
        agent = GetComponent<NavMeshAgent>(); 
    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance < lookRadius) ChasePlayer();
        if (distance < attackRadius) AttackPlayer();
    }

    private void ChasePlayer(){
            agent.SetDestination(target.position);
    
    }

    private void AttackPlayer(){
        transform.LookAt(target);
        if (!hasAttacked){
            Vector3 bulletSpawnPoint = new Vector3(transform.position.x, transform.position.y+1f, transform.position.z);
            Rigidbody rb = Instantiate(bulletPrefab, bulletSpawnPoint, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 12f, ForceMode.Impulse);
            hasAttacked = true;
            Invoke(nameof(ResetAttack),0.5f);
        }
    }
    
    private void ResetAttack(){
        hasAttacked = false;
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
