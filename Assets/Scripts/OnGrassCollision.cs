using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrassCollision : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent Player;
    public CharacterMovement movement;
    public Transform Transform;
    //private Animator animator;

    //private void Start()
    //{
    //    animator = GetComponent<Animator>();
    //}

    public void OnTriggerEnter (Collider CollisionInfo){
    if(CollisionInfo.CompareTag("1"))
        {
            
        }
    if(CollisionInfo.GetComponent<Collider>().tag == "EndGame")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
