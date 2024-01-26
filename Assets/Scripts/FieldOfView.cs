using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FieldOfView : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    public Transform EnemyOrgin;
    private Animator animator;
    public float radius;
    [Range(0,360)]
    public float angle;
    public GameObject playerRef;
    public LayerMask targetMask;
    public LayerMask obstructionMask;
    public bool canSeePlayer;

    private void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVRoutine());
        animator = GetComponent<Animator>();
    }

    private IEnumerator FOVRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);

        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionMask))
                {
                    canSeePlayer = true;
                    //Debug.Log("Player spotted");
                    enemy.SetDestination(player.position);
                    animator.SetBool("IsMoving", true);
                }
                else
                {
                    canSeePlayer = false;
                    enemy.SetDestination(EnemyOrgin.position);
                }

            }
            else
            {
                canSeePlayer = false;
                enemy.SetDestination(EnemyOrgin.position);
            }
        }
        else if (canSeePlayer)
        {
            canSeePlayer = false;
            enemy.SetDestination(EnemyOrgin.position);
        }
    }
}