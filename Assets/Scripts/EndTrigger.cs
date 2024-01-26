using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class EndTrigger : MonoBehaviour
{
    public Animator playeranimator;
    void Start()
    {   
        playeranimator= GetComponent<Animator>();
        Advertisement.Initialize("5492349");
    }
    public GameObject triggerPrefab;
        public GameManager GameMngr;

        public GameObject gamefinishedui;
        void OnTriggerEnter()
    {
        UnlockedNewLevel();
        
        FindObjectOfType<AudioManager>().Play("Win");
        Debug.Log("Game Finished");

        Advertisement.Show("Interstitial_Android");
        Debug.Log("You're watching an AD!!!");

        gamefinishedui.SetActive(true);

        playeranimator.SetBool("Celebration", true);

        playeranimator.SetBool ("Celebration", true);
    }
    void UnlockedNewLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex +1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) +1);
            PlayerPrefs.Save();
        }
    }
}
