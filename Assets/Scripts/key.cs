using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{   
    public MeshRenderer Render;
    public MeshRenderer DoorRender;
    public UnityEngine.AI.NavMeshObstacle NavDev;
    public GameObject door;
    public bool KeyPicked = false;
    public void OnTriggerEnter(Collider CollisionInfo)
   {
        if(CollisionInfo.CompareTag("Player"))
        {
            if(KeyPicked == false)
            {

                FindObjectOfType<AudioManager>().Play("Key");

                Debug.Log("key picked up");
                KeyPicked = true;
                Render.enabled = false;
                DoorRender.enabled = false;
                NavDev.enabled = false;
                door.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}