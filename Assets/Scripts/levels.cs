using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levels : MonoBehaviour
{
       public GameObject gamefinishedui;
        void OnTriggerEnter()
    { 
        Debug.Log("Levels");
        gamefinishedui.SetActive(true);
    }
}
