using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharacterMovement : MonoBehaviour
{
    public Camera Cam;
    public NavMeshAgent player;
    //public GameObject TargetDestination;
    public Animator playeranimator;
    public Rigidbody rb;
    public float speed;

    void Start()
    {   
        playeranimator= GetComponent<Animator>();
    }
    // Update is called once per frame
    
    void Update()
    {
    if( Input.GetMouseButtonDown(0))
        {
          Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
           if (Physics.Raycast(ray, out hitPoint))
            {
                //TargetDestination.transform.position = hitPoint.point;
                player.SetDestination (hitPoint.point);
                playeranimator.SetBool ("PlayerMoving", true);
            } 
        }
        if(player.remainingDistance > player.stoppingDistance)
        {
            Debug.Log("Character is not moving");
            //animator.SetBool ("PlayerMoving", false);
          playeranimator.SetBool ("PlayerMoving", true);
        }
        else
        {
            playeranimator.SetBool ("PlayerMoving", false);
        }
    }
public void OnTriggerEnter (Collider CollisionInfo){
        if(CollisionInfo.CompareTag("enemy")){
         playeranimator.SetBool ("Dead", true);
        }
    }
}