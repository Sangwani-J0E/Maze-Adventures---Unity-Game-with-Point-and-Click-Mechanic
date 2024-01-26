using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent enemy;

    public Animator animator;
    public CharacterMovement movement;
    //public SkinnedMeshRenderer render;

    public void OnTriggerEnter (Collider CollisionInfo){
    if(CollisionInfo.CompareTag("Player"))
        {
            movement.enabled = false;
            //render.enabled = false;
            enemy.enabled = false;

            //animator.SetBool("IsMoving", false);
            animator.SetBool("playerdead", true);

            FindObjectOfType<AudioManager>().Play("Death");

            FindObjectOfType<GameManager>().EndGame();
        }
    if(CollisionInfo.GetComponent<Collider>().tag == "EndGame")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}