using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollisionScript : MonoBehaviour
{
    public MeshRenderer Render;
   public void OnTriggerEnter (Collider CollisionInfo){
    if(CollisionInfo.CompareTag("Star"))
        {
            Render.enabled = false;
            Debug.Log("Star Picked Up");
        }
   }
}
