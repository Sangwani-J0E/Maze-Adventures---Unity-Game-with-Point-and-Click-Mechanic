using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public void loadnextscene(){
        SceneManager.LoadScene("menu");
    }

}