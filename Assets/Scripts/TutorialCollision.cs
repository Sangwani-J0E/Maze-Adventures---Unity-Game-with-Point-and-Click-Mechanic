using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCollision : MonoBehaviour
{
    public GameObject GC;
   public void OnTriggerEnter (Collider CollisionInfo){
    if(CollisionInfo.CompareTag("Player"))
        {
            GC.SetActive(true);
        }
   }
}
