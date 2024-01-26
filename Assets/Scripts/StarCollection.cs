using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollection : MonoBehaviour
{
    public MeshRenderer Render;
    public void OnTriggerEnter (Collider CollisionInfo){
    if(CollisionInfo.CompareTag("Player"))
        {
            Render.enabled = false;
        }
   }

}
