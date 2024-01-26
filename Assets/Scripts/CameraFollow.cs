using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform CameraPoisitionPlayer;
    public Vector3 offsetCamera;
    // Update is called once per frame
    void Update()
    {
        transform.position = CameraPoisitionPlayer.position + offsetCamera;
    }
}