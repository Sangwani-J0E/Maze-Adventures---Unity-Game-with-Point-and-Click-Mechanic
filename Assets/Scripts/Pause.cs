using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public GameObject PanelPause;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausegame(){
        Panel.SetActive(true);
        PanelPause.SetActive(false);
        Time.timeScale = 0;
    }
    public void contine(){
        PanelPause.SetActive(true);
        Panel.SetActive(false);
        Time.timeScale = 1;
    }
}
