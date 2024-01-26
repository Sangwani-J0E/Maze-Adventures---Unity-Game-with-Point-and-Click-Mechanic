using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Transform target;
    public Space offsetSpace = Space.Self;
    public bool lookAt = true;
    // Update is called once per frame
    void Update()
    {
        Refresh();
    }
    public void Refresh()
    {
        if(target == null){
            //Debug.LogWarning("missing target ref !, this");
            return;
        }
        if(offsetSpace == Space.Self){
            transform.position = target.TransformPoint(offset);
        }
        else
        {
            transform.rotation=target.rotation;
        }
    }
}
