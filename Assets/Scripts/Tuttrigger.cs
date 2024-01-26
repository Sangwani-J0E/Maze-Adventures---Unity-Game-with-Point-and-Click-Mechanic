using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuttrigger : MonoBehaviour
{
    public GameObject tut1;
    public void OnTriggerEnter (Collider CollisionInfo){
    if(CollisionInfo.CompareTag("Player"))
        {
            tut1.SetActive(true);
        }
}
}